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
    public class BaoTraPhongBUL
    {
        BaoTraPhongDAL baoTraPhongDAL;

        public BaoTraPhongBUL()
        {
            baoTraPhongDAL = new BaoTraPhongDAL();
        }

        public bool HuyBaoTraPhong(string maPT)
        {
            return baoTraPhongDAL.HuyBaoTraPhong(maPT);
        }

        public DataTable LayBaoTraPhongTheoMaPhong(string maPT)
        {
            return baoTraPhongDAL.LayBaoTraPhongTheoMaPhong(maPT);
        }

        public string PhatSinhMaBaoTraPhong()
        {
            return baoTraPhongDAL.PhatSinhMaBaoTraPhong();
        }

        public bool ThemBaoTraPhong(BaoTraPhongDTO baoTraPhongDTO)
        {
            return baoTraPhongDAL.ThemBaoTraPhong(baoTraPhongDTO);
        }
    }
}
