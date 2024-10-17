using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        private string moTa;
        private decimal donGia;
        private string maDV;
        private string tenDV;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
