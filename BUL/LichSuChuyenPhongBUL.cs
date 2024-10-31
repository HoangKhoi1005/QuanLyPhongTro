using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class LichSuChuyenPhongBUL
    {
        LichSuChuyenPhongDAL lichSuChuyenPhongDAL;

        public LichSuChuyenPhongBUL()
        {
            lichSuChuyenPhongDAL = new LichSuChuyenPhongDAL();
        }

        public bool ThemLichSuChuyenPhong(LichSuChuyenPhongDTO lichSuChuyenPhongDTO)
        {
            return lichSuChuyenPhongDAL.ThemLichSuChuyenPhong(lichSuChuyenPhongDTO);
        }
    }
}
