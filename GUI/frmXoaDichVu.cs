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
    public partial class frmXoaDichVu : MetroFramework.Forms.MetroForm
    {
        private DichVuDTO dichVuDTO;
        DichVuBUL dichVuBUL = new DichVuBUL();
        public bool kiemTraThanhCong;
        public frmXoaDichVu(DichVuDTO dichVuDangChon)
        {
            InitializeComponent();
            dichVuDTO = dichVuDangChon;
            txtMaDV.Text = dichVuDTO.MaDV;
            txtTenDV.Text = dichVuDTO.TenDV;
            txtDonGia.Text = dichVuDTO.DonGia.ToString();
            txtMoTa.Text = dichVuDTO.MoTa;
        }

        private void frmXoaDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DichVuDTO dichVuDTO = new DichVuDTO();
            dichVuDTO.MaDV = txtMaDV.Text;
            dichVuDTO.TenDV = txtTenDV.Text;
            dichVuDTO.DonGia = decimal.Parse(txtDonGia.Text.ToString());
            dichVuDTO.MoTa = txtMoTa.Text;
            dichVuDTO.DaXoa = false;

            if (dichVuBUL.xoaDichVu(dichVuDTO))
            {
                MessageBox.Show("Xóa dịch vụ thành công");
                kiemTraThanhCong = true;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Xóa dịch vụ thất bại");
                kiemTraThanhCong = false;
                return;
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
    }
}
