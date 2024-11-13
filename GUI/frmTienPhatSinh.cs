using BUL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class btnLuu : Form
    {
        PhatSinhDTO ps = new PhatSinhDTO();
        PhatSinhBUL phatSinhBUL = new PhatSinhBUL();
        BindingList<PhatSinhDTO> phatSinhBindingList;
        public btnLuu()
        {
            InitializeComponent();
        }

        public void loadTienPhatSinh()
        {
            var phatSinhList = phatSinhBUL.loadPhatSinh();
            phatSinhBindingList = new BindingList<PhatSinhDTO>(phatSinhList);
            dgvPhatSinh.DataSource = phatSinhBindingList;

            foreach (DataGridViewColumn column in dgvPhatSinh.Columns)
            {
                if (column.Name != "MAPHATSINH")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }
        
        private void frmTienPhatSinh_Load(object sender, EventArgs e)
        {
            dgvPhatSinh.AllowUserToAddRows = true;  
            dgvPhatSinh.AllowUserToDeleteRows = true;  
            dgvPhatSinh.ReadOnly = false;  
            dgvPhatSinh.EditMode = DataGridViewEditMode.EditOnEnter; 
            loadTienPhatSinh();
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (DataGridViewRow row in dgvPhatSinh.Rows)
            {
                if (row.IsNewRow) continue;

                var phatSinh = new PhatSinhDTO
                {
                    MaPS = Convert.ToInt32(row.Cells["MAPHATSINH"].Value),
                    MaPT = row.Cells["MAPT"].Value.ToString(),
                    NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                    SoTien = Convert.ToDecimal(row.Cells["SOTIEN"].Value),
                    MoTa = row.Cells["MOTA"].Value.ToString(),
                    LoaiPS = row.Cells["LoaiPS"].Value.ToString()
                };

                if (phatSinh.MaPS == 0)
                {
                    phatSinh.MaPS = phatSinhBUL.PhatSinhMaPhatSinh();
                    phatSinhBUL.themPhatSinh(phatSinh);
                    kt = 0;
                }
                else
                {
                    if (kiemTraMa(phatSinh.MaPS))
                    {
                        phatSinhBUL.suaPhatSinh(phatSinh);
                        kt = 1;
                    }
                    else
                    {
                        MessageBox.Show("Mã phát sinh không tồn tại trong cơ sở dữ liệu.");
                    }
                }
            }

            if(kt == 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sửa thành công");

            loadTienPhatSinh();
        }

        private void dgvPhatSinh_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (e.RowIndex == dgvPhatSinh.NewRowIndex) // Dòng mới đang được thêm
            //{
            //    // Gán mã phát sinh tự động
            //    dgvPhatSinh.Rows[e.RowIndex].Cells["MAPHATSINH"].Value = phatSinhBUL.PhatSinhMaPhatSinh();  // Gọi phương thức lấy mã mới
            //}
        }

        private bool kiemTraMa(int maPS)
        {
            var maPhatSinh = phatSinhBUL.loadPhatSinh().FirstOrDefault(ps => ps.MaPS == maPS);
            return maPhatSinh != null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kt = 0;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvPhatSinh.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPhatSinh.SelectedRows)
                    {
                        if (row.IsNewRow) continue;

                        var phatSinh = new PhatSinhDTO
                        {
                            MaPS = Convert.ToInt32(row.Cells["MAPHATSINH"].Value),
                            MaPT = row.Cells["MAPT"].Value.ToString(),
                            NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                            SoTien = Convert.ToDecimal(row.Cells["SOTIEN"].Value),
                            MoTa = row.Cells["MOTA"].Value.ToString(),
                            LoaiPS = row.Cells["LoaiPS"].Value.ToString()
                        };
                        if (phatSinhBUL.xoaPhatSinh(phatSinh))
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
                        MessageBox.Show("Xóa phát sinh thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa phát sinh thất bại");
                    }
                    loadTienPhatSinh();
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
