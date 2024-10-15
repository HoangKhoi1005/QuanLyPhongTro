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
    public partial class frmLapHopDong : MetroFramework.Forms.MetroForm
    {
        private PhongDTO phong;
        private KhachTroDTO khachTro;
        private HopDongBUL hopDongBUL = new HopDongBUL();
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        private PhongBUL phongBUL = new PhongBUL();
        private frmThemKhachTro frmCha;

        public frmLapHopDong(PhongDTO phong, KhachTroDTO khachTro, frmThemKhachTro frmCha)
        {
            InitializeComponent();
            this.phong = phong;
            this.khachTro = khachTro;
            this.frmCha = frmCha;

            txtTenNL.Text = "QL001";
            txtMaPT.Text = phong.MaPT;
            txtTenKT.Text = khachTro.HoTen;
            txtMaHopDong.Text = hopDongBUL.PhatSinhMaHopDong();
        }

        private void btnLapHopDon_Click(object sender, EventArgs e)
        {
            if(txtTienCoc.Text == "")
            {
                MessageBox.Show("Tiền cọc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtTienCoc.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Tiền cọc phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayDenHan.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày hết hạn không được nhỏ hơn ngày lập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!khachTroBUL.KiemTraKhachTroTonTai(khachTro.MaKT))
            {
                khachTroBUL.ThemKhachTro(khachTro);
            }

            HopDongDTO hopDong = new HopDongDTO();
            hopDong.MaHopDong = txtMaHopDong.Text;
            hopDong.MaPT = txtMaPT.Text;
            hopDong.MaQL = txtTenNL.Text;
            hopDong.MaKT = khachTro.MaKT;
            hopDong.NgayLap = DateTime.Now;
            hopDong.NgayHetHan = dtpNgayDenHan.Value;
            hopDong.TienCoc = decimal.Parse(txtTienCoc.Text);
            hopDong.MoTa = txtMoTa.Text;

            if (hopDongBUL.ThemHopDong(hopDong))
            {
                KhachTroHopDongDTO khachTroHopDong = new KhachTroHopDongDTO();
                khachTroHopDong.MaHopDong = hopDong.MaHopDong;
                khachTroHopDong.MaKT = hopDong.MaKT;

                if (hopDongBUL.ThemKhachTroHopDong(khachTroHopDong))
                {
                    phong.MaTT = "TT02";
                    phongBUL.CapNhatTrangThaiPhong(phong.MaPT,phong.MaTT);
                    MessageBox.Show("Lập hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCha.kiemTraThanhCong = true;
                    frmCha.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lập hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lập hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
