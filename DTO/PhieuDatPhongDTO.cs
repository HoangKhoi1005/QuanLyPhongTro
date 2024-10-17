using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatPhongDTO
    {
        public string MaPhieuDatPhong { get; set; }
        public string MaKhachTro { get; set; }
        public string MaPhongTro { get; set; }
        public string MaQuanLy { get; set; }
        public DateTime NgayDuKienNhanPhong { get; set; }
        public decimal TienDatPhong { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string MoTa { get; set; }
        public bool DaXoa { get; set; }

        public PhieuDatPhongDTO()
        {
        }

        public PhieuDatPhongDTO(string maPhieuDatPhong, string maKhachTro, string maPhongTro, string maQuanLy, DateTime ngayDuKienNhanPhong, decimal tienDatPhong, DateTime ngayLapPhieu, string moTa, bool daXoa)
        {
            MaPhieuDatPhong = maPhieuDatPhong;
            MaKhachTro = maKhachTro;
            MaPhongTro = maPhongTro;
            MaQuanLy = maQuanLy;
            NgayDuKienNhanPhong = ngayDuKienNhanPhong;
            TienDatPhong = tienDatPhong;
            NgayLapPhieu = ngayLapPhieu;
            MoTa = moTa;
            DaXoa = daXoa;
        }

    }
}