using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuTraPhongDAL
    {
        DBConnect db;

        public PhieuTraPhongDAL()
        {
            db = new DBConnect();
        }
    }
}
