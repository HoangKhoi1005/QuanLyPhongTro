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
    public partial class frmSuaNT : MetroFramework.Forms.MetroForm
    {
        private NhaTroDTO NhaTro;
        NhaTroBUL nhaTroBUL = new NhaTroBUL();

        public frmSuaNT(NhaTroDTO nhaTroDangChon)
        {
            InitializeComponent();
            NhaTro = nhaTroDangChon;
            txtMaNT.Text = NhaTro.MaNT;
            txtTenNT.Text = NhaTro.TenNT;
            txtDiaChi.Text = NhaTro.DiaChiNT;
        }

        public bool kiemTraThanhCong { get; private set; }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtTenNT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhaTroDTO nhaTro = new NhaTroDTO();
            nhaTro.MaNT = txtMaNT.Text;
            nhaTro.TenNT = txtTenNT.Text;
            nhaTro.DiaChiNT = txtDiaChi.Text;

            if (nhaTroBUL.SuaNhaTro(nhaTro))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Cập nhật nhà trọ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Cập nhật nhà trọ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
