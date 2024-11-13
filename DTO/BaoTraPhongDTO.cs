using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoTraPhongDTO
    {
        public string MaBaoTra { get; set; }
        public string MaPT { get; set; }
        public DateTime NgayBao { get; set; }
        public DateTime NgayTraPhongDuKien { get; set; }
        public string MoTa { get; set; }
        public bool DaXoa { get; set; }

        public BaoTraPhongDTO()
        {
            MaBaoTra = "";
            MaPT = "";
            NgayBao = DateTime.Now;
            NgayTraPhongDuKien = DateTime.Now;
            MoTa = "";
            DaXoa = false;
        }

        public BaoTraPhongDTO(string maBaoTra, string maPT, DateTime ngayBao, DateTime ngayTraPhongDuKien, string moTa, bool daXoa)
        {
            MaBaoTra = maBaoTra;
            MaPT = maPT;
            NgayBao = ngayBao;
            NgayTraPhongDuKien = ngayTraPhongDuKien;
            MoTa = moTa;
            DaXoa = daXoa;
        }
    }
}
