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
    public partial class frmNhanVien : Form
    {
        QuanLyBUL ql = new QuanLyBUL();
        private NhanVienBUL nhanVienBUL = new NhanVienBUL();
        private string maQLDangNhap;
        string tenAnh = "";
        public frmNhanVien(string maQL)
        {
            InitializeComponent();
            maQLDangNhap = maQL;
            if (maQLDangNhap == "")
                maQLDangNhap = "QL001";
            thongTinNV();
        }

        private void thongTinNV()
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien = nhanVienBUL.thongTinNhanVien(maQLDangNhap);

            txtMaQL.Text = nhanVien.MaQL;
            txtTenQL.Text = nhanVien.HoTen;
            txtDiaChi.Text = nhanVien.DiaChi;
            txtSoDT.Text = nhanVien.SoDT;
            txtEmail.Text = nhanVien.Email;
            txtMatKhau.Text = nhanVien.MatKhau;
            if (File.Exists(nhanVien.Anh))
            {
                ptbAnh.Image = Image.FromFile(nhanVien.Anh);
                tenAnh = nhanVien.Anh;
            }
            else
            {
                ptbAnh.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
            }
            dtpNgaySinh.Value = nhanVien.NgaySinh;
            dtpNgayVao.Value = nhanVien.NgayVao;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVienDTO = new NhanVienDTO();
            nhanVienDTO.MaQL = txtMaQL.Text;
            nhanVienDTO.HoTen = txtTenQL.Text;
            nhanVienDTO.DiaChi = txtDiaChi.Text;
            nhanVienDTO.SoDT = txtSoDT.Text;
            nhanVienDTO.Email = txtEmail.Text;
            nhanVienDTO.Anh = tenAnh;
            nhanVienDTO.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
            nhanVienDTO.NgayVao = DateTime.Parse(dtpNgayVao.Value.ToString());
            nhanVienDTO.MatKhau = txtMatKhau.Text;

            if (nhanVienBUL.suaThongTin(nhanVienDTO))
            {
                MessageBox.Show("Sửa thông tin thành công");
                return;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
                return;
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát mọi thao tác sẽ không được lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                thongTinNV();
            else
                return;
        }
    }
}
