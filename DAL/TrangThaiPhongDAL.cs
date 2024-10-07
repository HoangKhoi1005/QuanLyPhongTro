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
    public class TrangThaiPhongDAL
    {
        DBConnect conn;

        public TrangThaiPhongDAL()
        {
            conn = new DBConnect();
        }

        // Lấy tất cả các trạng thái phòng
        public List<TrangThaiPhongDTO> LayTatCaTrangThaiPhong()
        {
            List<TrangThaiPhongDTO> lstTrangThai = new List<TrangThaiPhongDTO>();
            string query = "SELECT MATT, TENTRANGTHAI, MOTA FROM TRANGTHAIPHONG";

            try
            {
                using (SqlDataReader reader = conn.ExecuteQuery(query))
                {
                    while (reader.Read())
                    {
                        TrangThaiPhongDTO trangThai = new TrangThaiPhongDTO
                        {
                            MaTT = reader["MATT"].ToString(),
                            TenTrangThai = reader["TENTRANGTHAI"].ToString(),
                            MoTa = reader["MOTA"].ToString()
                        };
                        lstTrangThai.Add(trangThai);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách trạng thái phòng: " + ex.Message);
            }

            return lstTrangThai;
        }


        public string LayTenTrangThaiTheoMa(string maTT)
        {
            string tenTrangThai = "";

            string query = "SELECT TENTRANGTHAI FROM TRANGTHAIPHONG WHERE MATT = '" + maTT + "'";
            using (SqlDataReader reader = conn.ExecuteQuery(query))
            {
                while (reader.Read())
                {
                    tenTrangThai = reader["TENTRANGTHAI"].ToString();
                }
            }
            return tenTrangThai;
        }
    }
}
