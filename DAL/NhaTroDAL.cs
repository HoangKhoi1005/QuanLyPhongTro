using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaTroDAL
    {
        DBConnect db;

        public NhaTroDAL()
        {
            db = new DBConnect();
        }

        public List<NhaTroDTO> LayDanhSachNhaTro()
        {
            List<NhaTroDTO> lstNhaTro = new List<NhaTroDTO>();
            string query = "SELECT * FROM NhaTro WHERE TRANGTHAI = 1";
            try
            {
                using (SqlDataReader reader = db.ExecuteQuery(query))
                {
                    while (reader.Read())
                    {
                        NhaTroDTO nhaTro = new NhaTroDTO
                        {
                            MaNT = reader["MaNT"].ToString(),
                            TenNT = reader["TenNT"].ToString(),
                            DiaChiNT = reader["DiaChiNT"].ToString(),
                            SoDT = reader["SoDT"].ToString(),
                            ChuNhaTro = reader["TenChu"].ToString()
                        };
                        lstNhaTro.Add(nhaTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách nhà trọ: " + ex.Message);
            }
            return lstNhaTro;
        }


        //Thêm nhà trọ
        public bool ThemNhaTro(NhaTroDTO nhaTro)
        {
            string query = "INSERT INTO NhaTro VALUES('" + nhaTro.MaNT + "', N'" + nhaTro.TenNT + "', N'" + nhaTro.DiaChiNT + "', '" + nhaTro.SoDT + "', N'" + nhaTro.ChuNhaTro + "', 1)";
            int kq = db.ExecuteNonQuery(query);
            return kq > 0;
        }

        //Kiểm tra xem nhà trọ có phòng nào không
        public bool KiemTraPhongTheoNhaTro(string maNT)
        {
            string query = "SELECT COUNT(*) FROM PHONGTRO WHERE MaNT = '" + maNT + "'";
            int count = (int)db.ExecuteScalar(query);
            return count > 0;
            
        }

        //Xóa nhà trọ
        public bool XoaNhaTro(string maNT)
        {
            if (KiemTraPhongTheoNhaTro(maNT))
            {
                return false;
            }

            string query = "UPDATE NHATRO SET TRANGTHAI = 0 WHERE MaNT = '" + maNT + "'";
            int kq = db.ExecuteNonQuery(query);
            return kq > 0;
        }

        //Sửa nhà trọ
        public bool SuaNhaTro(NhaTroDTO nhaTro)
        {
            string query = "UPDATE NhaTro SET TenNT = N'" + nhaTro.TenNT + "', DiaChiNT = N'" + nhaTro.DiaChiNT + "', SoDT = '" + nhaTro.SoDT + "', TenChu = N'" + nhaTro.ChuNhaTro + "' WHERE MaNT = '" + nhaTro.MaNT + "'";
            int kq = db.ExecuteNonQuery(query);
            return kq > 0;
        }

        //Phát sinh mã nhà trọ
        public string PhatSinhMaNT()
        {
            string query = "SELECT TOP 1 MaNT FROM NhaTro WHERE TRANGTHAI = 1 ORDER BY MaNT DESC";
            var reader = db.ExecuteQuery(query);
            string maNT = "";
            if (reader.Read())
            {
                maNT = reader["MaNT"].ToString();
            }
            reader.Close();
            if (maNT == "")
            {
                return "NT001";
            }
            int so = int.Parse(maNT.Substring(2)) + 1;
            if (so < 10)
            {
                return "NT00" + so;
            }
            else if (so < 100)
            {
                return "NT0" + so;
            }
            else
            {
                return "NT" + so;
            }
        }

        //Lấy địa chỉ nhà trọ theo mã nhà trọ
        public string LayDiaChiNTTheoMaNT(string maNT)
        {
            string query = "SELECT DiaChiNT FROM NhaTro WHERE MaNT = '" + maNT + "' AND TRANGTHAI = 1";
            var reader = db.ExecuteQuery(query);
            string diaChi = "";
            if (reader.Read())
            {
                diaChi = reader["DiaChiNT"].ToString();
            }
            reader.Close();
            return diaChi;
        }

    }
}
