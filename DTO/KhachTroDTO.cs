using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachTroDTO
    {
        public string MaKT { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public int DaXoa { get; set; }

        public KhachTroDTO()
        {
        }

        public KhachTroDTO(string maKT, string hoTen, string diaChi, string soDT, string cccd, string email, DateTime ngaySinh, string gioiTinh, string anh, string moTa, int daXoa)
        {
            MaKT = maKT;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDT = soDT;
            CCCD = cccd;
            Email = email;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Anh = anh;
            MoTa = moTa;
            DaXoa = daXoa;
        }
    }
}
