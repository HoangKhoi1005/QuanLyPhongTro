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
    public partial class frmXoaNT : MetroFramework.Forms.MetroForm
    {
        private NhaTroDTO NhaTro;
        NhaTroBUL nhaTroBUL = new NhaTroBUL();

        public frmXoaNT(NhaTroDTO nhaTroDangChon)
        {
            InitializeComponent();
            NhaTro = nhaTroDangChon;
            txtMaNT.Text = NhaTro.MaNT;
            txtTenNT.Text = NhaTro.TenNT;
            txtDiaChi.Text = NhaTro.DiaChiNT;
        }

        public bool kiemTraThanhCong { get; private set; }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhaTroBUL.XoaNhaTro(NhaTro.MaNT))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Xóa nhà trọ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Không thể xóa nhà trọ này vì nó còn có phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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
