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
            dgvChiSo.DataError += dgvChiSo_DataError;
            loadCSDienNuoc();
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            bool isValid = true; 

            foreach (DataGridViewRow row in dgvChiSo.Rows)
            {
                if (row.IsNewRow) continue;

                int chiSoDien = row.Cells["CHISODIEN"].Value != DBNull.Value && row.Cells["CHISODIEN"].Value != null
                                ? Convert.ToInt32(row.Cells["CHISODIEN"].Value)
                                : 0;

                int chiSoNuoc = row.Cells["CHISONUOC"].Value != DBNull.Value && row.Cells["CHISONUOC"].Value != null
                                ? Convert.ToInt32(row.Cells["CHISONUOC"].Value)
                                : 0;

                if (row.Cells["CHISODIEN"].Value == DBNull.Value || row.Cells["CHISONUOC"].Value == DBNull.Value)
                {
                    MessageBox.Show("Chỉ số điện và nước không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    taiDuLieu();
                    return;
                }

                var chiSoDN = new ChiSoDienNuocDTO
                {
                    MaCS = Convert.ToInt32(row.Cells["MACS"].Value),
                    MaPT = row.Cells["MAPT"].Value.ToString(),
                    NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                    ChiSoDien = chiSoDien,
                    ChiSoNuoc = chiSoNuoc,
                    ChiSoDienCu = row.Cells["CHISODIENCU"].Value != DBNull.Value && row.Cells["CHISODIENCU"].Value != null
                                  ? Convert.ToInt32(row.Cells["CHISODIENCU"].Value)
                                  : 0,
                    ChiSoNuocCu = row.Cells["CHISONUOCCU"].Value != DBNull.Value && row.Cells["CHISONUOCCU"].Value != null
                                  ? Convert.ToInt32(row.Cells["CHISONUOCCU"].Value)
                                  : 0
                };

                if (chiSoDN.ChiSoDien <= chiSoDN.ChiSoDienCu || chiSoDN.ChiSoNuoc <= chiSoDN.ChiSoNuocCu)
                {
                    MessageBox.Show("Chỉ số điện và nước mới phải lớn hơn chỉ số điện và nước cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    taiDuLieu();
                    break;
                }
                else
                {
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
            }

            if (isValid)
            {
                MessageBox.Show("Lưu thành công!");
                taiDuLieu();
            }
        }

        private void dgvChiSo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số vào các ô chỉ số điện và nước!",
                                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.ThrowException = false; 
            }
            else
            {
                e.ThrowException = true; 
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa chỉ số điện nước đã nhập không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvChiSo.SelectedRows.Count > 0)
                {
                    var row = dgvChiSo.SelectedRows[0];
                    string maPhong = row.Cells["MAPT"].Value.ToString();
                    MessageBox.Show(maPhong);

                    bool isUpdated = chiSoDienNuocBUL.CapNhatChiSoVe0(maPhong);

                    if (isUpdated)
                    {
                        MessageBox.Show("Xóa điện nước thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        row.Cells["ChiSoDien"].Value = 0;
                        row.Cells["ChiSoNuoc"].Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Xóa điện nước thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var chiSoPhongThangHienTai = danhSachChiSo.FirstOrDefault(cs =>
            cs.MaPT == maPhong &&
            cs.NgayThang.Month == month &&
            cs.NgayThang.Year == year);

                // Tìm chỉ số điện nước của tháng trước
                var chiSoPhongThangTruoc = danhSachChiSo.FirstOrDefault(cs =>
                    cs.MaPT == maPhong &&
                    cs.NgayThang.Month == month - 1 &&
                    cs.NgayThang.Year == year);

                // Tạo đối tượng ChiSoDienNuocDTO mới để thêm vào danh sách hiển thị
                var chiSoDN = new ChiSoDienNuocDTO
                {
                    MaCS = chiSoPhongThangHienTai != null ? chiSoPhongThangHienTai.MaCS : 0,
                    MaPT = maPhong,
                    NgayThang = new DateTime(year, month, 1),
                    ChiSoDien = chiSoPhongThangHienTai != null ? chiSoPhongThangHienTai.ChiSoDien : 0,
                    ChiSoNuoc = chiSoPhongThangHienTai != null ? chiSoPhongThangHienTai.ChiSoNuoc : 0,
                    ChiSoDienCu = chiSoPhongThangTruoc != null ? chiSoPhongThangTruoc.ChiSoDien : 0, // Chỉ số điện cũ
                    ChiSoNuocCu = chiSoPhongThangTruoc != null ? chiSoPhongThangTruoc.ChiSoNuoc : 0 // Chỉ số nước cũ
                };

                danhSachHienThi.Add(chiSoDN);
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
