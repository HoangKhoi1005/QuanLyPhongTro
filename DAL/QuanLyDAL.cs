using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyDAL
    {
        private QLPTDataContext ql = new QLPTDataContext();

        public bool dangNhap(string maQL, string matKhau)
        {
            var query = from quanLy in ql.QUANLies
                        where quanLy.MAQL == maQL && quanLy.MATKHAU == matKhau
                        select quanLy;

            if (query.Any())
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
        public bool quenMatKhau(string email)
        {
            var sql = from quanLy in ql.QUANLies
                      where quanLy.EMAILNV == email
                      select quanLy;

            if (sql.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string layMatKhau(string email)
        {
            var sql = from quanLy in ql.QUANLies
                      where quanLy.EMAILNV == email
                      select quanLy.MATKHAU;

            return sql.FirstOrDefault();
        }
    }
}
