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
    public class HopDongBUL
    {
        HopDongDAL hopDongDAL;

        public HopDongBUL()
        {
            hopDongDAL = new HopDongDAL();
        }

        public bool ThemHopDong(HopDongDTO hopDong)
        {
            return hopDongDAL.ThemHopDong(hopDong);
        }

        public bool ThemKhachTroHopDong(KhachTroHopDongDTO khachTroHopDong)
        {
            return hopDongDAL.ThemKhachTroHopDong(khachTroHopDong);
        }

        public string PhatSinhMaHopDong()
        {
            return hopDongDAL.PhatSinhMaHopDong();
        }

        public string TimMaHopDongTheoMaPhong(string maPhong)
        {
            return hopDongDAL.TimMaHopDongTheoMaPhong(maPhong);
        }

        public int DemSoLuongKhachTroTrongHopDong(string maHopDong)
        {
            return hopDongDAL.DemSoLuongKhachTroTrongHopDong(maHopDong);
        }

        public DataTable LayDSHopDongDataGirdView()
        {
            return hopDongDAL.LayDSHopDongDataGirdView();
        }

        public HopDongDTO LayHopDongTheoMaPhong(string maPhong)
        {
            return hopDongDAL.LayHopDongTheoMaPhong(maPhong);
        }

        public bool CapNhatHopDong(HopDongDTO hopDong)
        {
            return hopDongDAL.CapNhatHopDong(hopDong);
        }

        public bool KiemTraPhongCoHopDong(string maPT)
        {
            return hopDongDAL.KiemTraPhongCoHopDong(maPT);
        }
    }
}
