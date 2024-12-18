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
        private ChiSoDienNuocBUL chiSoDienNuocBUL = new ChiSoDienNuocBUL();
        SuDungDichVuBUL suDungDichVuBUL = new SuDungDichVuBUL();

        public frmLapHopDong(PhongDTO phong, KhachTroDTO khachTro, frmThemKhachTro frmCha)
        {
            InitializeComponent();
            this.phong = phong;
            this.khachTro = khachTro;
            this.frmCha = frmCha;

            txtTenNL.Text = "QL001";
            txtMaPT.Text = phong.MaPT;
            txtTenKT.Text = khachTro.HoTen;
            dtpNgayDenHan.Value = DateTime.Now;
            txtMaHopDong.Text = hopDongBUL.PhatSinhMaHopDong();
            txtTienCoc.Text = string.Format("{0:#,##0}", phong.DonGia);

        }

        private void btnLapHopDon_Click(object sender, EventArgs e)
        {
            ChiSoDienNuocDTO chiSoDienNuocDTO = new ChiSoDienNuocDTO();
            chiSoDienNuocDTO.MaPT = phong.MaPT;
            chiSoDienNuocDTO.ChiSoNuocCu = 0;
            chiSoDienNuocDTO.ChiSoDienCu = 0;
            chiSoDienNuocDTO.ChiSoNuoc = 0;
            chiSoDienNuocDTO.ChiSoDien = 0;
            chiSoDienNuocDTO.NgayThang = DateTime.Now;

            if (!chiSoDienNuocBUL.themDienNuoc(chiSoDienNuocDTO))
            {
                MessageBox.Show("Thêm chỉ số điện nước thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var chiSoDienNuoc = chiSoDienNuocBUL.LayChiSoDienNuocTheoMaPhong(phong.MaPT,DateTime.Now);

            if (chiSoDienNuoc == null)
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện nước của phòng " + txtMaPT.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtTienCoc.Text == "")
            {
                MessageBox.Show("Tiền cọc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tienCocText = txtTienCoc.Text.Replace(",", "");

            if (!tienCocText.All(char.IsDigit))
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
            hopDong.TrangThaiHopDong = false;
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

                    var suDungDichVuDien = new SuDungDichVuDTO
                    {
                        MaPT = hopDong.MaPT,
                        MaDV = "DV001",
                        SoLuong = 1,
                        NgayBatDau = hopDong.NgayLap,
                        NgayKetThuc = hopDong.NgayHetHan
                    };
                    suDungDichVuBUL.themSuDungDichVu(suDungDichVuDien);

                    var suDungDichVuNuoc = new SuDungDichVuDTO
                    {
                        MaPT = hopDong.MaPT,
                        MaDV = "DV002",
                        SoLuong = 1,
                        NgayBatDau = hopDong.NgayLap,
                        NgayKetThuc = hopDong.NgayHetHan
                    };
                    suDungDichVuBUL.themSuDungDichVu(suDungDichVuNuoc);

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
