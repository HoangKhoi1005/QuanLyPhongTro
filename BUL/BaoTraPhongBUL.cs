using DAL;
using DTO;
using System;
using System.Collections.Generic;
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
