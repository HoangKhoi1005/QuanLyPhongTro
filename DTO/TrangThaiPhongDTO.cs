using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiPhongDTO
    {
        public string MaTT { get; set; }
        public string TenTrangThai { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }

        public TrangThaiPhongDTO() { }

        public TrangThaiPhongDTO(string maTT, string tenTrangThai, string moTa, int trangThai)
        {
            MaTT = maTT;
            TenTrangThai = tenTrangThai;
            MoTa = moTa;
            TrangThai = trangThai;
        }
    }
}
