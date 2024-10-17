using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class DichVuBUL
    {
        DichVuDAL DichVuDAL;
        public DichVuBUL()
        {
            DichVuDAL = new DichVuDAL();
        }
        public List<DichVuDTO> loadDichVu()
        {
            return DichVuDAL.loadDichVu();
        }
    }
}
