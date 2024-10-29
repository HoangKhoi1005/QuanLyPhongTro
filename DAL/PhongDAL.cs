using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using SQLServerProvider;

namespace DAL
{
    public class PhongDAL
    {
        DBConnect conn;

        public PhongDAL()
        {
            conn = new DBConnect();
        }

        //Danh sách phòng theo nhà trọ
        public List<PhongDTO> LayPhongTheoNhaTro(string maNT)
        {
            List<PhongDTO> danhSachPhong = new List<PhongDTO>();

            try
            {
                string sql = "SELECT * FROM PHONGTRO WHERE MANT = '" + maNT + "' AND DAXOA = 0";

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    PhongDTO phong = new PhongDTO();

                    phong.MaPT = reader["MAPT"].ToString();
                    phong.MaNT = reader["MANT"].ToString();
                    phong.MaTT = reader["MATT"].ToString();
                    phong.TenPhong = reader["TENPHONG"].ToString();
                    phong.DonGia = Convert.ToDecimal(reader["DONGIA"]);
                    phong.ChieuDai = Convert.ToDouble(reader["CHIEUDAI"]);
                    phong.ChieuRong = Convert.ToDouble(reader["CHIEURONG"]);
                    phong.SoLuongNguoiTD = Convert.ToInt32(reader["SOLUONGNGUOITD"]);
                    phong.MoTa = reader["MOTA"].ToString();
                    phong.Anh = reader["ANH"].ToString();

                    danhSachPhong.Add(phong);
                }

                reader.Close();
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách phòng: " + ex.Message);
            }

            return danhSachPhong;
        }


        // Kiểm tra phòng trọ đã có hợp đồng nào chưa
        public bool KiemTraPhongDaCoHopDong(string maPT)
        {
            int kq;
            try
            {
                string sql = "SELECT count(*) FROM HOPDONG WHERE MAPT = '" + maPT + "'";

                kq  = (int)conn.ExecuteScalar(sql);

                if (kq == 0)
                    return false;
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra phòng đã có hợp đồng: " + ex.Message);
            }

            return true;
        }

        //Danh sách phòng theo trạng thái
        public List<PhongDTO> LayPhongTheoTrangThai(string maTT, string maNT)
        {
            List<PhongDTO> danhSachPhong = new List<PhongDTO>();

            try
            {
                string sql = "SELECT * FROM PHONGTRO WHERE MATT = '" + maTT + "' AND MANT = '" + maNT + "' AND DAXOA = 0";

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    PhongDTO phong = new PhongDTO();

                    phong.MaPT = reader["MAPT"].ToString();
                    phong.MaNT = reader["MANT"].ToString();
                    phong.MaTT = reader["MATT"].ToString();
                    phong.TenPhong = reader["TENPHONG"].ToString();
                    phong.DonGia = Convert.ToDecimal(reader["DONGIA"]);
                    phong.ChieuDai = Convert.ToDouble(reader["CHIEUDAI"]);
                    phong.ChieuRong = Convert.ToDouble(reader["CHIEURONG"]);
                    phong.SoLuongNguoiTD = Convert.ToInt32(reader["SOLUONGNGUOITD"]);
                    phong.MoTa = reader["MOTA"].ToString();
                    phong.Anh = reader["ANH"].ToString();

                    danhSachPhong.Add(phong);
                }

                reader.Close();
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách phòng theo trạng thái: " + ex.Message);
            }

            return danhSachPhong;
        }

        //Thêm phòng theo nhà trọ
        public bool ThemPhong(PhongDTO phong)
        {
            string sql = "INSERT INTO PHONGTRO VALUES('" + phong.MaPT + "', '" + phong.MaNT + "', '" + phong.MaTT + "', N'" + phong.TenPhong + "', " + phong.DonGia + ", " + phong.ChieuDai + ", " + phong.ChieuRong + ", " + phong.SoLuongNguoiTD + ", N'" + phong.MoTa + "', '" + phong.Anh + "', 0)";

            int kq = conn.ExecuteNonQuery(sql);

            return kq > 0;
        }

        //Phát sinh mã phòng NT001-P01 tăng dần
        public string PhatSinhMaPhong(string maNT)
        {
            string sql = "SELECT TOP 1 MAPT FROM PHONGTRO WHERE MANT = '" + maNT + "' ORDER BY MAPT DESC";

            SqlDataReader reader = conn.ExecuteQuery(sql);

            string maPhong = "";

            if (reader.Read())
            {
                maPhong = reader["MAPT"].ToString();
            }

            reader.Close();
            conn.close();

            if (maPhong == "")
            {
                return maNT + "-P01";
            }

            string soPhong = maPhong.Substring(maPhong.Length - 2);
            int so = Convert.ToInt32(soPhong) + 1;

            if (so < 10)
            {
                return maNT + "-P0" + so;
            }

            return maNT + "-P" + so;
        }

        public List<PhongDTO> TimKiemPhongTheoMaPhong(string maPhong, string maNT)
        {
            List<PhongDTO> danhSachPhong = new List<PhongDTO>();

            try
            {
                string sql = "SELECT * FROM PHONGTRO WHERE MAPT LIKE '%" + maPhong + "%' AND MANT = '" + maNT + "' AND DAXOA = 0";

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    PhongDTO phong = new PhongDTO();

                    phong.MaPT = reader["MAPT"].ToString();
                    phong.MaNT = reader["MANT"].ToString();
                    phong.MaTT = reader["MATT"].ToString();
                    phong.TenPhong = reader["TENPHONG"].ToString();
                    phong.DonGia = Convert.ToDecimal(reader["DONGIA"]);
                    phong.ChieuDai = Convert.ToDouble(reader["CHIEUDAI"]);
                    phong.ChieuRong = Convert.ToDouble(reader["CHIEURONG"]);
                    phong.SoLuongNguoiTD = Convert.ToInt32(reader["SOLUONGNGUOITD"]);
                    phong.MoTa = reader["MOTA"].ToString();
                    phong.Anh = reader["ANH"].ToString();

                    danhSachPhong.Add(phong);
                }

                reader.Close();
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm phòng theo mã phòng: " + ex.Message);
            }

            return danhSachPhong;
        }

        public bool CapNhatTrangThaiPhong(string maPT, string maTT)
        {
            string sql = "UPDATE PHONGTRO SET MATT = '" + maTT + "' WHERE MAPT = '" + maPT + "'";
            return conn.ExecuteNonQuery(sql) > 0;
        }

        //Lấy tất cả mã phòng
        public List<string> LayTatCaMaPhong()
        {
            List<string> danhSachMaPhong = new List<string>();

            try
            {
                string sql = "SELECT MAPT FROM PHONGTRO WHERE DAXOA = 0";

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    danhSachMaPhong.Add(reader["MAPT"].ToString());
                }

                reader.Close();
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách mã phòng: " + ex.Message);
            }

            return danhSachMaPhong;
        }

        public List<PhongDTO> LocPhongTheoTaiSan(List<string> dsTenTaiSan, string maNT)
        {
            List<PhongDTO> danhSachPhong = new List<PhongDTO>();

            if (dsTenTaiSan == null || dsTenTaiSan.Count == 0)
            {
                return LayPhongTheoNhaTro(maNT);
            }

            try
            {
                string sql = "SELECT PT.* FROM PHONGTRO PT JOIN TAISAN TS ON PT.MAPT = TS.MAPT WHERE MANT = '" + maNT + "' AND PT.DAXOA = 0 AND TS.TENTAISAN IN (";

                for (int i = 0; i < dsTenTaiSan.Count; i++)
                {
                    sql += $"N'{dsTenTaiSan[i]}'";
                    if (i < dsTenTaiSan.Count - 1)
                    {
                        sql += ", ";
                    }
                }
                sql += ") GROUP BY PT.MAPT, PT.MANT, PT.MATT, PT.TENPHONG, PT.DONGIA, PT.CHIEUDAI, PT.CHIEURONG, PT.SOLUONGNGUOITD, PT.MOTA, PT.ANH, PT.DAXOA HAVING COUNT(DISTINCT TS.TENTAISAN) = " + dsTenTaiSan.Count;

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    PhongDTO phong = new PhongDTO
                    {
                        MaPT = reader["MAPT"].ToString(),
                        MaNT = reader["MANT"].ToString(),
                        MaTT = reader["MATT"].ToString(),
                        TenPhong = reader["TENPHONG"].ToString(),
                        DonGia = Convert.ToDecimal(reader["DONGIA"]),
                        ChieuDai = Convert.ToDouble(reader["CHIEUDAI"]),
                        ChieuRong = Convert.ToDouble(reader["CHIEURONG"]),
                        SoLuongNguoiTD = Convert.ToInt32(reader["SOLUONGNGUOITD"]),
                        MoTa = reader["MOTA"].ToString(),
                        Anh = reader["ANH"].ToString()
                    };
                    danhSachPhong.Add(phong);
                }

                reader.Close();
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lọc phòng theo tài sản: " + ex.Message);
            }

            return danhSachPhong;
        }

        public bool SuaPhong(PhongDTO phong)
        {
            string sql = "UPDATE PHONGTRO SET TENPHONG = N'" + phong.TenPhong + "', DONGIA = " + phong.DonGia + ", CHIEUDAI = " + phong.ChieuDai + ", CHIEURONG = " + phong.ChieuRong + ", SOLUONGNGUOITD = " + phong.SoLuongNguoiTD + ", MOTA = N'" + phong.MoTa + "', ANH = '" + phong.Anh + "', MATT = '" + phong.MaTT + "', MaNT = '" + phong.MaNT + "' WHERE MAPT = '" + phong.MaPT + "'";
            return conn.ExecuteNonQuery(sql) > 0;
        }

        public bool XoaPhong(string maPT)
        {
            string sql = "UPDATE PHONGTRO SET DAXOA = 1 WHERE MAPT = '" + maPT + "'";
            return conn.ExecuteNonQuery(sql) > 0;
        }

        public List<PhongDTO> LocPhongTheoGia(string gia, string maNT)
        {
            List<PhongDTO> danhSachPhong = new List<PhongDTO>();

            try
            {
                string sql = "SELECT * FROM PHONGTRO WHERE DONGIA <= " + gia + " AND MANT = '" + maNT + "' AND DAXOA = 0";

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    PhongDTO phong = new PhongDTO();

                    phong.MaPT = reader["MAPT"].ToString();
                    phong.MaNT = reader["MANT"].ToString();
                    phong.MaTT = reader["MATT"].ToString();
                    phong.TenPhong = reader["TENPHONG"].ToString();
                    phong.DonGia = Convert.ToDecimal(reader["DONGIA"]);
                    phong.ChieuDai = Convert.ToDouble(reader["CHIEUDAI"]);
                    phong.ChieuRong = Convert.ToDouble(reader["CHIEURONG"]);
                    phong.SoLuongNguoiTD = Convert.ToInt32(reader["SOLUONGNGUOITD"]);
                    phong.MoTa = reader["MOTA"].ToString();
                    phong.Anh = reader["ANH"].ToString();

                    danhSachPhong.Add(phong);
                }

                reader.Close();
                conn.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lọc phòng theo giá: " + ex.Message);
            }

            return danhSachPhong;
        }
    }
}
