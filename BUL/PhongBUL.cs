using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhongBUL
    {
        PhongDAL phongDAL;

        public PhongBUL()
        {
            phongDAL = new PhongDAL();
        }

        public List<PhongDTO> LayPhongTheoNhaTro(string maNT)
        {
            return phongDAL.LayPhongTheoNhaTro(maNT);
        }

        public bool KiemTraPhongDaCoHopDong(string maPT)
        {
            return phongDAL.KiemTraPhongDaCoHopDong(maPT);
        }
    }
}
