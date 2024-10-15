using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongDTO
    {
        public string MaHopDong { get; set; }
        public string MaPT { get; set; }
        public string MaQL { get; set; }
        public string MaKT { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal TienCoc { get; set; }
        public bool TrangThaiHopDong { get; set; }
        public string MoTa { get; set; }

        public HopDongDTO()
        {
        }

        public HopDongDTO(string maHopDong, string maPT, string maQL, string maKT, DateTime ngayLap, DateTime ngayHetHan, decimal tienCoc, bool trangThaiHopDong, string moTa)
        {
            MaHopDong = maHopDong;
            MaPT = maPT;
            MaQL = maQL;
            MaKT = maKT;
            NgayLap = ngayLap;
            NgayHetHan = ngayHetHan;
            TienCoc = tienCoc;
            TrangThaiHopDong = trangThaiHopDong;
            MoTa = moTa;
        }
    }
}
