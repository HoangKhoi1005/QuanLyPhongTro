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
    public partial class frmThemPhong : MetroFramework.Forms.MetroForm
    {
        private NhaTroDTO NhaTro;
        PhongBUL phongBUL = new PhongBUL();
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        string tenAnh = "";
        public frmThemPhong(NhaTroDTO nhaTroDangChon)
        {
            InitializeComponent();
            NhaTro = nhaTroDangChon;
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

            cboNT.SelectedValue = NhaTro.MaNT;
        }

        private void frmThemPhong_Load(object sender, EventArgs e)
        {
            LoadCboTrangThai();
            LoadCboNhaTro();
            txtMaPT.Text = phongBUL.PhatSinhMaPhong(NhaTro.MaNT);
        }

        public bool kiemTraThanhCong { get; private set; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtDonGia.Text.All(char.IsDigit) == false)
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

            int ThuTu = phongBUL.PhatSinhThuTuPhong(NhaTro.MaNT);

            PhongDTO phong = new PhongDTO();
            phong.MaPT = txtMaPT.Text;
            phong.MaNT = cboNT.SelectedValue.ToString();
            phong.MaTT = cboTT.SelectedValue.ToString();
            phong.TenPhong = txtTenPT.Text;
            phong.DonGia = Convert.ToDecimal(txtDonGia.Text);
            phong.ChieuDai = Convert.ToDouble(txtChieuDai.Text);
            phong.ChieuRong = Convert.ToDouble(txtChieuRong.Text);
            phong.SoLuongNguoiTD = Convert.ToInt32(txtSoLuong.Text);
            phong.MoTa = txtMoTa.Text;
            phong.Anh = tenAnh;
            phong.ThuTu = ThuTu;

            if (phongBUL.ThemPhong(phong))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Thêm phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
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
