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
    public class PhieuDatPhongBUL
    {
        PhieuDatPhongDAL PhieuDatPhongDAL;

        public PhieuDatPhongBUL()
        {
            PhieuDatPhongDAL = new PhieuDatPhongDAL();
        }

        public bool ThemPhieuDatPhong(PhieuDatPhongDTO phieuDatPhong)
        {
            return PhieuDatPhongDAL.ThemPhieuDatPhong(phieuDatPhong);
        }

        public string PhatSinhMaPhieuDatPhong()
        {
            return PhieuDatPhongDAL.PhatSinhMaPhieuDatPhong();
        }

        public DataTable LayDSPhieuDatDataGirdView()
        {
            return PhieuDatPhongDAL.LayDSPhieuDatDataGirdView();
        }

        public bool KiemTraPhongDaDatCoc(string maPT)
        {
            return PhieuDatPhongDAL.KiemTraPhongDaDatCoc(maPT);
        }

        public bool XoaPhieuDatPhong(string maPhieuDatPhong)
        {
            return PhieuDatPhongDAL.XoaPhieuDatPhong(maPhieuDatPhong);
        }

        public PhieuDatPhongDTO LayPhieuDatPhongTheoMaPhong(string maPhong)
        {
            return PhieuDatPhongDAL.LayPhieuDatPhongTheoMaPhong(maPhong);
        }
    }
}
