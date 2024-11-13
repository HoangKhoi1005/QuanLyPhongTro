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
    public class PhongTrongDAL
    {
        private DBConnect dbConnect;  // Kết nối database

        public PhongTrongDAL()
        {
            dbConnect = new DBConnect(); // Giả sử lớp DBConnect đã có sẵn
        }

        public List<PhongTrongDTO> LayDanhSachPhongTrong()
        {
            string query = @"
                SELECT 
                    NT.TENNT AS TenNhaTro,
                    COUNT(PT.MAPT) AS SoLuongPhongTrong
                FROM 
                    NHATRO NT
                JOIN 
                    PHONGTRO PT ON NT.MANT = PT.MANT
                WHERE 
                    PT.MATT = 'TT01' 
                GROUP BY 
                    NT.TENNT";

            DataTable dt = dbConnect.GetDataTable(query);

            return (from row in dt.AsEnumerable()
                    select new PhongTrongDTO
                    {
                        TenNhaTro = row["TenNhaTro"].ToString(),
                        SoLuongPhongTrong = Convert.ToInt32(row["SoLuongPhongTrong"])
                    }).ToList();
        }
    }
}
