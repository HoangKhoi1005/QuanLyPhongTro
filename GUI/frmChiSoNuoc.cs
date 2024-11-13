using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace GUI
{
    public partial class frmChiSoNuoc : Form
    {
        ChiSoDienNuocDTO cs = new ChiSoDienNuocDTO();
        BindingList<ChiSoDienNuocDTO> chiSoDienNuocList;
        ChiSoDienNuocBUL chiSoDienNuocBUL = new ChiSoDienNuocBUL();
        public frmChiSoNuoc()
        {
            InitializeComponent();
        }

        public void loadCSDienNuoc()
        {
            var csList = chiSoDienNuocBUL.loadDienNuoc();
            chiSoDienNuocList = new BindingList<ChiSoDienNuocDTO>(csList);
            dgvChiSo.DataSource = chiSoDienNuocList;

            foreach (DataGridViewColumn column in dgvChiSo.Columns)
            {
                if (column.Name != "MACS")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }
        
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string input = txtTraCuu.Text.Trim();
            string maPT = "";
            int ngay = 0;
            int thang = 0;
            int nam = 0;

            // Phân tích chuỗi
            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 1) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    else
                    {
                        maPT = parts[0]; 
                    }
                }
                else if (parts.Length == 2) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                }
                else if (parts.Length == 3) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                    if (int.TryParse(parts[2], out int year))
                    {
                        nam = year; 
                    }
                }
            }

            dgvChiSo.DataSource = chiSoDienNuocBUL.TimKiemDienNuoc(maPT, ngay, thang, nam);
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string input = txtTraCuu.Text.Trim();
            string maPT = "";
            int ngay = 0; 
            int thang = 0; 
            int nam = 0;

            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 1) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    else
                    {
                        maPT = parts[0]; 
                    }
                }
                else if (parts.Length == 2) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                }
                else if (parts.Length == 3) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                    if (int.TryParse(parts[2], out int year))
                    {
                        nam = year; 
                    }
                }
            }

            dgvChiSo.DataSource = chiSoDienNuocBUL.TimKiemDienNuoc(maPT, ngay, thang, nam);
        }

        private void frmChiSoNuoc_Load(object sender, EventArgs e)
        {
            dgvChiSo.AllowUserToAddRows = true;
            dgvChiSo.AllowUserToDeleteRows = true;
            dgvChiSo.ReadOnly = false;
            dgvChiSo.EditMode = DataGridViewEditMode.EditOnEnter;
            loadCSDienNuoc();
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (DataGridViewRow row in dgvChiSo.Rows)
            {
                if (row.IsNewRow) continue;

                var chiSoDN = new ChiSoDienNuocDTO
                {
                    MaCS = Convert.ToInt32(row.Cells["MACS"].Value),
                    MaPT = row.Cells["MAPT"].Value.ToString(),  
                    NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),  
                    ChiSoDien = Convert.ToInt32(row.Cells["CHISODIEN"].Value),
                    ChiSoNuoc = Convert.ToInt32(row.Cells["CHISONUOC"].Value)
                };

                if (chiSoDN.MaCS == 0)
                {
                    chiSoDN.MaCS = chiSoDienNuocBUL.PhatSinhMaChiSoDN();
                    chiSoDienNuocBUL.themDienNuoc(chiSoDN);
                    kt = 0;
                }
                else
                {
                    if (kiemTraMa(chiSoDN.MaCS))
                    {
                        chiSoDienNuocBUL.suaDienNuoc(chiSoDN);
                        kt = 1;
                    }
                    else
                    {
                        MessageBox.Show("Mã chỉ số điện nước không tồn tại trong cơ sở dữ liệu.");
                    }
                }
            }

            if (kt == 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sửa thành công");

            loadCSDienNuoc();
        }

        private bool kiemTraMa(int maCS)
        {
            var maChiSo = chiSoDienNuocBUL.loadDienNuoc().FirstOrDefault(dn => dn.MaCS == maCS);
            return maChiSo != null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kt = 0;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvChiSo.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvChiSo.SelectedRows)
                    {
                        if (row.IsNewRow) continue;

                        var chiSoDN = new ChiSoDienNuocDTO
                        {
                            MaCS = Convert.ToInt32(row.Cells["MACS"].Value),
                            MaPT = row.Cells["MAPT"].Value.ToString(),
                            NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                            ChiSoDien = Convert.ToInt32(row.Cells["CHISODIEN"].Value),
                            ChiSoNuoc = Convert.ToInt32(row.Cells["CHISONUOC"].Value)
                        };
                        if (chiSoDienNuocBUL.xoaDienNuoc(chiSoDN))
                        {
                            kt = 1;
                        }
                        else
                        {
                            kt = 0;
                        }
                    }
                    if (kt == 1)
                    {
                        MessageBox.Show("Xóa chỉ số điện nước thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa chỉ số điện nước thất bại");
                    }
                    loadCSDienNuoc();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
                }
            }
            else
                return;
        }
    }
}
