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
    public partial class frmThemKhachTro_QLKT : MetroFramework.Forms.MetroForm
    {
        public bool kiemTraThanhCong;
        KhachTroBUL khachTroBUL = new KhachTroBUL();
        KhachTroDTO khachTro = new KhachTroDTO();
        string tenAnh = "";
        public frmThemKhachTro_QLKT()
        {
            InitializeComponent();
            txtMaKT.Text = khachTroBUL.PhatSinhMaKhachTro();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public bool KiemTraThongTinNhap()
        {
            if (txtTenKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCCcD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số CCCD của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSoDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSoDT.Text.Length != 10 || !txtSoDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                KhachTroDTO khachTroDTO = new KhachTroDTO();
                khachTroDTO.MaKT = txtMaKT.Text;
                khachTroDTO.HoTen = txtTenKT.Text;
                khachTroDTO.DiaChi = txtDiaChi.Text;
                khachTroDTO.SoDT = txtSoDT.Text;
                khachTroDTO.CCCD = txtCCcD.Text;
                khachTroDTO.Email = txtEmail.Text;
                khachTroDTO.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
                if (radNam.Checked)
                    khachTroDTO.GioiTinh = radNam.Text;
                if (radNu.Checked)
                    khachTroDTO.GioiTinh = radNu.Text;
                khachTroDTO.SoDT = txtSoDT.Text;
                if (File.Exists(khachTroDTO.Anh))
                {
                    pAnh.Image = Image.FromFile(khachTroDTO.Anh);
                    tenAnh = khachTroDTO.Anh;
                }
                else
                {
                    pAnh.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
                }

                khachTroDTO.Anh = tenAnh;
                khachTroDTO.MoTa = txtMoTa.Text;
                khachTroDTO.DaXoa = 0;

                if (khachTroBUL.ThemKhachTro(khachTroDTO))
                {
                    MessageBox.Show("Thêm khách trọ thành công");
                    kiemTraThanhCong = true;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm khách trọ thất bại");
                    kiemTraThanhCong = false;
                    return;
                }
            }
            else
                return;
           
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
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
