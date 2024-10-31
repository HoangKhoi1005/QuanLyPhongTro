using DAL;
using DTO;
using System;
using System.Collections.Generic;
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

        public object LayDanhSachHoaDonTheoThang(DateTime value)
        {
            return HoaDonDAL.LayDanhSachHoaDonTheoThang(value);
        }

        public object LayDanhSachHoaDonTheoThangVaNT(DateTime value, string v)
        {
            return HoaDonDAL.LayDanhSachHoaDonTheoThangVaNT(value, v);
        }

        public bool KiemTraHoaDonThang(DateTime thangNam, string maPT)
        {
            return HoaDonDAL.KiemTraHoaDonThang(thangNam, maPT);
        }
    }
}
