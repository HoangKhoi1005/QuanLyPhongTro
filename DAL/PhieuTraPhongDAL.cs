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

        public string PhatSinhMaPhieuTraPhong()
        {
            string maPhieuTraPhong = "PTP" + DateTime.Now.ToString("yyyyMMdd") + "001";
            string sql = "SELECT TOP 1 MaPhieuTra FROM PhieuTraPhong ORDER BY MaPhieuTra DESC";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    string pdp = reader["MaPhieuTra"].ToString();
                    int number = int.Parse(pdp.Substring(pdp.Length - 3)) + 1;
                    maPhieuTraPhong = "PTP" + DateTime.Now.ToString("yyyyMMdd") + number.ToString("000");
                }
            }
            return maPhieuTraPhong;
        }

        public bool ThemPhieuTraPhong(PhieuTraPhongDTO phieuTraPhongDTO)
        {
            string sql = "INSERT INTO PhieuTraPhong (MaPhieuTra, MaPT, NgayBao, NgayTra, TienHoanTra, MoTa, DaXoa) VALUES ('" + phieuTraPhongDTO.MaPhieuTra + "', '" + phieuTraPhongDTO.MaPT + "', '" + phieuTraPhongDTO.NgayBao + "', '" + phieuTraPhongDTO.NgayTra + "', " + phieuTraPhongDTO.TienHoanTra + ", N'" + phieuTraPhongDTO.MoTa + "', " + Convert.ToInt32(phieuTraPhongDTO.DaXoa) + ")";
            return db.ExecuteNonQuery(sql) > 0;
        }
    }
}
