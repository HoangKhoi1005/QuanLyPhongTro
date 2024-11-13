using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KyLuatDTO
    {
        public int MaKL { get; set; }
        public string MaKT { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayKL { get; set; }
        public string LoaiKL { get; set; }

        public KyLuatDTO() { }

        public KyLuatDTO(int maKL, string maKT, string moTa, DateTime ngayKL, string loaiKL)
        {
            MaKL = maKL;
            MaKT = maKT;
            MoTa = moTa;
            NgayKL = ngayKL;
            LoaiKL = loaiKL;
        }
    }
}
