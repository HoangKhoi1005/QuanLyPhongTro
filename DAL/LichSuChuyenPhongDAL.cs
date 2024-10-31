using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichSuChuyenPhongDAL
    {
        DBConnect db;

        public LichSuChuyenPhongDAL()
        {
            db = new DBConnect();
        }

        public bool ThemLichSuChuyenPhong(LichSuChuyenPhongDTO lichSuChuyenPhongDTO)
        {
            string sql = "INSERT INTO LichSuChuyenPhong VALUES('" + lichSuChuyenPhongDTO.MaKT + "', '" + lichSuChuyenPhongDTO.MaPTCu + "', '" + lichSuChuyenPhongDTO.MaPTMoi + "', '" + lichSuChuyenPhongDTO.NgayChuyen + "', '" + lichSuChuyenPhongDTO.MaHDCu + "')";
            return db.ExecuteNonQuery(sql) > 0;
        }
    }
}
