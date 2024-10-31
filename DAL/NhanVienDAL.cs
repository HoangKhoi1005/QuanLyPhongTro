using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        private QLPTDataContext ql = new QLPTDataContext();
        public NhanVienDTO thongTinNhanVien(string maQL)
        {
            try
            {
                QUANLY quanLy = ql.QUANLies.FirstOrDefault(q => q.MAQL == maQL);

                if (quanLy == null)
                {
                    Console.WriteLine($"Không tìm thấy quản lý với mã: {maQL}");
                    return null;
                }

                return new NhanVienDTO
                (
                    quanLy.MAQL,
                    quanLy.HOTENNV,
                    quanLy.DIACHINV,
                    quanLy.SODT,
                    quanLy.EMAILNV,
                    quanLy.ANH,
                    quanLy.MATKHAU,
                    quanLy.NGAYSINH ?? DateTime.MinValue,
                    quanLy.NGAYVAO ?? DateTime.MinValue
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
        }

        public bool suaThongTin(NhanVienDTO nhanvien)
        {
            try
            {
                string maql = nhanvien.MaQL;
                QUANLY qly = ql.QUANLies.Where(t => t.MAQL == nhanvien.MaQL).FirstOrDefault();
                qly.HOTENNV = nhanvien.HoTen;
                qly.DIACHINV = nhanvien.DiaChi;
                qly.SODT = nhanvien.SoDT;
                qly.EMAILNV = nhanvien.Email;
                qly.ANH = nhanvien.Anh;
                qly.NGAYSINH = nhanvien.NgaySinh;
                qly.NGAYVAO = nhanvien.NgayVao;
                qly.MATKHAU = nhanvien.MatKhau;

                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
