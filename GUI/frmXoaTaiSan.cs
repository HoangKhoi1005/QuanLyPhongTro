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
    public partial class frmXoaTaiSan : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private TaiSanDTO taiSan;
        private TaiSanBUL taiSanBUL = new TaiSanBUL();

        public frmXoaTaiSan(TaiSanDTO taiSan)
        {
            InitializeComponent();
            this.taiSan = taiSan;
            txtMaTS.Text = taiSan.MaTS;
            txtTenTS.Text = taiSan.TenTaiSan;
            txtDonGia.Text = taiSan.DonGia.ToString();
            dtpNgaySuDung.Value = taiSan.NgaySuDung;
            cboMaPT.Text = taiSan.MaPT;
            txtMaTS.Text = taiSan.MaTS;
            if (taiSan.NgayThanhLy.HasValue)
            {
                dtpNgayThanhLy.Value = taiSan.NgayThanhLy.Value;
                ckbNgayThanhLy.Checked = true;
            }
            else
            {
                dtpNgayThanhLy.Enabled = false;
                ckbNgayThanhLy.Checked = false;
            }
            txtMoTa.Text = taiSan.MoTa;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài sản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (taiSanBUL.XoaTaiSan(taiSan.MaTS))
                {
                    kiemTraThanhCong = true;
                    MessageBox.Show("Xóa tài sản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    kiemTraThanhCong = false;
                    MessageBox.Show("Xóa tài sản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
