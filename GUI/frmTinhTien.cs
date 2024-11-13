using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTinhTien : MetroFramework.Forms.MetroForm
    {
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        HoaDonBUL hoaDonBUL = new HoaDonBUL();
        PhongBUL phongBUL = new PhongBUL();
        private frmTinhTienPhong frmTinhTienPhong;

        public frmTinhTien(frmTinhTienPhong frmTinhTienPhong)
        {
            InitializeComponent();
            this.frmTinhTienPhong = frmTinhTienPhong;

            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.Value = DateTime.Now;
            LoadCboNhaTro();
        }

        private void LoadCboNhaTro()
        {
            var danhSachNhaTro = nhaTroBUL.LayDanhSachNhaTro();

            var tatCaNhaTro = new NhaTroDTO
            {
                MaNT = "All",
                TenNT = "Tất cả các nhà"
            };

            danhSachNhaTro.Insert(0, tatCaNhaTro);

            cboNT.DataSource = danhSachNhaTro;
            cboNT.DisplayMember = "TenNT";
            cboNT.ValueMember = "MaNT";
        }

        public void LoadCboPhong()
        {
            PhongBUL phongBUL = new PhongBUL();
            cboMaPT.DataSource = phongBUL.LayPhongCoHopDongTheoNhaTro(cboNT.SelectedValue.ToString());
            cboMaPT.DisplayMember = "MaPT";
            cboMaPT.ValueMember = "MaPT";
        }

        private void cboNT_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNT.SelectedValue.ToString() == "All")
            {
                cboMaPT.DataSource = null;
                return;
            }
            LoadCboPhong();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            
            hoaDonDTO.NgayLap = DateTime.Now;
            hoaDonDTO.NgayThanhToan = dtpThangNam.Value;
            hoaDonDTO.MoTa = "Hóa đơn tháng " + dtpThangNam.Value.ToString("MM/yyyy");
            hoaDonDTO.DaXoa = false;
            hoaDonDTO.MaQL = "QL001";

            DateTime thangNam = dtpThangNam.Value;

            if (cboNT.SelectedValue.ToString() == "All")
            {
                
                var danhSachPhongThieuChiSo = KiemTraThieuChiSoDienNuoc(thangNam);

                if (danhSachPhongThieuChiSo.Count > 0)
                {
                    string phongThieuChiSo = string.Join(", ", danhSachPhongThieuChiSo);
                    MessageBox.Show($"Các phòng sau chưa nhập chỉ số điện nước cho tháng {thangNam:MM/yyyy}: {phongThieuChiSo}",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var danhSachPhong = phongBUL.LayPhongDaCoHopDong();

                foreach (var phong in danhSachPhong)
                {
                    if (!hoaDonBUL.KiemTraHoaDonThang(dtpThangNam.Value, phong.MaPT))
                    {
                        decimal tongTien = hoaDonBUL.TinhTienHoaDon(dtpThangNam.Value, phong.MaPT);
                        hoaDonDTO.MaHD = hoaDonBUL.PhatSinhMaHoaDon();
                        hoaDonDTO.TongTien += tongTien;
                        hoaDonDTO.MaPT = phong.MaPT;
                        hoaDonBUL.ThemHoaDon(hoaDonDTO);
                        hoaDonDTO.TongTien = 0;
                    }
                }
            }
            else
            {
                if (!hoaDonBUL.KiemTraChiSoDienNuoc(dtpThangNam.Value, cboMaPT.SelectedValue.ToString()))
                {
                    MessageBox.Show($"Phòng chưa nhập chỉ số điện nước cho tháng {thangNam:MM/yyyy}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!hoaDonBUL.KiemTraHoaDonThang(dtpThangNam.Value, cboMaPT.SelectedValue.ToString()))
                {
                    hoaDonDTO.MaHD = hoaDonBUL.PhatSinhMaHoaDon();
                    hoaDonDTO.MaPT = cboMaPT.SelectedValue.ToString();
                    hoaDonDTO.TongTien = hoaDonBUL.TinhTienHoaDon(dtpThangNam.Value, hoaDonDTO.MaPT);
                    hoaDonBUL.ThemHoaDon(hoaDonDTO);
                }
            }

            hoaDonDTO.TienDaThanhToan = 0;

            MessageBox.Show("Tính tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmTinhTienPhong.LoadDataGirdViewHoaDon();
        }

        private List<string> KiemTraThieuChiSoDienNuoc(DateTime thangNam)
        {
            var danhSachPhongThieuChiSo = new List<string>();
            var danhSachPhong = phongBUL.LayPhongDaCoHopDong();

            foreach (var phong in danhSachPhong)
            {
                if (!hoaDonBUL.KiemTraChiSoDienNuoc(thangNam, phong.MaPT))
                {
                    danhSachPhongThieuChiSo.Add(phong.MaPT);
                }
            }
            return danhSachPhongThieuChiSo;
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
