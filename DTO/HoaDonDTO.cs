using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public string MaPT { get; set; }
        public string MaQL { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public decimal TienDaThanhToan { get; set; }
        public string MoTa { get; set; }
        public bool DaXoa { get; set; }

        public HoaDonDTO()
        {
        }

        public HoaDonDTO(string maHD, string maPT, string maQL, DateTime ngayLap, DateTime ngayThanhToan, decimal tongTien, decimal tienDaThanhToan, string moTa, bool daXoa)
        {
            MaHD = maHD;
            MaPT = maPT;
            MaQL = maQL;
            NgayLap = ngayLap;
            NgayThanhToan = ngayThanhToan;
            TongTien = tongTien;
            TienDaThanhToan = tienDaThanhToan;
            MoTa = moTa;
            DaXoa = daXoa;
        }
    }
}
