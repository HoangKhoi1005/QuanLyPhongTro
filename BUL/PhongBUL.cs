using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhongBUL
    {
        PhongDAL phongDAL;

        public PhongBUL()
        {
            phongDAL = new PhongDAL();
        }

        public List<PhongDTO> LayPhongTheoNhaTro(string maNT)
        {
            return phongDAL.LayPhongTheoNhaTro(maNT);
        }

        public bool KiemTraPhongDaCoHopDong(string maPT)
        {
            return phongDAL.KiemTraPhongDaCoHopDong(maPT);
        }

        public List<PhongDTO> LayPhongTheoTrangThai(string maTT, string maNT)
        {
            return phongDAL.LayPhongTheoTrangThai(maTT, maNT);
        }

        public bool ThemPhong(PhongDTO phong)
        {
            return phongDAL.ThemPhong(phong);
        }

        public string PhatSinhMaPhong(string MaNT)
        {
            return phongDAL.PhatSinhMaPhong(MaNT);
        }

        public List<PhongDTO> TimKiemPhongTheoMaPhong(string maPhong, string maNT)
        {
            return phongDAL.TimKiemPhongTheoMaPhong(maPhong, maNT);
        }

        public bool CapNhatTrangThaiPhong(string MaPT, string MaTT)
        {
            return phongDAL.CapNhatTrangThaiPhong(MaPT, MaTT);
        }

        public List<string> LayTatCaMaPhong()
        {
            return phongDAL.LayTatCaMaPhong();
        }

        public List<PhongDTO> LocPhongTheoTaiSan(List<string> dsTaiSan, string maNT)
        {
            return phongDAL.LocPhongTheoTaiSan(dsTaiSan, maNT);
        }

        public bool SuaPhong(PhongDTO phong)
        {
            return phongDAL.SuaPhong(phong);
        }
    }
}
