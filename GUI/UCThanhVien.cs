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

namespace GUI
{
    public partial class UCThanhVien : UserControl
    {
        private PhongDTO phong;
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        private HopDongBUL HopDongBUL = new HopDongBUL();
        private frmPhong frmPhong;

        public UCThanhVien(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            this.phong = phong;
            this.frmPhong = frmPhong;
            dgvThanhVien.DataSource = khachTroBUL.LayThanhVienTheoPhong(phong.MaPT);
            int soLuongKhach = HopDongBUL.DemSoLuongKhachTroTrongHopDong(HopDongBUL.TimMaHopDongTheoMaPhong(phong.MaPT));
            if (soLuongKhach == phong.SoLuongNguoiTD)
            {
                btnThem.Visible = false;
                btnCapNhat.Location = new Point(3, 626);
                btnXoa.Location = new Point(250, 626);
            }
        }

        Form overlayPanel;


        private void ShowOverlay()
        {
            overlayPanel = new Form();
            overlayPanel.FormBorderStyle = FormBorderStyle.None;
            overlayPanel.StartPosition = FormStartPosition.Manual;
            overlayPanel.Location = this.Location;
            overlayPanel.Opacity = .50d;
            overlayPanel.BackColor = Color.Black;
            overlayPanel.WindowState = FormWindowState.Maximized;
            overlayPanel.ShowInTaskbar = false;
            overlayPanel.Show();
        }

        private void HideOverlay()
        {
            overlayPanel.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemKhachTro formThemKhachTro = new frmThemKhachTro(phong);
            formThemKhachTro.FormClosed += (s, args) =>
            {
                if (formThemKhachTro.kiemTraThanhCong)
                {
                    frmPhong.LoadPhongByNhaTro(phong.MaNT);
                }
            };
            formThemKhachTro.ShowDialog();
            HideOverlay();
            dgvThanhVien.DataSource = khachTroBUL.LayThanhVienTheoPhong(phong.MaPT);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            if (dgvThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách trọ để cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachTroDTO khachTro = new KhachTroDTO();
                khachTro.MaKT = dgvThanhVien.SelectedRows[0].Cells["MAKT"].Value.ToString();
                khachTro.HoTen = dgvThanhVien.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                khachTro.NgaySinh = Convert.ToDateTime(dgvThanhVien.SelectedRows[0].Cells["NgaySinh"].Value);
                khachTro.GioiTinh = dgvThanhVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                khachTro.CCCD = dgvThanhVien.SelectedRows[0].Cells["CCCD"].Value.ToString();
                khachTro.SoDT = dgvThanhVien.SelectedRows[0].Cells["SODT"].Value.ToString();
                khachTro.Email = dgvThanhVien.SelectedRows[0].Cells["Email"].Value.ToString();
                khachTro.DiaChi = dgvThanhVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                khachTro.Anh = dgvThanhVien.SelectedRows[0].Cells["ANH"].Value.ToString();
                khachTro.MoTa = dgvThanhVien.SelectedRows[0].Cells["MoTa"].Value.ToString();
                frmSuaKhachTro formCapNhatKhachTro = new frmSuaKhachTro(khachTro);
                formCapNhatKhachTro.FormClosed += (s, args) =>
                {
                    if (formCapNhatKhachTro.kiemTraThanhCong)
                    {
                        frmPhong.LoadPhongByNhaTro(phong.MaNT);
                        dgvThanhVien.DataSource = khachTroBUL.LayThanhVienTheoPhong(phong.MaPT);
                    }
                };
                formCapNhatKhachTro.ShowDialog();
            }
            HideOverlay();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            if (dgvThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách trọ để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachTroDTO khachTro = new KhachTroDTO();
                khachTro.MaKT = dgvThanhVien.SelectedRows[0].Cells["MAKT"].Value.ToString();
                khachTro.HoTen = dgvThanhVien.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                khachTro.NgaySinh = Convert.ToDateTime(dgvThanhVien.SelectedRows[0].Cells["NgaySinh"].Value);
                khachTro.GioiTinh = dgvThanhVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                khachTro.CCCD = dgvThanhVien.SelectedRows[0].Cells["CCCD"].Value.ToString();
                khachTro.SoDT = dgvThanhVien.SelectedRows[0].Cells["SODT"].Value.ToString();
                khachTro.Email = dgvThanhVien.SelectedRows[0].Cells["Email"].Value.ToString();
                khachTro.DiaChi = dgvThanhVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                khachTro.Anh = dgvThanhVien.SelectedRows[0].Cells["ANH"].Value.ToString();
                khachTro.MoTa = dgvThanhVien.SelectedRows[0].Cells["MoTa"].Value.ToString();
                frmXoaKhachTro formXoaKhachTro = new frmXoaKhachTro(khachTro);
                formXoaKhachTro.FormClosed += (s, args) =>
                {
                    if (formXoaKhachTro.kiemTraThanhCong)
                    {
                        frmPhong.LoadPhongByNhaTro(phong.MaNT);
                        dgvThanhVien.DataSource = khachTroBUL.LayThanhVienTheoPhong(phong.MaPT);
                    }
                };
                formXoaKhachTro.ShowDialog();
            }
            HideOverlay();
           
        }

        private void dgvThanhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowOverlay();
            if (dgvThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách trọ để cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachTroDTO khachTro = new KhachTroDTO();
                khachTro.MaKT = dgvThanhVien.SelectedRows[0].Cells["MAKT"].Value.ToString();
                khachTro.HoTen = dgvThanhVien.SelectedRows[0].Cells["HOTEN"].Value.ToString();
                khachTro.NgaySinh = Convert.ToDateTime(dgvThanhVien.SelectedRows[0].Cells["NgaySinh"].Value);
                khachTro.GioiTinh = dgvThanhVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                khachTro.CCCD = dgvThanhVien.SelectedRows[0].Cells["CCCD"].Value.ToString();
                khachTro.SoDT = dgvThanhVien.SelectedRows[0].Cells["SODT"].Value.ToString();
                khachTro.Email = dgvThanhVien.SelectedRows[0].Cells["Email"].Value.ToString();
                khachTro.DiaChi = dgvThanhVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                khachTro.Anh = dgvThanhVien.SelectedRows[0].Cells["ANH"].Value.ToString();
                khachTro.MoTa = dgvThanhVien.SelectedRows[0].Cells["MoTa"].Value.ToString();
                frmSuaKhachTro formCapNhatKhachTro = new frmSuaKhachTro(khachTro);
                formCapNhatKhachTro.FormClosed += (s, args) =>
                {
                    if (formCapNhatKhachTro.kiemTraThanhCong)
                    {
                        frmPhong.LoadPhongByNhaTro(phong.MaNT);
                        dgvThanhVien.DataSource = khachTroBUL.LayThanhVienTheoPhong(phong.MaPT);
                    }
                };
                formCapNhatKhachTro.ShowDialog();
            }
            HideOverlay();
        }
    }
}
