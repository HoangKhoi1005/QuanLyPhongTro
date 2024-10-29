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
    public partial class frmXoaSDDV : MetroFramework.Forms.MetroForm
    {
        private DichVuBUL dichVuBUL = new DichVuBUL();
        private SuDungDichVuBUL suDungDichVuBUL = new SuDungDichVuBUL();
        private UCDichVu uCDichVu;
        private SuDungDichVuDTO suDungDichVu;

        public frmXoaSDDV(SuDungDichVuDTO suDungDichVu, UCDichVu uCDichVu)
        {
            InitializeComponent();
            this.suDungDichVu = suDungDichVu;
            this.uCDichVu = uCDichVu;
            LoadCboDichVu();
            dtpNgayBatDau.Value = suDungDichVu.NgayBatDau;
            dtpNgayKetThuc.Value = suDungDichVu.NgayKetThuc;
            txtSoLuong.Text = suDungDichVu.SoLuong.ToString();
            lblTieuDe.Text += " " + suDungDichVu.MaPT;
        }

        public void LoadCboDichVu()
        {
            cboDichVu.DataSource = dichVuBUL.loadDichVu();
            cboDichVu.DisplayMember = "TENDV";
            cboDichVu.ValueMember = "MADV";
            cboDichVu.SelectedValue = suDungDichVu.MaDV;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sử dụng dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (suDungDichVuBUL.XoaSuDungDichVu(suDungDichVu.MaPT, suDungDichVu.MaDV, suDungDichVu.NgayBatDau))
                {
                    MessageBox.Show("Xóa sử dụng dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uCDichVu.dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(suDungDichVu.MaPT);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa sử dụng dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
