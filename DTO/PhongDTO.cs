using System;

namespace DTO
{
    public class PhongDTO
    {
        public string MaPT { get; set; }
        public string MaNT { get; set; }
        public string MaTT { get; set; }
        public string TenPhong { get; set; }
        public decimal DonGia { get; set; }
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public int SoLuongNguoiTD { get; set; }
        public string MoTa { get; set; }
        public string Anh { get; set; }
        public int TrangThai { get; set; }

        public PhongDTO()
        {
            TrangThai = 1;
        }

        public PhongDTO(string maPT, string maNT, string maTT, string tenPhong, decimal donGia, double chieuDai, double chieuRong, int soLuongNguoiTD, string moTa, string anh, int trangThai = 1)
        {
            MaPT = maPT;
            MaNT = maNT;
            MaTT = maTT;
            TenPhong = tenPhong;
            DonGia = donGia;
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
            SoLuongNguoiTD = soLuongNguoiTD;
            MoTa = moTa;
            Anh = anh;
            TrangThai = trangThai;
        }
    }
}
