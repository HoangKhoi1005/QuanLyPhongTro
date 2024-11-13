using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class KhachTroSapHetHanHopDongBUL
    {
        private KhachTroSapHetHanHopDongDAL _dal;

        public KhachTroSapHetHanHopDongBUL()
        {
            _dal = new KhachTroSapHetHanHopDongDAL();
        }

        // Phương thức lấy danh sách khách trọ sắp hết hợp đồng
        public List<KhachTroSapHetHanHopDongDTO> LayKhachTroSapHetHopDong()
        {
            return _dal.LayKhachTroSapHetHopDong();  // Gọi phương thức DAL để lấy dữ liệu
        }
    }
}
