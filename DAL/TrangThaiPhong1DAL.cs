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
    public class TrangThaiPhong1DAL
    {
        private DBConnect dbConnect;

        public TrangThaiPhong1DAL()
        {
            dbConnect = new DBConnect();
        }

        public List<TrangThaiPhong1DTO> LayTrangThaiPhong()
        {
            // Truy vấn SQL lấy dữ liệu từ bảng TRANGTHAIPHONG và tính số lượng phòng theo từng trạng thái
            string query = @"
                SELECT T.MATT, T.TENTRANGTHAI, 
                       ISNULL(COUNT(P.MAPT), 0) AS SoLuong
                FROM TRANGTHAIPHONG T
                LEFT JOIN PHONGTRO P ON P.MATT = T.MATT AND P.DAXOA = 0
                GROUP BY T.MATT, T.TENTRANGTHAI
            ";

            // Lấy dữ liệu từ DBConnect và chuyển sang DataTable
            DataTable dt = dbConnect.GetDataTable(query);

            // Lấy tổng số phòng để tính tỷ lệ phần trăm
            int totalRooms = (int)dbConnect.ExecuteScalar("SELECT COUNT(*) FROM PHONGTRO WHERE DAXOA = 0");

            // Sử dụng LINQ để chuyển DataTable thành List<TrangThaiPhong1DTO>
            var result = (from row in dt.AsEnumerable()
                          select new TrangThaiPhong1DTO
                          {
                              TenTrangThai = row["TENTRANGTHAI"].ToString(),
                              SoLuong = Convert.ToInt32(row["SoLuong"]),
                              PhanTram = totalRooms > 0 ? Convert.ToInt32(row["SoLuong"]) * 100.0 / totalRooms : 0 // Tính tỷ lệ phần trăm
                          }).ToList();

            return result;
        }
    }
}
