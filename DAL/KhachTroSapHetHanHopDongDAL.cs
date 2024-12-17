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
    public class KhachTroSapHetHanHopDongDAL
    {
        private DBConnect dbConnect;

        public KhachTroSapHetHanHopDongDAL()
        {
            dbConnect = new DBConnect();  // Giả sử bạn đã có lớp DBConnect để kết nối SQL
        }

        // Phương thức lấy danh sách khách trọ sắp hết hạn hợp đồng
        public List<KhachTroSapHetHanHopDongDTO> LayKhachTroSapHetHopDong()
        {
            string query = @"
        SELECT 
            NT.TENNT AS 'Nhà trọ', 
            PT.TENPHONG AS 'Phòng', 
            KH.HOTEN AS 'Tên khách', 
            HD.NGAYHETHAN AS 'Ngày hết hạn', 
            PT.DONGIA AS 'Giá tiền'
        FROM 
            KHACHTRO KH
        JOIN 
            KHACHTRO_HOPDONG KHHD ON KH.MAKT = KHHD.MAKT
        JOIN 
            HOPDONG HD ON KHHD.MAHOPDONG = HD.MAHOPDONG
        JOIN 
            PHONGTRO PT ON HD.MAPT = PT.MAPT
        JOIN 
            NHATRO NT ON PT.MANT = NT.MANT
        WHERE 
            HD.NGAYHETHAN BETWEEN GETDATE() AND DATEADD(DAY, 30, GETDATE()) AND HD.MAKTDAIDIEN = KHHD.MAKT
            AND HD.TRANGTHAIHOPDONG = 1";

            // Lấy dữ liệu từ database
            DataTable dt = dbConnect.GetDataTable(query);

            // Kiểm tra xem có dữ liệu không
            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("Không có khách trọ sắp hết hạn hợp đồng.");
            }

            // Chuyển đổi dữ liệu từ DataTable sang list DTO
            var result = (from row in dt.AsEnumerable()
                          select new KhachTroSapHetHanHopDongDTO
                          {
                              TenNhaTro = row["Nhà trọ"].ToString(),
                              MaPhong = row["Phòng"].ToString(),
                              TenKhach = row["Tên khách"].ToString(),
                              NgayHetHan = Convert.ToDateTime(row["Ngày hết hạn"]),
                              GiaTien = Convert.ToDecimal(row["Giá tiền"])
                          }).ToList();

            return result;
        }
    }
}
