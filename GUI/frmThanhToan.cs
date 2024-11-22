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
    public partial class frmThanhToan : MetroFramework.Forms.MetroForm
    {
        private string maHD;
        private string maPT;
        private decimal tongTien;
        private decimal tienDaThanhToan;
        private decimal congNo;
        private frmTinhTienPhong frmTinhTienPhong;

        PhongBUL phongBUL = new PhongBUL();

        public frmThanhToan(string maHD, string maPT, decimal tongTien, decimal tienDaThanhToan, decimal congNo, frmTinhTienPhong frmTinhTienPhong)
        {
            InitializeComponent();
            this.maHD = maHD;
            this.maPT = maPT;
            this.tongTien = tongTien;
            this.tienDaThanhToan = tienDaThanhToan;
            this.congNo = congNo;
            this.frmTinhTienPhong = frmTinhTienPhong;
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnMaxCongNo, "Thu toàn bộ còn nợ");

            PhongDTO phong = phongBUL.LayPhongTheoMa(maPT);
            txtCongNo.ForeColor = Color.Red;
            txtCongNo.Text = congNo.ToString("N0");
            txtTongTien.Text = tongTien.ToString("N0");
            txtMaHD.Text = maHD;
            txtMaNT.Text = phong.MaNT;

        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            if (txtSoTienThu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Tiền phải là số
            if (!decimal.TryParse(txtSoTienThu.Text, out _))
            {
                MessageBox.Show("Số tiền thu phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal soTienThu = decimal.Parse(txtSoTienThu.Text);
            if (soTienThu > congNo)
            {
                MessageBox.Show("Số tiền thu không được lớn hơn còn nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thu tiền?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                HoaDonBUL hoaDonBUL = new HoaDonBUL();
                hoaDonBUL.ThuTien(maHD, soTienThu);
                MessageBox.Show("Thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTinhTienPhong.LoadDataGirdViewHoaDon();
                this.Close();
            }
        }

        private void btnMaxCongNo_Click(object sender, EventArgs e)
        {
            txtSoTienThu.Text = congNo.ToString("N0");
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
