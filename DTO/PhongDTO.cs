using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        public string MaPT { get; set; }
        public string MaNT { get; set; }
        public string TenPhong { get; set; }
        public decimal DonGia { get; set; }
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public int SoLuongNguoiTD { get; set; }
        public bool GioiTinhNam { get; set; }
        public bool GioiTinhNu { get; set; } 
        public string MoTa { get; set; }
        public string Anh { get; set; }
        public int ThuTu { get; set; }
        public string TrangThai { get; set; }

        public PhongDTO()
        {
            TrangThai = "Trống";
            ThuTu = 0;
        }

        public PhongDTO(string maPT, string maNT, string tenPhong, decimal donGia, double chieuDai, double chieuRong, int soLuongNguoiTD, bool gioiTinhNam, bool gioiTinhNu, string moTa, string anh, int thuTu = 0, string trangThai = "Trống")
        {
            MaPT = maPT;
            MaNT = maNT;
            TenPhong = tenPhong;
            DonGia = donGia;
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
            SoLuongNguoiTD = soLuongNguoiTD;
            GioiTinhNam = gioiTinhNam;
            GioiTinhNu = gioiTinhNu;
            MoTa = moTa;
            Anh = anh;
            ThuTu = thuTu;
            TrangThai = trangThai;
        }
    }
}
