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
    public class TaiSanDAL
    {
        DBConnect db;

        public TaiSanDAL()
        {
            db = new DBConnect();
        }

        //Lấy danh sách tài sản
        /*
         public string MaTS { get; set; }
        public string MaPT { get; set; }
        public string TenTaiSan { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgaySuDung { get; set; }
        public DateTime NgayThanhLy { get; set; }
        public string MoTa { get; set; }
        public bool DaXoa { get; set; }
        public bool DaHu { get; set; }
         */
        public List<TaiSanDTO> LayDSTaiSan()
        {
            List<TaiSanDTO> dsTaiSan = new List<TaiSanDTO>();
            string sql = "SELECT * FROM TaiSan WHERE DAXOA = 0";
            using (var reader = db.ExecuteQuery(sql))
            {
                while (reader.Read())
                {
                    TaiSanDTO taiSan = new TaiSanDTO();
                    taiSan.MaTS = reader["MaTS"].ToString();
                    taiSan.MaPT = reader["MaPT"].ToString();
                    taiSan.TenTaiSan = reader["TenTaiSan"].ToString();
                    taiSan.DonGia = decimal.Parse(reader["DonGia"].ToString());
                    taiSan.NgaySuDung = DateTime.Parse(reader["NgaySuDung"].ToString());
                    var ngayThanhLyValue = reader["NgayThanhLy"];
                    if (ngayThanhLyValue != DBNull.Value)
                    {
                        taiSan.NgayThanhLy = DateTime.Parse(ngayThanhLyValue.ToString());
                    }
                    else
                    {
                        taiSan.NgayThanhLy = null;
                    }

                    taiSan.MoTa = reader["MoTa"].ToString();
                    taiSan.DaXoa = bool.Parse(reader["DaXoa"].ToString());
                    taiSan.DaHu = bool.Parse(reader["DaHu"].ToString());
                    dsTaiSan.Add(taiSan);
                }
            }
            return dsTaiSan;
        }

        public string PhatSinhMaTaiSan()
        {
            string sql = "SELECT TOP 1 MaTS FROM TaiSan ORDER BY MaTS DESC";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    string maTS = reader["MaTS"].ToString();
                    int stt = int.Parse(maTS.Substring(2)) + 1;
                    return "TS" + stt.ToString("000");
                }
            }
            return "TS001";
        }

        public bool SuaTaiSan(TaiSanDTO taiSan)
        {
            string sql = "UPDATE TaiSan SET MaPT = '" + taiSan.MaPT + "', TenTaiSan = N'" + taiSan.TenTaiSan + "', DonGia = " + taiSan.DonGia + ", NgaySuDung = '" + taiSan.NgaySuDung + "', NgayThanhLy = " + (taiSan.NgayThanhLy.HasValue ? "'" + taiSan.NgayThanhLy.Value.ToString("yyyy-MM-dd") + "'" : "NULL") + ", MoTa = N'" + taiSan.MoTa + "' WHERE MaTS = '" + taiSan.MaTS + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool ThemTaiSan(TaiSanDTO taiSan)
        {
            string sql = "INSERT INTO TaiSan(MaTS, MaPT, TenTaiSan, DonGia, NgaySuDung, NgayThanhLy, MoTa, DaXoa, DaHu) " +
                "VALUES('" + taiSan.MaTS + "', '" + taiSan.MaPT + "', N'" + taiSan.TenTaiSan + "', " + taiSan.DonGia + ", '" + taiSan.NgaySuDung + "', NULL, N'" + taiSan.MoTa + "', 0, 0)";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public DataTable TraCuuTaiSan(string tenTS, string maPT)
        {
            string sql = "SELECT * FROM TaiSan WHERE 1=1";

            if (!string.IsNullOrEmpty(tenTS))
            {
                sql += " AND TenTaiSan LIKE N'%" + tenTS + "%'";
            }

            if (!string.IsNullOrEmpty(maPT))
            {
                sql += " AND MaPT LIKE '%" + maPT + "%'";
            }

            return db.GetDataTable(sql);
        }

        //Lấy tên tài sản loại bỏ những tên giống nhau
        public List<string> LayDSTenTaiSan()
        {
            List<string> dsTenTaiSan = new List<string>();
            string sql = "SELECT DISTINCT TenTaiSan FROM TaiSan WHERE DAXOA = 0";
            using (var reader = db.ExecuteQuery(sql))
            {
                while (reader.Read())
                {
                    dsTenTaiSan.Add(reader["TenTaiSan"].ToString());
                }
            }
            return dsTenTaiSan;
        }

        public bool XoaTaiSan(string maTS)
        {
            string sql = "UPDATE TaiSan SET DaXoa = 1 WHERE MaTS = '" + maTS + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }
    }
}
