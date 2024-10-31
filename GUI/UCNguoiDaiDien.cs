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
    public partial class UCNguoiDaiDien : UserControl
    {
        private PhongDTO phong;
        private HopDongBUL hopDongBUL = new HopDongBUL();
        private KhachTroDTO nguoiDaiDien;
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        string tenAnh = "";

        public UCNguoiDaiDien(PhongDTO phong)
        {
            InitializeComponent();
            this.phong = phong;
            nguoiDaiDien = khachTroBUL.LayNguoiDaiDienTheoPhong(phong.MaPT);

            txtMaKT.Text = nguoiDaiDien.MaKT;
            txtTenKT.Text = nguoiDaiDien.HoTen;
            txtDiaChi.Text = nguoiDaiDien.DiaChi;
            txtSoDT.Text = nguoiDaiDien.SoDT;
            txtCCCD.Text = nguoiDaiDien.CCCD;
            txtEmail.Text = nguoiDaiDien.Email;
            dtpNgaySinh.Value = nguoiDaiDien.NgaySinh;
            if (nguoiDaiDien.GioiTinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtMoTa.Text = nguoiDaiDien.MoTa;
            if (File.Exists(nguoiDaiDien.Anh))
            {
                ptbKhachTro.Image = Image.FromFile(nguoiDaiDien.Anh);
                tenAnh = nguoiDaiDien.Anh;
            }
            else
            {
                ptbKhachTro.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKT.Text == "" || txtDiaChi.Text == "" || txtSoDT.Text == "" || txtCCCD.Text == "" || txtEmail.Text == "" || txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdbNam.Checked == false && rdbNu.Checked == false)
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
            if (rdbNam.Checked)
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

            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách trọ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbKhachTro_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbKhachTro.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenKT.Text = nguoiDaiDien.HoTen;
            txtDiaChi.Text = nguoiDaiDien.DiaChi;
            txtSoDT.Text = nguoiDaiDien.SoDT;
            txtCCCD.Text = nguoiDaiDien.CCCD;
            txtEmail.Text = nguoiDaiDien.Email;
            dtpNgaySinh.Value = nguoiDaiDien.NgaySinh;
            if (nguoiDaiDien.GioiTinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtMoTa.Text = nguoiDaiDien.MoTa;
            if (File.Exists(nguoiDaiDien.Anh))
            {
                ptbKhachTro.Image = Image.FromFile(nguoiDaiDien.Anh);
                tenAnh = nguoiDaiDien.Anh;
            }
            else
            {
                ptbKhachTro.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
            }
        }
    }
}
