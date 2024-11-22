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
    public class SuDungDichVuBUL
    {
        SuDungDichVuDAL suDungDichVuDAL;

        public SuDungDichVuBUL()
        {
            suDungDichVuDAL = new SuDungDichVuDAL();
        }

        public bool CapNhatSuDungDichVu(SuDungDichVuDTO suDungDichVu)
        {
            return suDungDichVuDAL.CapNhatSuDungDichVu(suDungDichVu);
        }

        public DataTable LayDSSuDungDVDataGirdView(string maPT)
        {
            return suDungDichVuDAL.LayDSSuDungDVDataGirdView(maPT);
        }

        public bool themSuDungDichVu(SuDungDichVuDTO suDungDichVu)
        {
            return suDungDichVuDAL.themSuDungDichVu(suDungDichVu);
        }

        public bool XoaSuDungDichVu(string maPT, string maDV, DateTime ngayBatDau)
        {
            return suDungDichVuDAL.XoaSuDungDichVu(maPT, maDV, ngayBatDau);
        }

        public bool KiemTraSuDungDichVuTonTai(string maPT, string maDV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return suDungDichVuDAL.KiemTraSuDungDichVuTonTai(maPT, maDV, ngayBatDau, ngayKetThuc);
        }

        public bool XoaSuDungDichVuTheoMaPhong(string maPT)
        {
            return suDungDichVuDAL.XoaSuDungDichVuTheoMaPhong(maPT);
        }

        public bool CapNhatNgayKetThucSuDungDichVuTheoMaPhong(string maPT)
        {
            return suDungDichVuDAL.CapNhatNgayKetThucSuDungDichVuTheoMaPhong(maPT);
        }
    }
}
