using BUL;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuenMatKhau : Form
    {
        DBConnect db;
        QuanLyBUL qlbul = new QuanLyBUL();

        private const int CaptchaLength = 6;
        private string captchaCode = string.Empty;
        public frmQuenMatKhau()
        {
            InitializeComponent();
            db = new DBConnect();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        private string GenerateRandomCaptcha(int length)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] captcha = new char[length];

            for (int i = 0; i < length; i++)
            {
                captcha[i] = characters[random.Next(characters.Length)];
            }

            return new string(captcha);
        }
        private void GenerateCaptcha()
        {
            captchaCode = GenerateRandomCaptcha(CaptchaLength);
            txtMaCapCha.Text = captchaCode;
        }

        private void btnLayMK_Click(object sender, EventArgs e)
        {
            if (txtNhapCapcha.Text != txtMaCapCha.Text)
            {
                MessageBox.Show("Mã đã nhập không đúng");
                GenerateCaptcha();
                txtNhapCapcha.Clear();
                return;
            }
            if (txtMaQuanLy.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã quản lý");
                return;
            }
            else
            {
                if (qlbul.quenMatKhau(txtMaQuanLy.Text))
                {
                    string maql = txtMaQuanLy.Text;
                    bool resetSuccess = qlbul.datLaiMatKhau(maql);

                    if (resetSuccess)
                        MessageBox.Show("Mật khẩu của bạn là: " + maql);
                    else
                        MessageBox.Show("Đặt lại mật khẩu thất bại");
                }
                else
                {
                    MessageBox.Show("Người dùng này chưa được đăng ký");
                    txtMaQuanLy.Clear();
                    txtNhapCapcha.Clear();
                    GenerateCaptcha();
                    return;
                }
            }
        }

        

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
    }
}
