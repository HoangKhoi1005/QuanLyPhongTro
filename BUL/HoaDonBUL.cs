using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class HoaDonBUL
    {
        HoaDonDAL HoaDonDAL;

        public HoaDonBUL()
        {
            HoaDonDAL = new HoaDonDAL();
        }

        public bool ThemHoaDon(HoaDonDTO hoaDonDTO)
        {
            return HoaDonDAL.ThemHoaDon(hoaDonDTO);
        }

        public string PhatSinhMaHoaDon()
        {
            return HoaDonDAL.PhatSinhMaHoaDon();
        }

        public decimal TinhTienHoaDon(DateTime ngay, string maPT)
        {
            return HoaDonDAL.TinhTienHoaDon(ngay, maPT);
        }

        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            return HoaDonDAL.LayDanhSachHoaDon();
        }

        public object LayDanhSachHoaDonTheoThang(DateTime value, string trangThaiThanhToan)
        {
            return HoaDonDAL.LayDanhSachHoaDonTheoThang(value, trangThaiThanhToan);
        }

        public object LayDanhSachHoaDonTheoThangVaNT(DateTime value, string maNT, string trangThaiThanhToan)
        {
            return HoaDonDAL.LayDanhSachHoaDonTheoThangVaNT(value, maNT, trangThaiThanhToan);
        }

        public bool KiemTraHoaDonThang(DateTime thangNam, string maPT)
        {
            return HoaDonDAL.KiemTraHoaDonThang(thangNam, maPT);
        }

        public bool KiemTraChiSoDienNuoc(DateTime thangNam, string maPT)
        {
            return HoaDonDAL.KiemTraChiSoDienNuoc(thangNam, maPT);
        }

        public object LayDanhSachHoaDonTheoMaPhongVaThang(string maPT, DateTime value, string trangThaiThanhToan)
        {
            return HoaDonDAL.LayDanhSachHoaDonTheoMaPhongVaThang(maPT, value, trangThaiThanhToan);
        }

        public void ThuTien(string maHD, decimal soTienThu)
        {
            HoaDonDAL.ThuTien(maHD, soTienThu);
        }

        public DataTable LayHoaDonTheoMaHD(string maHD)
        {
            return HoaDonDAL.LayHoaDonTheoMaHD(maHD);
        }
    }
}
