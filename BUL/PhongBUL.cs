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

        public List<PhongDTO> TimKiemPhongTheoMaPhong(string maPhong, string tenKhachTro, string maNT, int soLuongNguoiO = -1)
        {
            return phongDAL.TimKiemPhongTheoMaPhong(maPhong, tenKhachTro, maNT, soLuongNguoiO);
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

        public bool XoaPhong(string maPT)
        {
            return phongDAL.XoaPhong(maPT);
        }

        public List<PhongDTO> LocPhongTheoGia(string gia, string maNT)
        {
            return phongDAL.LocPhongTheoGia(gia, maNT);
        }

        public List<PhongDTO> LayPhongTrongTheoNhaTro(string maNT)
        {
            return phongDAL.LayPhongTrongTheoNhaTro(maNT);
        }

        public PhongDTO LayPhongTheoMa(string maPT)
        {
            return phongDAL.LayPhongTheoMa(maPT);
        }

        public List<PhongDTO> LayTatCaPhong()
        {
            return phongDAL.LayTatCaPhong();
        }

        public List<PhongDTO> LayPhongDaCoHopDong()
        {
            return phongDAL.LayPhongDaCoHopDong();
        }

        public List<PhongDTO> LayPhongCoHopDongTheoNhaTro(string maNT)
        {
            return phongDAL.LayPhongCoHopDongTheoNhaTro(maNT);
        }

        public List<PhongDTO> LocPhongTrongTheoNgay(DateTime ngayChon, string maNT)
        {
            return phongDAL.LocPhongTrongTheoNgay(ngayChon, maNT);
        }

        public int DemSoPhongTrongTheoNha(string maNT)
        {
            return phongDAL.DemSoPhongTrongTheoNha(maNT);
        }

        public int DemSoPhongDaThueTheoNha(string maNT)
        {
            return phongDAL.DemSoPhongDaThueTheoNha(maNT);
        }

        public int DemSoPhongDaDatTheoNha(string maNT)
        {
            return phongDAL.DemSoPhongDaDatTheoNha(maNT);
        }

        public bool KiemTraPhongDaCoHoaDonTrongThang(string maPT, DateTime now)
        {
            return phongDAL.KiemTraPhongDaCoHoaDonTrongThang(maPT, now);
        }

        public Dictionary<string, string> GetContractDictionary(string maPhong)
        {
            return phongDAL.GetContractDictionary(maPhong);
        }
    }
}
