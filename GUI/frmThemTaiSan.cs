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
    public partial class frmThemTaiSan : MetroFramework.Forms.MetroForm
    {
        public bool kiemTraThanhCong;
        TaiSanBUL TaiSanBUL = new TaiSanBUL();
        PhongBUL PhongBUL = new PhongBUL();
        public frmThemTaiSan()
        {
            InitializeComponent();
            txtMaTS.Text = TaiSanBUL.PhatSinhMaTaiSan();
            LoadCboMaPT();
        }

        public void LoadCboMaPT()
        {
            cboMaPT.DataSource = PhongBUL.LayTatCaMaPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaPT.Text == "")
            {
                MessageBox.Show("Mã phòng trọ không được để trống");
                return;
            }

            if (txtTenTS.Text == "")
            {
                MessageBox.Show("Tên tài sản không được để trống");
                return;
            }

            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống");
                return;
            }

            if(dtpNgaySuDung.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sử dụng không được lớn hơn ngày hiện tại");
                return;
            }

            TaiSanDTO taiSan = new TaiSanDTO();
            taiSan.MaPT = cboMaPT.Text;
            taiSan.MaTS = txtMaTS.Text;
            taiSan.TenTaiSan = txtTenTS.Text;
            taiSan.DonGia = decimal.Parse(txtDonGia.Text);
            taiSan.NgaySuDung = dtpNgaySuDung.Value;
            taiSan.NgayThanhLy = null;
            taiSan.MoTa = txtMoTa.Text;
            taiSan.DaXoa = false;
            taiSan.DaHu = false;

            if(TaiSanBUL.ThemTaiSan(taiSan))
            {
                kiemTraThanhCong = true;
                MessageBox.Show("Thêm tài sản thành công");
                this.Close();
            }
            else
            {
                kiemTraThanhCong = false;
                MessageBox.Show("Thêm tài sản thất bại");
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
