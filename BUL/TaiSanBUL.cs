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
    public class TaiSanBUL
    {
        TaiSanDAL taiSanDAL;

        public TaiSanBUL()
        {
            taiSanDAL = new TaiSanDAL();
        }

        public List<TaiSanDTO> LayDSTaiSan()
        {
            return taiSanDAL.LayDSTaiSan();
        }

        public string PhatSinhMaTaiSan()
        {
            return taiSanDAL.PhatSinhMaTaiSan();
        }

        public bool SuaTaiSan(TaiSanDTO taiSan)
        {
            return taiSanDAL.SuaTaiSan(taiSan);
        }

        public bool ThemTaiSan(TaiSanDTO taiSan)
        {
            return taiSanDAL.ThemTaiSan(taiSan);
        }

        public DataTable TraCuuTaiSan(string tenTS, string maPT)
        {
            return taiSanDAL.TraCuuTaiSan(tenTS, maPT);
        }

        public List<string> LayDSTenTaiSan()
        {
            return taiSanDAL.LayDSTenTaiSan();
        }

        public bool XoaTaiSan(string maTS)
        {
            return taiSanDAL.XoaTaiSan(maTS);
        }
    }
}
