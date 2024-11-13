using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TrangThaiPhong1BUL
    {
        private TrangThaiPhong1DAL _dal;

        public TrangThaiPhong1BUL()
        {
            _dal = new TrangThaiPhong1DAL(); // Khởi tạo đối tượng DAL
        }

        // Lấy danh sách trạng thái phòng từ DAL
        public List<TrangThaiPhong1DTO> LayTrangThaiPhong()
        {
            return _dal.LayTrangThaiPhong(); // Gọi phương thức DAL để lấy dữ liệu
        }
    }
}
