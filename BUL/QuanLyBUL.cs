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
    }
}
