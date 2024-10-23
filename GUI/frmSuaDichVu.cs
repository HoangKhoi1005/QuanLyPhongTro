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
    public partial class frmSuaDichVu : MetroFramework.Forms.MetroForm
    {
        private DichVuDTO dichVuDTO;
        DichVuBUL dichVuBUL = new DichVuBUL();
        public bool kiemTraThanhCong;
        public frmSuaDichVu(DichVuDTO dichVuDangChon)
        {
            InitializeComponent();
            dichVuDTO = dichVuDangChon;
            txtMaDV.Text = dichVuDTO.MaDV;
            txtTenDV.Text = dichVuDTO.TenDV;
            txtDonGia.Text = dichVuDTO.DonGia.ToString();
            txtMoTa.Text = dichVuDTO.MoTa;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //kiemTraThanhCong = false;
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == string.Empty || txtTenDV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (txtDonGia.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Đơn giá phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DichVuDTO dichVuDTO = new DichVuDTO();
            dichVuDTO.MaDV = txtMaDV.Text;
            dichVuDTO.TenDV = txtTenDV.Text;
            dichVuDTO.DonGia = decimal.Parse(txtDonGia.Text.ToString());
            dichVuDTO.MoTa = txtMoTa.Text;
            dichVuDTO.DaXoa = false;

            if (dichVuBUL.suaDichVu(dichVuDTO))
            {
                MessageBox.Show("Sửa dịch vụ thành công");
                kiemTraThanhCong = true;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Sửa dịch vụ thất bại");
                kiemTraThanhCong = false;
                return;
            }
        }
    }
}
