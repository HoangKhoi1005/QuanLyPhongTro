using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HopDongDAL
    {
        DBConnect db;

        public HopDongDAL()
        {
            db = new DBConnect();
        }

        public bool ThemHopDong(HopDongDTO hopDong)
        {
            string sql = "INSERT INTO HopDong VALUES('" + hopDong.MaHopDong + "', '" + hopDong.MaPT + "', '" + hopDong.MaQL + "', '" + hopDong.MaKT + "', '" + hopDong.NgayLap + "', '" + hopDong.NgayHetHan + "', " + hopDong.TienCoc + ", 1, N'" + hopDong.MoTa + "')";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool ThemKhachTroHopDong(KhachTroHopDongDTO khachTroHopDong)
        {
            string sql = "INSERT INTO KhachTro_HopDong VALUES('" + khachTroHopDong.MaHopDong + "', '" + khachTroHopDong.MaKT + "')";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public string PhatSinhMaHopDong()
        {
            string maHopDong = "HDONG" + DateTime.Now.ToString("yyyyMMdd") + "001";
            string sql = "SELECT TOP 1 MaHopDong FROM HopDong ORDER BY MaHopDong DESC";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    string hd = reader["MaHopDong"].ToString();
                    int number = int.Parse(hd.Substring(hd.Length - 3)) + 1;
                    maHopDong = "HDONG" + DateTime.Now.ToString("yyyyMMdd") + number.ToString("000");
                }
            }
            return maHopDong;
        }

        //Tìm mã hợp đồng theo mã phòng
        public string TimMaHopDongTheoMaPhong(string maPhong)
        {
            string maHopDong = "";
            string sql = "SELECT MaHopDong FROM HopDong WHERE MaPT = '" + maPhong + "'";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    maHopDong = reader["MaHopDong"].ToString();
                }
            }
            return maHopDong;
        }

        public int DemSoLuongKhachTroTrongHopDong(string maHopDong)
        {
            string sql = "SELECT COUNT(*) FROM KhachTro_HopDong WHERE MaHopDong = '" + maHopDong + "'";
            int count = 0;
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }
            }
            return count;
        }

        public DataTable LayDSHopDongDataGirdView()
        {
            string sql = "SELECT HD.MaHopDong, HD.MaPT, QL.HOTENNV, KT.HoTen, HD.NgayLap, HD.NgayHetHan, HD.TienCoc, HD.MoTa FROM HopDong HD, PhongTro PT, QuanLy QL , KhachTro KT WHERE HD.MaPT = PT.MaPT AND HD.MAKTDAIDIEN = KT.MaKT AND QL.MaQL = HD.MaQL";
            return db.GetDataTable(sql);
        }

        //Lấy hợp đồng theo mã phòng
        public HopDongDTO LayHopDongTheoMaPhong(string maPhong)
        {
            string sql = "SELECT * FROM HopDong WHERE MaPT = '" + maPhong + "'";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    HopDongDTO hopDong = new HopDongDTO
                    {
                        MaHopDong = reader["MaHopDong"].ToString(),
                        MaPT = reader["MaPT"].ToString(),
                        MaQL = reader["MaQL"].ToString(),
                        MaKT = reader["MAKTDAIDIEN"].ToString(),
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        NgayHetHan = Convert.ToDateTime(reader["NgayHetHan"]),
                        TienCoc = Convert.ToDecimal(reader["TienCoc"]),
                        MoTa = reader["MoTa"].ToString()
                    };
                    return hopDong;
                }
            }
            return null;
        }

        public bool CapNhatHopDong(HopDongDTO hopDong)
        {
            string sql = "UPDATE HopDong SET NgayLap = '" + hopDong.NgayLap + "', NgayHetHan = '" + hopDong.NgayHetHan + "', TienCoc = " + hopDong.TienCoc + ", MoTa = N'" + hopDong.MoTa + "' WHERE MaHopDong = '" + hopDong.MaHopDong + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool KiemTraPhongCoHopDong(string maPT)
        {
            string sql = "SELECT COUNT(*) FROM HopDong WHERE MaPT = '" + maPT + "' AND TRANGTHAIHOPDONG = 1";
            return (int)(db.ExecuteScalar(sql)) > 0;
        }
    }
}
