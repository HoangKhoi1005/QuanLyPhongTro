using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXoaKhachTro : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private KhachTroDTO khachTro;
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        string tenAnh = "";

        public frmXoaKhachTro(KhachTroDTO khachTro)
        {
            InitializeComponent();
            this.khachTro = khachTro;
            txtMaKT.Text = khachTro.MaKT;
            txtTenKT.Text = khachTro.HoTen;
            txtDiaChi.Text = khachTro.DiaChi;
            txtSoDT.Text = khachTro.SoDT;
            txtCCCD.Text = khachTro.CCCD;
            txtEmail.Text = khachTro.Email;
            dtpNgaySinh.Value = khachTro.NgaySinh;
            if (khachTro.GioiTinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtMoTa.Text = khachTro.MoTa;
            if (File.Exists(khachTro.Anh))
            {
                ptbKhachTro.Image = Image.FromFile(khachTro.Anh);
                tenAnh = khachTro.Anh;
            }
            else
            {
                ptbKhachTro.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách trọ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (khachTroBUL.XoaKhachTroHopDong(khachTro.MaKT))
                {
                    kiemTraThanhCong = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kiemTraThanhCong = false;
                }
            }
        }
    }
}
