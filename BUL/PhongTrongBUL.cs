using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhongTrongBUL
    {
        private PhongTrongDAL phongTrongDAL;

        public PhongTrongBUL()
        {
            phongTrongDAL = new PhongTrongDAL();
        }

        public List<PhongTrongDTO> LayDanhSachPhongTrong()
        {
            return phongTrongDAL.LayDanhSachPhongTrong();
        }
    }
}
