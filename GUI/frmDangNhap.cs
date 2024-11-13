using BUL;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        DBConnect db;
        QuanLyBUL qlbul = new QuanLyBUL();
        public frmDangNhap()
        {
            InitializeComponent();
            db = new DBConnect();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.Show();
            this.Hide();
        }

        //Kiểm tra đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if(qlbul.dangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                frmMain frm = new frmMain(txtTaiKhoan.Text);
                frm.Show();
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }    
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }
    }
}
