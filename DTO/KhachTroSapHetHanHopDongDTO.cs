using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachTroSapHetHanHopDongDTO
    {
        public string TenNhaTro { get; set; }
        public string MaPhong { get; set; }
        public string TenKhach { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal GiaTien { get; set; }
    }
}
