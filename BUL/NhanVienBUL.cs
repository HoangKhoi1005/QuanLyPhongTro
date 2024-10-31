using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class NhanVienBUL
    {
        NhanVienDAL nhanVienDAL;
        public NhanVienBUL()
        {
            nhanVienDAL = new NhanVienDAL();
        }
        public NhanVienDTO thongTinNhanVien(string maQL)
        {
            return nhanVienDAL.thongTinNhanVien(maQL);
        }

        public bool suaThongTin(NhanVienDTO nhanvien)
        {
            return nhanVienDAL.suaThongTin(nhanvien);
        }
    }
}
