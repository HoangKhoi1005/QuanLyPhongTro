using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public string TimMaHopDongTheoMaPhong(string maPhong)
        {
            string maHopDong = "";
            string sql = "SELECT MaHopDong FROM HopDong WHERE MaPT = '" + maPhong + "' AND HOPDONG.TRANGTHAIHOPDONG = 1";
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
            string sql = "SELECT COUNT(*) FROM KhachTro_HopDong, HOPDONG WHERE KhachTro_HopDong.MaHopDong = HOPDONG.MaHopDong AND KhachTro_HopDong.MaHopDong = '" + maHopDong + "' AND HOPDONG.TRANGTHAIHOPDONG = 1";
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
            string sql = "SELECT * FROM HopDong WHERE MaPT = '" + maPhong + "' AND TRANGTHAIHOPDONG = 1";
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
            string sql = "UPDATE HopDong SET NgayLap = '" + hopDong.NgayLap + "', NgayHetHan = '" + hopDong.NgayHetHan + "', TienCoc = " + hopDong.TienCoc + ", MoTa = N'" + hopDong.MoTa + "',TRANGTHAIHOPDONG = '" + hopDong.TrangThaiHopDong + "' WHERE MaHopDong = '" + hopDong.MaHopDong + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool KiemTraPhongCoHopDong(string maPT)
        {
            string sql = "SELECT COUNT(*) FROM HopDong WHERE MaPT = '" + maPT + "' AND TRANGTHAIHOPDONG = 1";
            return (int)(db.ExecuteScalar(sql)) > 0;
        }

        public void CapNhatTrangThaiHopDong(object maHD, int v)
        {
            string sql = "UPDATE HopDong SET TRANGTHAIHOPDONG = " + v + " WHERE MAHOPDONG = '" + maHD + "'";
            db.ExecuteNonQuery(sql);
        }

        public List<KhachTroHopDongDTO> LayDanhSachKhachTroHopDong(string maHopDong)
        {
            List<KhachTroHopDongDTO> khachTroHopDongs = new List<KhachTroHopDongDTO>();
            string sql = "SELECT * FROM KhachTro_HopDong WHERE MaHopDong = '" + maHopDong + "'";
            using (var reader = db.ExecuteQuery(sql))
            {
                while (reader.Read())
                {
                    KhachTroHopDongDTO khachTroHopDong = new KhachTroHopDongDTO
                    {
                        MaHopDong = reader["MaHopDong"].ToString(),
                        MaKT = reader["MaKT"].ToString()
                    };
                    khachTroHopDongs.Add(khachTroHopDong);
                }
            }
            return khachTroHopDongs;
        }

        public DataTable layThongTinHopDong(string maHopDong)
        {
            string query = @"
            SELECT HD.NGAYLAP, HD.TIENCOC, KT.HOTEN AS TENKHACHTRO, KT.CCCD AS CCCDKHACHTRO, KT.DIACHI AS DIACHIKHACHTRO, KT.SODT AS SODIENTHOAIKT,
               QL.HOTENNV AS TENQUANLY, QL.DIACHINV AS DIACHIQUANLY, QL.SODT AS SODIENTHOAIQL,
               PT.MAPT AS MAPHONGTRO, PT.DONGIA AS GIATHUE, NT.DIACHINT AS DIACHINHATRO,
               HD.NGAYLAP AS NGAYBATDAU, HD.NGAYHETHAN AS NGAYKETTHUC
            FROM HOPDONG HD
            JOIN KHACHTRO KT ON HD.MAKTDAIDIEN = KT.MAKT
            JOIN PHONGTRO PT ON HD.MAPT = PT.MAPT
            JOIN QUANLY QL ON HD.MAQL = QL.MAQL
            JOIN NHATRO NT ON PT.MANT = NT.MANT
            WHERE HD.MAHOPDONG = @maHopDong;";

            using (SqlConnection conn = db.Conn)
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@maHopDong", maHopDong);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
