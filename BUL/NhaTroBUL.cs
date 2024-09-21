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
    }
}
