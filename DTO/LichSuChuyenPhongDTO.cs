using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuChuyenPhongDTO
    {
        public int MaPhieuChuyen { get; set; }
        public string MaKT { get; set; }
        public string MaPTCu { get; set; }
        public string MaPTMoi { get; set; }
        public DateTime NgayChuyen { get; set; }
        public string MaHDCu { get; set; }

        public LichSuChuyenPhongDTO()
        {
            MaPhieuChuyen = 0;
            MaKT = "";
            MaPTCu = "";
            MaPTMoi = "";
            NgayChuyen = DateTime.Now;
            MaHDCu = "";
        }

        public LichSuChuyenPhongDTO(int maPhieuChuyen, string maKT, string maPTCu, string maPTMoi, DateTime ngayChuyen, string maHDCu)
        {
            MaPhieuChuyen = maPhieuChuyen;
            MaKT = maKT;
            MaPTCu = maPTCu;
            MaPTMoi = maPTMoi;
            NgayChuyen = ngayChuyen;
            MaHDCu = maHDCu;
        }
    }
}
