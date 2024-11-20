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

            dtpNgayThang.Format = DateTimePickerFormat.Custom;
            dtpNgayThang.CustomFormat = "MM/yyyy";
            dtpNgayThang.ShowUpDown = true;
        }

        public void loadCSDienNuoc()
        {
            var csList = chiSoDienNuocBUL.loadDienNuoc();
            chiSoDienNuocList = new BindingList<ChiSoDienNuocDTO>(csList);
            dgvChiSo.DataSource = chiSoDienNuocList;
            dgvChiSo.Columns["MACS"].Visible = false;

            foreach (DataGridViewColumn column in dgvChiSo.Columns)
            {
                if (column.Name != "MAPT")
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
                }
                else
                {
                    chiSoDienNuocBUL.suaDienNuoc(chiSoDN);
                }
            }

            MessageBox.Show("Lưu thành công!");
            loadCSDienNuoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa chỉ số điện nước đã nhập không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvChiSo.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvChiSo.SelectedRows)
                    {
                        if (row.IsNewRow) continue; 

                        // Đặt lại các giá trị chỉ số điện nước về mặc định
                        row.Cells["CHISODIEN"].Value = 0;
                        row.Cells["CHISONUOC"].Value = 0;
                    }

                    MessageBox.Show("Đã xóa chỉ số điện nước cho các phòng đã chọn.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa chỉ số điện nước.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void taiDuLieu()
        {
            DateTime selectedDate = dtpNgayThang.Value; 
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            // Tải danh sách mã phòng
            var danhSachPhong = chiSoDienNuocBUL.loadMaPT();
            var danhSachChiSo = chiSoDienNuocBUL.loadDienNuoc();

            List<ChiSoDienNuocDTO> danhSachHienThi = new List<ChiSoDienNuocDTO>();

            foreach (var maPhong in danhSachPhong)
            {
                var chiSoPhong = danhSachChiSo.FirstOrDefault(cs =>
                    cs.MaPT == maPhong &&
                    cs.NgayThang.Month == month &&
                    cs.NgayThang.Year == year);

                if (chiSoPhong != null)
                {
                    danhSachHienThi.Add(chiSoPhong);
                }
                else
                {
                    danhSachHienThi.Add(new ChiSoDienNuocDTO
                    {
                        MaCS = 0, 
                        MaPT = maPhong,
                        NgayThang = new DateTime(year, month, 1), 
                        ChiSoDien = 0, 
                        ChiSoNuoc = 0  
                    });
                }
            }

            chiSoDienNuocList = new BindingList<ChiSoDienNuocDTO>(danhSachHienThi);
            dgvChiSo.DataSource = chiSoDienNuocList;
        }

        private void dtpNgayThang_ValueChanged(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loadCSDienNuoc();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loadCSDienNuoc();            
            }
        }
    }
}
