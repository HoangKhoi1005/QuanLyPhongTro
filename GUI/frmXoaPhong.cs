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
    public partial class frmXoaPhong : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private PhongDTO phong;
        private frmPhong frmPhong;
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        HopDongBUL hopDongBUL = new HopDongBUL();
        PhongBUL phongBUL = new PhongBUL();

        public frmXoaPhong(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            LoadCboNhaTro();
            LoadCboTrangThai();

            this.phong = phong;
            this.frmPhong = frmPhong;
            txtChieuDai.Text = phong.ChieuDai.ToString();
            txtChieuRong.Text = phong.ChieuRong.ToString();
            txtDonGia.Text = phong.DonGia.ToString();
            txtMaPT.Text = phong.MaPT;
            txtTenPT.Text = phong.TenPhong;
            cboNT.SelectedValue = phong.MaNT;
            cboTT.SelectedValue = phong.MaTT;
            txtSoLuong.Value = phong.SoLuongNguoiTD;
            if (!string.IsNullOrEmpty(phong.Anh) && System.IO.File.Exists(phong.Anh))
            {
                ptbAnh.Image = Image.FromFile(phong.Anh);
            }
            else
            {
                ptbAnh.Image = Properties.Resources.DefaultImage;
            }

        }

        private void LoadCboTrangThai()
        {
            cboTT.DataSource = trangThaiPhongBUL.LayTatCaTrangThaiPhong();
            cboTT.DisplayMember = "TENTRANGTHAI";
            cboTT.ValueMember = "MATT";
        }

        private void LoadCboNhaTro()
        {
            cboNT.DataSource = nhaTroBUL.LayDanhSachNhaTro();
            cboNT.DisplayMember = "TenNT";
            cboNT.ValueMember = "MaNT";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (hopDongBUL.KiemTraPhongCoHopDong(phong.MaPT))
            {
                MessageBox.Show("Phòng đang có hợp đồng, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phongBUL.XoaPhong(phong.MaPT))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Xóa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kiemTraThanhCong = false;
            }
        }
    }
}
