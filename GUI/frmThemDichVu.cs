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
    public partial class frmThemDichVu : MetroFramework.Forms.MetroForm
    {
        public bool kiemTraThanhCong;
        DichVuBUL dichVuBUL = new DichVuBUL();
        public frmThemDichVu()
        {
            InitializeComponent();
            txtMaDV.Text = dichVuBUL.PhatSinhMaDichVu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtDonGia.Text == string.Empty || txtTenDV.Text == string.Empty)
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
            
            if(dichVuBUL.themDichVu(dichVuDTO))
            {
                MessageBox.Show("Thêm dịch vụ thành công");
                kiemTraThanhCong = true;
                this.Close();
                return;
            }   
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại");
                kiemTraThanhCong = false;
                return;
            }    

            
        }
    }
}
