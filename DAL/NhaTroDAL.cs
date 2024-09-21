using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaTroDAL
    {
        DBConnect db;

        public NhaTroDAL()
        {
            db = new DBConnect();
        }

        public List<NhaTroDTO> LayDanhSachNhaTro()
        {
            string query = "SELECT * FROM NhaTro";
            var reader = db.ExecuteQuery(query);
            List<NhaTroDTO> lstNhaTro = new List<NhaTroDTO>();
            while (reader.Read())
            {
                NhaTroDTO nhaTro = new NhaTroDTO();
                nhaTro.MaNT = reader["MaNT"].ToString();
                nhaTro.TenNT = reader["TenNT"].ToString();
                nhaTro.DiaChiNT = reader["DiaChiNT"].ToString();
                nhaTro.SoDT = reader["SoDT"].ToString();
                nhaTro.ChuNhaTro = reader["ChuNhaTro"].ToString();
                lstNhaTro.Add(nhaTro);
            }
            reader.Close();
            return lstNhaTro;
        }
    }
}
