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
    public partial class frmThemNhaTro : MetroFramework.Forms.MetroForm
    {
        NhaTroBUL nhaTroBUL = new NhaTroBUL();

        public frmThemNhaTro()
        {
            InitializeComponent();
            txtMaNT.Text = nhaTroBUL.PhatSinhMaNT();
        }

        public bool kiemTraThanhCong { get; private set; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhaTroDTO nhaTro = new NhaTroDTO();
            nhaTro.MaNT = txtMaNT.Text;
            nhaTro.TenNT = txtTenNT.Text;
            nhaTro.DiaChiNT = txtDiaChi.Text;
            nhaTro.SoDT = "0123456789";
            nhaTro.ChuNhaTro = "Nguyen Van A";
            nhaTro.DaXoa = 0;

            if (nhaTroBUL.ThemNhaTro(nhaTro))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Thêm nhà trọ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Thêm nhà trọ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                kiemTraThanhCong = false;
                this.Close();
            }
        }
    }
}
