using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class DoanhThuBUL
    {
        private DoanhThuDAL _dal;

        public DoanhThuBUL()
        {
            _dal = new DoanhThuDAL(); 
        }

        public List<DoanhThuDTO> LayDoanhThuTheoThang()
        {
            return _dal.LayDoanhThuTheoThang();
        }
    }
}
