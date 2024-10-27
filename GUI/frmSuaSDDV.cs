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
    public partial class frmSuaSDDV : MetroFramework.Forms.MetroForm
    {
        private DichVuBUL dichVuBUL = new DichVuBUL();
        private SuDungDichVuBUL suDungDichVuBUL = new SuDungDichVuBUL();
        private UCDichVu uCDichVu;
        private SuDungDichVuDTO suDungDichVu;

        public frmSuaSDDV(SuDungDichVuDTO suDungDichVu, UCDichVu uCDichVu)
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            suDungDichVu.MaDV = cboDichVu.SelectedValue.ToString();
            suDungDichVu.NgayBatDau = dtpNgayBatDau.Value;
            suDungDichVu.NgayKetThuc = dtpNgayKetThuc.Value;
            suDungDichVu.SoLuong = int.Parse(txtSoLuong.Text);

            if (suDungDichVuBUL.CapNhatSuDungDichVu(suDungDichVu))
            {
                MessageBox.Show("Cập nhật sử dụng dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uCDichVu.dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(suDungDichVu.MaPT);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật sử dụng dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
