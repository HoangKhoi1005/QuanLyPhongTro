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
    public class DoanhThuDAL
    {

        private DBConnect dbConnect;

        public DoanhThuDAL()
        {
            dbConnect = new DBConnect(); // Khởi tạo đối tượng DBConnect
        }

        // Lấy doanh thu theo tháng
        public List<DoanhThuDTO> LayDoanhThuTheoThang()
        {
            // Truy vấn SQL lấy doanh thu theo tháng
            string query = @"
                SELECT MONTH(NGAYTHANHTOAN) AS Thang, SUM(TONGTIEN) AS DoanhThu
                FROM HOADON
                GROUP BY MONTH(NGAYTHANHTOAN)
                ORDER BY Thang";

            // Lấy dữ liệu từ DBConnect và chuyển sang DataTable
            DataTable dt = dbConnect.GetDataTable(query);

            // Dùng LINQ để chuyển DataTable thành List<DoanhThuDTO>
            var result = (from row in dt.AsEnumerable()
                          select new DoanhThuDTO
                          {
                              Thang = Convert.ToInt32(row["Thang"]),
                              DoanhThu = Convert.ToDecimal(row["DoanhThu"])
                          }).ToList();

            return result;
        }
    }
}
