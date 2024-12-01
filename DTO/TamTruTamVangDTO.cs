using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TamTruTamVangDTO
    {
        public string MaTTTV { get; set; }
        public string MaKT { get; set; }
        public string LoaiTTTV { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MoTa { get; set; }

        public TamTruTamVangDTO()
        {
        }

        public TamTruTamVangDTO(string maTTTV, string maKT, string loaiTTTV, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa)
        {
            MaTTTV = maTTTV;
            MaKT = maKT;
            LoaiTTTV = loaiTTTV;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            MoTa = moTa;
        }
    }
}
