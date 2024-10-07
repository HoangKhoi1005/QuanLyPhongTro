using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TrangThaiPhongBUL
    {
        private TrangThaiPhongDAL dal = new TrangThaiPhongDAL();

        // Lấy tất cả trạng thái phòng
        public List<TrangThaiPhongDTO> LayTatCaTrangThaiPhong()
        {
            return dal.LayTatCaTrangThaiPhong();
        }

        public string LayTenTrangThaiTheoMa(string maTT)
        {
            return dal.LayTenTrangThaiTheoMa(maTT);
        }
    }
}
