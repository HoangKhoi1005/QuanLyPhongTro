using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachTroHopDongDTO
    {
        public string MaHopDong { get; set; }
        public string MaKT { get; set; }

        public KhachTroHopDongDTO() { }

        public KhachTroHopDongDTO(string maHopDong, string maKT)
        {
            MaHopDong = maHopDong;
            MaKT = maKT;
        }
    }
}
