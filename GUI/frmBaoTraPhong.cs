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
    public partial class frmBaoTraPhong : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private PhongDTO phong;
        private frmPhong frmPhong;
        private PhieuTraPhongBUL phieuTraPhongBUL = new PhieuTraPhongBUL();
        private PhongBUL phongBUL = new PhongBUL();

        public frmBaoTraPhong(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            this.phong = phong;
            this.frmPhong = frmPhong;

            txtMaPT.Text = phong.MaPT;
            dtpNgayBao.Value = DateTime.Now;
        }

        private void btnLapBaoTraPhong_Click(object sender, EventArgs e)
        {
            if (txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lý do trả phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtTienHoanTra.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền hoàn trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayTra.Value < dtpNgayBao.Value)
            {
                MessageBox.Show("Ngày trả phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtTienHoanTra.Text, out int tienHoanTra))
            {
                MessageBox.Show("Tiền hoàn trả phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhieuTraPhongDTO baoTraPhong = new PhieuTraPhongDTO();
            baoTraPhong.MaPT = phong.MaPT;
            baoTraPhong.NgayBao = dtpNgayBao.Value;
            baoTraPhong.MoTa = txtMoTa.Text;
            baoTraPhong.TienHoanTra = txtTienHoanTra.Text == "" ? 0 : Convert.ToInt32(txtTienHoanTra.Text);
            baoTraPhong.NgayTra = dtpNgayTra.Value;
            baoTraPhong.MaPhieuTra = phieuTraPhongBUL.PhatSinhMaPhieuTraPhong();

            if (phieuTraPhongBUL.ThemPhieuTraPhong(baoTraPhong))
            {
                kiemTraThanhCong = true;
                phongBUL.CapNhatTrangThaiPhong(phong.MaPT, "TT05");
                MessageBox.Show("Lập báo trả phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Lập báo trả phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
