using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCThongTinPhongTro : UserControl
    {
        private PhongDTO phong;
        PhongBUL phongBUL = new PhongBUL();
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        private frmPhong frmPhong;
        string tenAnh = "";

        public UCThongTinPhongTro(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            LoadCboTrangThai();
            LoadCboNhaTro();
            this.frmPhong = frmPhong;
            this.phong = phong;
            txtMaPT.Text = phong.MaPT;
            txtTenPT.Text = phong.TenPhong;
            txtDonGia.Text = string.Format("{0:#,##0}", phong.DonGia);
            txtChieuDai.Text = phong.ChieuDai.ToString();
            txtChieuRong.Text = phong.ChieuRong.ToString();
            txtSoLuong.Text = phong.SoLuongNguoiTD.ToString();
            txtMoTa.Text = phong.MoTa;
            cboNT.SelectedValue = phong.MaNT;
            cboTT.SelectedValue = phong.MaTT;

            if (File.Exists(phong.Anh))
            {
                ptbAnh.Image = Image.FromFile(phong.Anh);
                tenAnh = phong.Anh;
            }
            else
            {
                ptbAnh.Image = Properties.Resources.DefaultImage;
            }
        }

        private void LoadCboTrangThai()
        {
            cboTT.DataSource = trangThaiPhongBUL.LayTatCaTrangThaiPhong();
            cboTT.DisplayMember = "TENTRANGTHAI";
            cboTT.ValueMember = "MATT";
        }

        private void LoadCboNhaTro()
        {
            cboNT.DataSource = nhaTroBUL.LayDanhSachNhaTro();
            cboNT.DisplayMember = "TenNT";
            cboNT.ValueMember = "MaNT";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string cleanedDonGia = txtDonGia.Text.Replace(",", "");
            if (!cleanedDonGia.All(char.IsDigit))
            {
                MessageBox.Show("Đơn giá phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtChieuDai.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Chiều dài phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtChieuRong.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Chiều rộng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoLuong.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenPT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPT.Focus();
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (txtChieuDai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chiều dài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuDai.Focus();
                return;
            }
            if (txtChieuRong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chiều rộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuRong.Focus();
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng người tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            PhongDTO phong = new PhongDTO();
            phong.MaPT = txtMaPT.Text;
            phong.TenPhong = txtTenPT.Text;
            phong.DonGia = Convert.ToDecimal(txtDonGia.Text);
            phong.ChieuDai = Convert.ToDouble(txtChieuDai.Text);
            phong.ChieuRong = Convert.ToDouble(txtChieuRong.Text);
            phong.SoLuongNguoiTD = Convert.ToInt32(txtSoLuong.Text);
            phong.MoTa = txtMoTa.Text;
            phong.MaNT = cboNT.SelectedValue.ToString();
            phong.MaTT = cboTT.SelectedValue.ToString();
            phong.Anh = tenAnh;
            if (phongBUL.SuaPhong(phong))
            {
                MessageBox.Show("Sửa phòng trọ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPhong.LoadPhongByNhaTro(phong.MaNT);
            }
            else
            {
                MessageBox.Show("Sửa phòng trọ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
            }
        }
    }
}
