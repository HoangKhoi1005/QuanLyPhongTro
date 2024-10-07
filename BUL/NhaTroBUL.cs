using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class NhaTroBUL
    {
        NhaTroDAL nhaTroDAL;

        public NhaTroBUL()
        {
            nhaTroDAL = new NhaTroDAL();
        }

        public List<NhaTroDTO> LayDanhSachNhaTro()
        {
            return nhaTroDAL.LayDanhSachNhaTro();
        }

        public bool ThemNhaTro(NhaTroDTO nhaTro)
        {
            return nhaTroDAL.ThemNhaTro(nhaTro);
        }

        public string PhatSinhMaNT()
        {
            return nhaTroDAL.PhatSinhMaNT();
        }

        public string LayDiaChiNTTheoMaNT(string maNT)
        {
            return nhaTroDAL.LayDiaChiNTTheoMaNT(maNT);
        }

        public bool XoaNhaTro(string maNT)
        {
            return nhaTroDAL.XoaNhaTro(maNT);
        }

        public bool SuaNhaTro(NhaTroDTO nhaTro)
        {
            return nhaTroDAL.SuaNhaTro(nhaTro);
        }
    }
}
