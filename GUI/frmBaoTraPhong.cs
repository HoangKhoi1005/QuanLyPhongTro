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
        private BaoTraPhongBUL baoTraPhongBUL = new BaoTraPhongBUL();
        private PhongBUL phongBUL = new PhongBUL();

        public frmBaoTraPhong(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            this.phong = phong;
            this.frmPhong = frmPhong;

            txtMaPT.Text = phong.MaPT;
            txtMaBaoTra.Text = baoTraPhongBUL.PhatSinhMaBaoTraPhong();
            dtpNgayBao.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
        }

        private void btnLapBaoTraPhong_Click(object sender, EventArgs e)
        {
            if (txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lý do trả phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayTra.Value < dtpNgayBao.Value)
            {
                MessageBox.Show("Ngày trả phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaoTraPhongDTO baoTraPhong = new BaoTraPhongDTO();
            baoTraPhong.MaPT = phong.MaPT;
            baoTraPhong.NgayBao = dtpNgayBao.Value;
            baoTraPhong.MoTa = txtMoTa.Text;
            baoTraPhong.NgayTraPhongDuKien = dtpNgayTra.Value;
            baoTraPhong.MaBaoTra = txtMaBaoTra.Text;

            if (baoTraPhongBUL.ThemBaoTraPhong(baoTraPhong))
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
