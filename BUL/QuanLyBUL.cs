using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class QuanLyBUL
    {
        QuanLyDAL ql = new QuanLyDAL();
        public bool dangNhap(string taiKhoan, string matKhau)
        {
            return ql.dangNhap(taiKhoan, matKhau);
        }

        public bool quenMatKhau(string email)
        {
            return ql.quenMatKhau(email);
        }

        public string layMatKhau(string email)
        {
            return ql.layMatKhau(email);
        }

        public bool datLaiMatKhau(string maql)
        {
            return ql.datLaiMatKhau(maql);
        }
    }
}
