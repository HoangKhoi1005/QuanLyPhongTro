using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaoTraPhongDAL
    {
        DBConnect db;

        public BaoTraPhongDAL()
        {
            db = new DBConnect();
        }

        public string PhatSinhMaBaoTraPhong()
        {
            string maBaoTraPhong = "BTP" + DateTime.Now.ToString("yyyyMMdd") + "001";
            string sql = "SELECT TOP 1 MaBaoTra FROM BaoTraPhong ORDER BY MaBaoTra DESC";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    string pdp = reader["MaBaoTra"].ToString();
                    int number = int.Parse(pdp.Substring(pdp.Length - 3)) + 1;
                    maBaoTraPhong = "BTP" + DateTime.Now.ToString("yyyyMMdd") + number.ToString("000");
                }
            }
            return maBaoTraPhong;
        }

        public bool ThemBaoTraPhong(BaoTraPhongDTO baoTraPhongDTO)
        {
            string sql = "INSERT INTO BaoTraPhong (MaBaoTra, MaPT, NgayBao, NgayTraPhongDuKien, MoTa, DaXoa) VALUES ('" + baoTraPhongDTO.MaBaoTra + "', '" + baoTraPhongDTO.MaPT + "', '" + baoTraPhongDTO.NgayBao + "', '" + baoTraPhongDTO.NgayTraPhongDuKien + "', N'" + baoTraPhongDTO.MoTa + "', " + Convert.ToInt32(baoTraPhongDTO.DaXoa) + ")";
            return db.ExecuteNonQuery(sql) > 0;
        }
    }
}
