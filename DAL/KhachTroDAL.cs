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
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
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
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND MaKT NOT IN (SELECT MaKT FROM KHACHTRO_HOPDONG)";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
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
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND HOTEN LIKE N'%" + ten + "%'";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
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
            string sql = "SELECT TOP 1 MaKT FROM KHACHTRO ORDER BY MaKT DESC";
            string maKT = "KT001";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
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
            string sql = "SELECT COUNT(*) FROM KHACHTRO WHERE MAKT = '" + MaKT + "'";
            int count = 0;
            try
            {
                using (var reader = db.ExecuteQuery(sql))
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
            string sql = "INSERT INTO KHACHTRO VALUES('" + khachTro.MaKT + "', N'" + khachTro.HoTen + "', '" + khachTro.CCCD + "', '" + khachTro.SoDT + "', N'" + khachTro.DiaChi + "', '" + khachTro.Email + "', '" + khachTro.NgaySinh + "', N'" + khachTro.GioiTinh + "', N'" + khachTro.Anh + "', N'" + khachTro.MoTa + "', 0)";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public string LayTenNguoiDaiDienTheoPhong(string maPT)
        {
            string sql = "SELECT HOTEN FROM KHACHTRO, HOPDONG WHERE KHACHTRO.MAKT = HOPDONG.MAKTDAIDIEN AND HOPDONG.MAPT = '" + maPT + "'";
            object ten = db.ExecuteScalar(sql);
            return (string)ten;
        }

        public DataTable LayThanhVienTheoPhong(string maPT)
        {
            string sql = "SELECT KHACHTRO.MAKT, KHACHTRO.HOTEN, KHACHTRO.CCCD, KHACHTRO.NGAYSINH, KHACHTRO.GIOITINH, KHACHTRO.SODT, KHACHTRO.EMAIL, KHACHTRO.DIACHI, KHACHTRO.ANH, KHACHTRO.MOTA FROM KHACHTRO, HOPDONG, KHACHTRO_HOPDONG WHERE KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT AND HOPDONG.MAHOPDONG = KHACHTRO_HOPDONG.MAHOPDONG AND HOPDONG.MAPT = '" + maPT + "' AND KHACHTRO.MAKT != HOPDONG.MAKTDAIDIEN";
            return db.GetDataTable(sql);
        }

        public bool SuaKhachTro(KhachTroDTO khachTroDTO)
        {
            string sql = "UPDATE KHACHTRO SET HOTEN = N'" + khachTroDTO.HoTen + "', CCCD = '" + khachTroDTO.CCCD + "', SODT = '" + khachTroDTO.SoDT + "', DIACHI = N'" + khachTroDTO.DiaChi + "', EMAIL = '" + khachTroDTO.Email + "', NGAYSINH = '" + khachTroDTO.NgaySinh + "', GIOITINH = N'" + khachTroDTO.GioiTinh + "', ANH = N'" + khachTroDTO.Anh + "', MOTA = N'" + khachTroDTO.MoTa + "' WHERE MAKT = '" + khachTroDTO.MaKT + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool XoaKhachTroHopDong(string maKT)
        {
            string sql = "DELETE FROM KHACHTRO_HOPDONG WHERE MAKT = '" + maKT + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public KhachTroDTO LayNguoiDaiDienTheoPhong(string maPT)
        {
            string sql = "SELECT KHACHTRO.MAKT, KHACHTRO.HOTEN, KHACHTRO.CCCD, KHACHTRO.NGAYSINH, KHACHTRO.GIOITINH, KHACHTRO.SODT, KHACHTRO.EMAIL, KHACHTRO.DIACHI, KHACHTRO.ANH, KHACHTRO.MOTA FROM KHACHTRO, HOPDONG WHERE KHACHTRO.MAKT = HOPDONG.MAKTDAIDIEN AND HOPDONG.MAPT = '" + maPT + "' AND TRANGTHAIHOPDONG = 1" +
                " UNION " +
                "SELECT TOP 1 KHACHTRO.MAKT, KHACHTRO.HOTEN, KHACHTRO.CCCD, KHACHTRO.NGAYSINH, KHACHTRO.GIOITINH, KHACHTRO.SODT, KHACHTRO.EMAIL, KHACHTRO.DIACHI, KHACHTRO.ANH, KHACHTRO.MOTA FROM KHACHTRO, PHIEUDATPHONG WHERE KHACHTRO.MAKT = PHIEUDATPHONG.MAKT AND PHIEUDATPHONG.MAPT = '" + maPT + "' AND PHIEUDATPHONG.DAXOA = 0";

            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    KhachTroDTO khachTro = new KhachTroDTO
                    {
                        MaKT = reader["MaKT"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        CCCD = reader["CCCD"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SoDT = reader["SoDT"].ToString(),
                        Email = reader["Email"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Anh = reader["Anh"].ToString(),
                        MoTa = reader["MoTa"].ToString()
                    };
                    return khachTro;
                }
            }
            return null;
        }
    }
}
