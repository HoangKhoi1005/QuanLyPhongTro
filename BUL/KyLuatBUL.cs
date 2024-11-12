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
    public class KyLuatBUL
    {
        KyLuatDAL kyLuatDAL;

        public KyLuatBUL()
        {
            kyLuatDAL = new KyLuatDAL();
        }

        public DataTable LayDSKyLuatDataGirdView()
        {
            return kyLuatDAL.LayDSKyLuatDataGirdView();
        }

        public bool SuaKyLuat(KyLuatDTO kyLuatDTO)
        {
            return kyLuatDAL.SuaKyLuat(kyLuatDTO);
        }

        public bool ThemKyLuat(KyLuatDTO kyLuatDTO)
        {
            return kyLuatDAL.ThemKyLuat(kyLuatDTO);
        }

        public DataTable TraCuuKyLuat(string hoTen, string cccd, string maPT)
        {
            return kyLuatDAL.TraCuuKyLuat(hoTen, cccd, maPT);
        }
    }
}
