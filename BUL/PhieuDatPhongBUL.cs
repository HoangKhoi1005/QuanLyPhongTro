using DAL;
using DTO;
using System;
using System.Collections.Generic;
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
    }
}
