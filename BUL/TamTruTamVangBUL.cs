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
    public class TamTruTamVangBUL
    {
        TamTruTamVangDAL tamTruTamVangDAL;

        public TamTruTamVangBUL()
        {
            tamTruTamVangDAL = new TamTruTamVangDAL();
        }

        public bool KiemTraKhachTroDaCoTTTV(string maKT, DateTime ngayBD, DateTime ngayKT)
        {
            return tamTruTamVangDAL.KiemTraKhachTroDaCoTTTV(maKT, ngayBD, ngayKT);
        }

        public DataTable LayDSTamTruTamVang()
        {
            return tamTruTamVangDAL.LayDSTamTruTamVang();
        }

        public bool SuaTamTruTamVang(TamTruTamVangDTO tamTruTamVangDTO)
        {
            return tamTruTamVangDAL.SuaTamTruTamVang(tamTruTamVangDTO);
        }

        public bool ThemTamTruTamVang(TamTruTamVangDTO tamTruTamVangDTO)
        {
            return tamTruTamVangDAL.ThemTamTruTamVang(tamTruTamVangDTO);
        }

        public DataTable TraCuuTamTruTamVang(string hoTen, string cccd, string maPT, string loaiTTTV)
        {
            return tamTruTamVangDAL.TraCuuTamTruTamVang(hoTen, cccd, maPT, loaiTTTV);
        }
    }
}
