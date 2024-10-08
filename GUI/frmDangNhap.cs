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

            string query = "SELECT * FROM QUANLY WHERE MAQL = '" + txtTaiKhoan.Text + "' AND MATKHAU = '" + txtMatKhau.Text + "'";
            using (SqlDataReader reader = db.ExecuteQuery(query))
            {
                if (reader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }
    }
}
