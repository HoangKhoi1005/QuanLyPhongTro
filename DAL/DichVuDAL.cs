using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class DichVuDAL
    {
        private QLPTDataContext ql = new QLPTDataContext();
        public List<DichVuDTO> loadDichVu()
        {
            var sql = from dv in ql.DICHVUs
                      select new DichVuDTO
                      {
                          MaDV = dv.MADV,
                          TenDV = dv.TENDV,
                          DonGia = decimal.Parse(dv.DONGIA.ToString()),
                          MoTa = dv.MOTA
                      };
           return sql.ToList();
        }
    }
}
