using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhatSinhDTO
    {
        private int maPS;
        private string maPT, moTa, loaiPS;
        private DateTime ngayThang;
        private decimal soTien;

        public int MaPS { get => maPS; set => maPS = value; }
        public string MaPT { get => maPT; set => maPT = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string LoaiPS { get => loaiPS; set => loaiPS = value; }
        public DateTime NgayThang { get => ngayThang; set => ngayThang = value; }
        public decimal SoTien { get => soTien; set => soTien = value; }

        public PhatSinhDTO() { }

        public PhatSinhDTO(int maPS, string maPT, string moTa, string loaiPS, DateTime ngayThang, decimal soTien)
        {
            MaPS = maPS;
            MaPT = maPT;
            MoTa = moTa;
            LoaiPS = loaiPS;
            NgayThang = ngayThang;
            SoTien = soTien;
        }
    }
}
