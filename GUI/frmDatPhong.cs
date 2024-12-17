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
    public partial class frmDatPhong : MetroFramework.Forms.MetroForm
    {
        private PhongDTO phong;
        private KhachTroDTO khachTro;
        private PhieuDatPhongBUL PhieuDatPhongBUL = new PhieuDatPhongBUL();
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        private PhongBUL phongBUL = new PhongBUL();
        private frmThemKhachTro frmCha;

        public frmDatPhong(PhongDTO phong, KhachTroDTO khachTro, frmThemKhachTro frmCha)
        {
            InitializeComponent();
            this.phong = phong;
            this.khachTro = khachTro;
            this.frmCha = frmCha;

            dtpNgayNhanPhong.Value = DateTime.Now;
            txtMaPT.Text = phong.MaPT;
            txtTenKT.Text = khachTro.HoTen;
            txtTenNL.Text = "QL001";
            txtMaPhieuDat.Text = PhieuDatPhongBUL.PhatSinhMaPhieuDatPhong();
            txtTienCoc.Text = phong.DonGia.ToString();
        }

        private void btnLapPhieuDat_Click(object sender, EventArgs e)
        {
            if (txtTienCoc.Text == "")
            {
                MessageBox.Show("Tiền đặt phòng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTienCoc.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Tiền đặt phòng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayNhanPhong.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày nhận phòng không được nhỏ hơn ngày lập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!khachTroBUL.KiemTraKhachTroTonTai(khachTro.MaKT))
            {
                khachTroBUL.ThemKhachTro(khachTro);
            }

            PhieuDatPhongDTO phieuDatPhongDTO = new PhieuDatPhongDTO();
            phieuDatPhongDTO.MaPhieuDatPhong = txtMaPhieuDat.Text;
            phieuDatPhongDTO.MaKhachTro = khachTro.MaKT;
            phieuDatPhongDTO.MaPhongTro = phong.MaPT;
            phieuDatPhongDTO.MaQuanLy = "QL001";
            phieuDatPhongDTO.NgayDuKienNhanPhong = dtpNgayNhanPhong.Value;
            phieuDatPhongDTO.TienDatPhong = decimal.Parse(txtTienCoc.Text);
            phieuDatPhongDTO.NgayLapPhieu = DateTime.Now;
            phieuDatPhongDTO.MoTa = txtMoTa.Text;

            if (PhieuDatPhongBUL.ThemPhieuDatPhong(phieuDatPhongDTO))
            {
                phong.MaTT = "TT04";
                phongBUL.CapNhatTrangThaiPhong(phong.MaPT, phong.MaTT);
                MessageBox.Show("Lập phiếu đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCha.kiemTraThanhCong = true;
                frmCha.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lập phiếu đặt phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
