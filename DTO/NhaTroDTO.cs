using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaTroDTO
    {
        public string MaNT { get; set; }
        public string TenNT { get; set; }
        public string DiaChiNT { get; set; }
        public string SoDT { get; set; }
        public string ChuNhaTro { get; set; }
        public int TrangThai { get; set; }

        // Constructor không tham số (mặc định)
        public NhaTroDTO()
        {
        }

        // Constructor có tham số
        public NhaTroDTO(string maNT, string tenNT, string diaChiNT, string soDT, string chuNhaTro, int trangThai)
        {
            MaNT = maNT;
            TenNT = tenNT;
            DiaChiNT = diaChiNT;
            SoDT = soDT;
            ChuNhaTro = chuNhaTro;
            TrangThai = trangThai;
        }
    }

}
