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
    public partial class frmHuyDatPhong : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private PhongDTO phong;
        private frmPhong frmPhong;
        private PhieuDatPhongBUL PhieuDatPhongBUL = new PhieuDatPhongBUL();
        private PhieuDatPhongDTO phieuDatPhong;
        private PhongBUL phongBUL = new PhongBUL();

        public frmHuyDatPhong(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            this.phong = phong;
            this.frmPhong = frmPhong;

            phieuDatPhong = PhieuDatPhongBUL.LayPhieuDatPhongTheoMaPhong(phong.MaPT);
            txtMaPhieuDat.Text = phieuDatPhong.MaPhieuDatPhong;
            txtMaPT.Text = phieuDatPhong.MaPhongTro;
            txtTenKT.Text = phieuDatPhong.MaKhachTro;
            txtTenNL.Text = phieuDatPhong.MaQuanLy;
            txtTienCoc.Text = phieuDatPhong.TienDatPhong.ToString();
            dtpNgayNhanPhong.Value = phieuDatPhong.NgayDuKienNhanPhong;
            txtMoTa.Text = phieuDatPhong.MoTa;
        }

        private void btnHuyPhieuDat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu đặt phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PhieuDatPhongBUL.XoaPhieuDatPhong(phieuDatPhong.MaPhieuDatPhong))
                {
                    kiemTraThanhCong = true;
                    phongBUL.CapNhatTrangThaiPhong(phong.MaPT, "TT01");
                    MessageBox.Show("Hủy phiếu đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hủy phiếu đặt phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
