using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUL
{
    public class DoanhThuBUL
    {
        private DoanhThuDAL doanhThuDAL;

        public DoanhThuBUL()
        {
            doanhThuDAL = new DoanhThuDAL();
        }

        public DataTable LoadDoanhThu(DateTime ngay)
        {
            return doanhThuDAL.LoadDoanhThu(ngay);
        }
    }
}
