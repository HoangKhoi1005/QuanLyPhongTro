using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class KhachTroBUL
    {
        KhachTroDAL khachTroDAL;

        public KhachTroBUL()
        {
            khachTroDAL = new KhachTroDAL();
        }

        public List<KhachTroDTO> LayDanhSachKhachTro()
        {
            return khachTroDAL.LayDanhSachKhachTro();
        }

        public List<KhachTroDTO> TimKiemKhachTro(string ten)
        {
            return khachTroDAL.TimKiemKhachTro(ten);
        }

        public string PhatSinhMaKhachTro()
        {
            return khachTroDAL.PhatSinhMaKhachTro();
        }

        public List<KhachTroDTO> LayDSKhachTroChuaThuePhong()
        {
            return khachTroDAL.LayDSKhachTroChuaThuePhong();
        }

        public bool KiemTraKhachTroTonTai(string MAKT)
        {
            return khachTroDAL.KiemTraKhachTroTonTai(MAKT);
        }

        public bool ThemKhachTro(KhachTroDTO khachTro)
        {
            return khachTroDAL.ThemKhachTro(khachTro);
        }
    }
}