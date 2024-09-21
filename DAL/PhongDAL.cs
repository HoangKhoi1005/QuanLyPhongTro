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
                string sql = "SELECT * FROM PHONGTRO WHERE MANT = '" + maNT + "'";

                SqlDataReader reader = conn.ExecuteQuery(sql);

                while (reader.Read())
                {
                    // Tạo đối tượng PhongDTO mới cho mỗi lần đọc
                    PhongDTO phong = new PhongDTO();

                    phong.MaPT = reader["MAPT"].ToString();
                    phong.MaNT = reader["MANT"].ToString();
                    phong.TenPhong = reader["TENPHONG"].ToString();
                    phong.DonGia = Convert.ToDecimal(reader["DONGIA"]);
                    phong.ChieuDai = Convert.ToDouble(reader["CHIEUDAI"]);
                    phong.ChieuRong = Convert.ToDouble(reader["CHIEURONG"]);
                    phong.SoLuongNguoiTD = Convert.ToInt32(reader["SOLUONGNGUOITD"]);
                    phong.GioiTinhNam = Convert.ToBoolean(reader["GIOITINH_NAM"]);
                    phong.GioiTinhNu = Convert.ToBoolean(reader["GIOITINH_NU"]);
                    phong.MoTa = reader["MOTA"].ToString();
                    phong.Anh = reader["ANH"].ToString();
                    phong.ThuTu = Convert.ToInt32(reader["THUTU"]);
                    phong.TrangThai = reader["TRANGTHAI"].ToString();

                    // Thêm đối tượng phong mới vào danh sách
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
    }
}
