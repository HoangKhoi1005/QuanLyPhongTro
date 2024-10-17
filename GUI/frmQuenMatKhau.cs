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
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập email");
                return;
            }
            else
            {
                if (qlbul.quenMatKhau(txtEmail.Text))
                {
                    string email = txtEmail.Text;
                    string password = qlbul.layMatKhau(email);
                    SendPasswordByEmail(email, password);
                    MessageBox.Show("Mật khẩu đã được gửi về email.");
                }
                else
                {
                    MessageBox.Show("Người dùng này chưa được đăng ký");
                    txtEmail.Clear();
                    txtNhapCapcha.Clear();
                    GenerateCaptcha();
                    return;
                }
            }
        }

        private void SendPasswordByEmail(string toEmail, string password)
        {
            try
            {
                string subject = "MẬT KHẨU CỦA BẠN";
                string body = "Mật khẩu là: " + password;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("vuhuyenvi2003@gmail.com");
                    mail.To.Add(toEmail);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                    {
                        smtp.Port = 587;
                        smtp.Credentials = new NetworkCredential("vuhuyenvi2003@gmail.com", "kbjvbqynzuztrsji");
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
    }
}
