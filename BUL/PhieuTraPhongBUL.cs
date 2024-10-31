using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhieuTraPhongBUL
    {
        PhieuTraPhongDAL phieuTraPhongDAL;

        public PhieuTraPhongBUL()
        {
            phieuTraPhongDAL = new PhieuTraPhongDAL();
        }

        public string PhatSinhMaPhieuTraPhong()
        {
            return phieuTraPhongDAL.PhatSinhMaPhieuTraPhong();
        }

        public bool ThemPhieuTraPhong(PhieuTraPhongDTO phieuTraPhongDTO)
        {
            return phieuTraPhongDAL.ThemPhieuTraPhong(phieuTraPhongDTO);
        }
    }
}
