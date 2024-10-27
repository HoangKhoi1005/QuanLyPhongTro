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
    public partial class frmThemSDDV : MetroFramework.Forms.MetroForm
    {
        private PhongDTO phong;
        private DichVuBUL dichVuBUL = new DichVuBUL();
        private SuDungDichVuBUL suDungDichVuBUL = new SuDungDichVuBUL();
        private UCDichVu uCDichVu;

        public frmThemSDDV(PhongDTO phong, UCDichVu uCDichVu)
        {
            InitializeComponent();
            this.phong = phong;
            this.uCDichVu = uCDichVu;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            LoadCboDichVu();
            lblTieuDe.Text += " " + phong.MaPT;
        }

        public void LoadCboDichVu()
        {
            cboDichVu.DataSource = dichVuBUL.loadDichVu();
            cboDichVu.DisplayMember = "TENDV";
            cboDichVu.ValueMember = "MADV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (suDungDichVuBUL.KiemTraSuDungDichVuTonTai(phong.MaPT, cboDichVu.SelectedValue.ToString(), dtpNgayBatDau.Value, dtpNgayKetThuc.Value))
            {
                MessageBox.Show("Dịch vụ này đã được sử dụng trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SuDungDichVuDTO suDungDichVu = new SuDungDichVuDTO();
            suDungDichVu.MaPT = phong.MaPT;
            suDungDichVu.MaDV = cboDichVu.SelectedValue.ToString();
            suDungDichVu.NgayBatDau = dtpNgayBatDau.Value;
            suDungDichVu.NgayKetThuc = dtpNgayKetThuc.Value;
            suDungDichVu.SoLuong = int.Parse(txtSoLuong.Text);

            if (suDungDichVuBUL.themSuDungDichVu(suDungDichVu))
            {
                MessageBox.Show("Thêm sử dụng dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uCDichVu.dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(phong.MaPT);
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtSoLuong.Value = 0;
            }
            else
            {
                MessageBox.Show("Thêm sử dụng dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
