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
    public partial class frmSuaKhachTro_QLKT : MetroFramework.Forms.MetroForm
    {
        KhachTroDTO khachTro;
        KhachTroBUL khachTroBUL = new KhachTroBUL();
        string tenAnh = "";
        public bool kiemTraThanhCong;
        public frmSuaKhachTro_QLKT(KhachTroDTO khachTro)
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
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtMoTa.Text = khachTro.MoTa;
            if (File.Exists(khachTro.Anh))
            {
                pAnh.Image = Image.FromFile(khachTro.Anh);
                tenAnh = khachTro.Anh;
            }
            else
            {
                pAnh.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKT.Text == "" || txtDiaChi.Text == "" || txtSoDT.Text == "" || txtCCCD.Text == "" || txtEmail.Text == "" || txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoDT.Text.Length < 10 || txtSoDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("CCCD không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmail.Text.IndexOf("@") == -1 || txtEmail.Text.IndexOf(".") == -1)
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachTroDTO khachTroDTO = new KhachTroDTO();
            khachTroDTO.MaKT = txtMaKT.Text;
            khachTroDTO.HoTen = txtTenKT.Text;
            khachTroDTO.DiaChi = txtDiaChi.Text;
            khachTroDTO.SoDT = txtSoDT.Text;
            khachTroDTO.CCCD = txtCCCD.Text;
            khachTroDTO.Email = txtEmail.Text;
            khachTroDTO.NgaySinh = dtpNgaySinh.Value;
            if (radNam.Checked)
            {
                khachTroDTO.GioiTinh = "Nam";
            }
            else
            {
                khachTroDTO.GioiTinh = "Nữ";
            }
            khachTroDTO.MoTa = txtMoTa.Text;
            khachTroDTO.Anh = tenAnh;

            if (khachTroBUL.SuaKhachTro(khachTroDTO))
            {
                MessageBox.Show("Cập nhật thông tin khách trọ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kiemTraThanhCong = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách trọ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kiemTraThanhCong = false;
            }
        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pAnh.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
            }
        }
    }
}
