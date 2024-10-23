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
        public bool quenMatKhau(string maql)
        {
            var sql = from quanLy in ql.QUANLies
                      where quanLy.MAQL == maql
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
        public string layMatKhau(string maql)
        {
            var sql = from quanLy in ql.QUANLies
                      where quanLy.MAQL == maql
                      select quanLy.MAQL;

            return sql.FirstOrDefault();
        }

        public bool datLaiMatKhau(string maql)
        {
            try
            {
                var quanLy = ql.QUANLies.FirstOrDefault(q => q.MAQL == maql);
                if (quanLy != null)
                {
                    quanLy.MATKHAU = maql; 
                    ql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
