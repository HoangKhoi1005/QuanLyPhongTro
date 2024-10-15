using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachTroDAL
    {
        DBConnect db;

        public KhachTroDAL()
        {
            db = new DBConnect();
        }

        //Lấy danh sách khách trọ
        public List<KhachTroDTO> LayDanhSachKhachTro()
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string query = "SELECT * FROM KHACHTRO WHERE DAXOA = 0";
            try
            {
                using (var reader = db.ExecuteQuery(query))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách khách trọ: " + ex.Message);
            }
            return lstKhachTro;
        }

        public List<KhachTroDTO> LayDSKhachTroChuaThuePhong()
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string query = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND MaKT NOT IN (SELECT MaKT FROM KHACHTRO_HOPDONG)";
            try
            {
                using (var reader = db.ExecuteQuery(query))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách khách trọ chưa thuê phòng: " + ex.Message);
            }
            return lstKhachTro;
        }

        public List<KhachTroDTO> TimKiemKhachTro(string ten)
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string query = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND HOTEN LIKE N'%" + ten + "%'";
            try
            {
                using (var reader = db.ExecuteQuery(query))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm khách trọ: " + ex.Message);
            }
            return lstKhachTro;
        }

        public string PhatSinhMaKhachTro()
        {
            string query = "SELECT TOP 1 MaKT FROM KHACHTRO ORDER BY MaKT DESC";
            string maKT = "KT001";
            try
            {
                using (var reader = db.ExecuteQuery(query))
                {
                    if (reader.Read())
                    {
                        string ma = reader["MaKT"].ToString();
                        int thuTu = Convert.ToInt32(ma.Substring(2)) + 1;
                        maKT = "KT" + thuTu.ToString("000");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi phát sinh mã khách trọ: " + ex.Message);
            }
            return maKT;
        }

        //Kiem tra khach tro co ton tai
        public bool KiemTraKhachTroTonTai(string MaKT)
        {
            string query = "SELECT COUNT(*) FROM KHACHTRO WHERE MAKT = '" + MaKT + "'";
            int count = 0;
            try
            {
                using (var reader = db.ExecuteQuery(query))
                {
                    if (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra khách trọ tồn tại: " + ex.Message);
            }
            return count > 0;
        }

        public bool ThemKhachTro(KhachTroDTO khachTro)
        {
            string query = "INSERT INTO KHACHTRO VALUES('" + khachTro.MaKT + "', N'" + khachTro.HoTen + "', '" + khachTro.CCCD + "', '" + khachTro.SoDT + "', N'" + khachTro.DiaChi + "', '" + khachTro.Email + "', '" + khachTro.NgaySinh + "', N'" + khachTro.GioiTinh + "', N'" + khachTro.Anh + "', N'" + khachTro.MoTa + "', 0)";
            return db.ExecuteNonQuery(query) > 0;
        }
    }
}
