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
    public partial class frmSuaTaiSan : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private TaiSanDTO taiSan;
        private PhongBUL phongBUL = new PhongBUL();
        private TaiSanBUL taiSanBUL = new TaiSanBUL();

        public frmSuaTaiSan(TaiSanDTO taiSan)
        {
            InitializeComponent();
            LoadCboMaPT();
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

        public void LoadCboMaPT()
        {
            cboMaPT.DataSource = phongBUL.LayTatCaMaPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenTS.Text == "" || txtDonGia.Text == "" || cboMaPT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia))
            {
                MessageBox.Show("Đơn giá phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayThanhLy.Value < dtpNgaySuDung.Value && ckbNgayThanhLy.Checked)
            {
                MessageBox.Show("Ngày thanh lý không được nhỏ hơn ngày sử dụng");
                return;
            }

            TaiSanDTO taiSan = new TaiSanDTO();
            taiSan.MaTS = txtMaTS.Text;
            taiSan.TenTaiSan = txtTenTS.Text;
            taiSan.DonGia = decimal.Parse(txtDonGia.Text.ToString());
            taiSan.NgaySuDung = dtpNgaySuDung.Value;
            taiSan.MaPT = cboMaPT.Text;
            taiSan.MoTa = txtMoTa.Text;
            taiSan.NgayThanhLy = ckbNgayThanhLy.Checked ? (DateTime?)dtpNgayThanhLy.Value : null;

            if (taiSanBUL.SuaTaiSan(taiSan))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Cập nhật tài sản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Cập nhật tài sản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ckbNgayThanhLy_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayThanhLy.Enabled = ckbNgayThanhLy.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                kiemTraThanhCong = false;
                this.Close();
            }
        }
    }
}
