using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maQL, hoTen, diaChi, soDT, email, anh, matKhau;
        private DateTime ngaySinh, ngayVao;

        public string MaQL { get => maQL; set => maQL = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string Anh { get => anh; set => anh = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayVao { get => ngayVao; set => ngayVao = value; }

        public NhanVienDTO() { }

        public NhanVienDTO(string maQL, string hoTen, string diaChi, string soDT, string email, string anh, string matKhau, DateTime ngaySinh, DateTime ngayVao)
        {
            MaQL = maQL;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDT = soDT;
            Email = email;
            Anh = anh;
            MatKhau = matKhau;
            NgaySinh = ngaySinh;
            NgayVao = ngayVao; 
        }
    }
}
