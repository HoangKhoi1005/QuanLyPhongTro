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
    public partial class frmSuaPhong : MetroFramework.Forms.MetroForm
    {
        private PhongDTO phong;
        private frmPhong frmPhong;
        internal bool kiemTraThanhCong;
        private HopDongBUL HopDongBUL = new HopDongBUL();

        public frmSuaPhong(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            this.phong = phong;
            UCThongTinPhongTro uCThongTinPhongTro = new UCThongTinPhongTro(phong, frmPhong);
            addUserControl(uCThongTinPhongTro);
            this.frmPhong = frmPhong;
            lblTieuDe.Text += " " + phong.MaPT;
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            grpNoiDung.Controls.Clear();
            grpNoiDung.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThongTInPhongTro_Click(object sender, EventArgs e)
        {
            UCThongTinPhongTro uCThongTinPhongTro = new UCThongTinPhongTro(phong, frmPhong);
            addUserControl(uCThongTinPhongTro);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            UCDichVu uCDichVu = new UCDichVu(phong);
            addUserControl(uCDichVu);
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            UCThanhVien uCThanhVien = new UCThanhVien(phong, frmPhong);
            addUserControl(uCThanhVien);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            if (HopDongBUL.LayHopDongTheoMaPhong(phong.MaPT) == null)
            {
                MessageBox.Show("Phòng này chưa có hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UCHopDong uCHopDong = new UCHopDong(phong);
            addUserControl(uCHopDong);
        }
    }
}
