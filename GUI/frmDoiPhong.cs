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
using TheArtOfDevHtmlRenderer.Adapters;

namespace GUI
{
    public partial class frmDoiPhong : MetroFramework.Forms.MetroForm
    {
        internal bool kiemTraThanhCong;
        private PhongDTO phong;
        private frmPhong frmPhong;
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        HopDongBUL hopDongBUL = new HopDongBUL();
        PhongBUL phongBUL = new PhongBUL();
        KhachTroBUL khachTroBUL = new KhachTroBUL();
        LichSuChuyenPhongBUL lichSuChuyenPhongBUL = new LichSuChuyenPhongBUL();

        public frmDoiPhong(PhongDTO phong, frmPhong frmPhong)
        {
            InitializeComponent();
            dtpNgayChuyen.Value = DateTime.Now;
            this.phong = phong;
            this.frmPhong = frmPhong;
            LoadCboNhaTro();
        }

        private void LoadCboNhaTro()
        {
            cboMaNT.DataSource = nhaTroBUL.LayDanhSachNhaTro();
            cboMaNT.DisplayMember = "TenNT";
            cboMaNT.ValueMember = "MaNT";
        }

        public void LoadCboPhong()
        {
            PhongBUL phongBUL = new PhongBUL();
            cboMaPT.DataSource = phongBUL.LayPhongTrongTheoNhaTro(cboMaNT.SelectedValue.ToString());
            cboMaPT.DisplayMember = "MaPT";
            cboMaPT.ValueMember = "MaPT";
        }

        private void cboMaNT_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCboPhong();
        }

        private void btnDoiPhong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                PhongDTO phongCanChuyenDen = phongBUL.LayPhongTheoMa(cboMaPT.SelectedValue.ToString());
                int soLuongKhach = hopDongBUL.DemSoLuongKhachTroTrongHopDong(hopDongBUL.TimMaHopDongTheoMaPhong(phong.MaPT));
                if (soLuongKhach > phongCanChuyenDen.SoLuongNguoiTD)
                {
                    MessageBox.Show("Phòng cần chuyển đến không đủ số lượng, vui lòng chọn phòng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Kết thúc hợp đồng cũ, tạo hợp đồng mới, tạo hóa đơn mới
                HopDongDTO hopDong = hopDongBUL.LayHopDongTheoMaPhong(phong.MaPT);
                hopDongBUL.CapNhatTrangThaiHopDong(hopDong.MaHopDong, 0);

                HopDongDTO hopDongMoi = new HopDongDTO();
                hopDongMoi.MaHopDong = hopDongBUL.PhatSinhMaHopDong();
                hopDongMoi.MaPT = cboMaPT.SelectedValue.ToString();
                hopDongMoi.MaQL = hopDong.MaQL;
                hopDongMoi.MaKT = hopDong.MaKT;
                hopDongMoi.NgayLap = DateTime.Now;
                hopDongMoi.NgayHetHan = hopDong.NgayHetHan;
                hopDongMoi.TienCoc = hopDong.TienCoc;
                hopDongMoi.MoTa = hopDong.MoTa;
                hopDongBUL.ThemHopDong(hopDongMoi);

                List<KhachTroHopDongDTO> khachTroHopDongs = hopDongBUL.LayDanhSachKhachTroHopDong(hopDong.MaHopDong);
                foreach (KhachTroHopDongDTO khachTroHopDong in khachTroHopDongs)
                {
                    khachTroHopDong.MaHopDong = hopDongMoi.MaHopDong;
                    hopDongBUL.ThemKhachTroHopDong(khachTroHopDong);
                }


                phongBUL.CapNhatTrangThaiPhong(phong.MaPT, "TT01");
                phongBUL.CapNhatTrangThaiPhong(cboMaPT.SelectedValue.ToString(), "TT02");
                kiemTraThanhCong = true;
                this.Close();
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
