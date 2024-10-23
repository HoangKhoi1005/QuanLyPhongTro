using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiSanDTO
    {
        public string MaTS { get; set; }
        public string MaPT { get; set; }
        public string TenTaiSan { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgaySuDung { get; set; }
        public DateTime? NgayThanhLy { get; set; }
        public string MoTa { get; set; }
        public bool DaXoa { get; set; }
        public bool DaHu { get; set; }

        public TaiSanDTO()
        {
        }

        public TaiSanDTO(string maTS, string maPT, string tenTaiSan, decimal donGia, DateTime ngaySuDung, DateTime ngayThanhLy, string moTa, bool daXoa, bool daHu)
        {
            MaTS = maTS;
            MaPT = maPT;
            TenTaiSan = tenTaiSan;
            DonGia = donGia;
            NgaySuDung = ngaySuDung;
            NgayThanhLy = ngayThanhLy;
            MoTa = moTa;
            DaXoa = daXoa;
            DaHu = daHu;
        }
    }
}
