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
                string sql = "SELECT * FROM PHONGTRO WHERE MANT = '" + maNT + "' AND TRANGTHAI = 1";

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
                string sql = "SELECT * FROM PHONGTRO WHERE MATT = '" + maTT + "' AND MANT = '" + maNT + "' AND TRANGTHAI = 1";

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
            string sql = "INSERT INTO PHONGTRO VALUES('" + phong.MaPT + "', '" + phong.MaNT + "', '" + phong.MaTT + "', N'" + phong.TenPhong + "', " + phong.DonGia + ", " + phong.ChieuDai + ", " + phong.ChieuRong + ", " + phong.SoLuongNguoiTD + ", N'" + phong.MoTa + "', '" + phong.Anh + "', 1)";

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
                string sql = "SELECT * FROM PHONGTRO WHERE MAPT LIKE '%" + maPhong + "%' AND MANT = '" + maNT + "' AND TRANGTHAI = 1";

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
    }
}
