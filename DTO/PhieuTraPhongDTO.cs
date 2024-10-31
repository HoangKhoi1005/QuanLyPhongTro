using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTraPhongDTO
    {
        private string maPhieuTra;
        private string maPT;
        private DateTime ngayBao;
        private DateTime ngayTra;
        private double tienHoanTra;
        private string moTa;
        private bool daXoa;

        public string MaPhieuTra { get => maPhieuTra; set => maPhieuTra = value; }
        public string MaPT { get => maPT; set => maPT = value; }
        public DateTime NgayBao { get => ngayBao; set => ngayBao = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public double TienHoanTra { get => tienHoanTra; set => tienHoanTra = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public bool DaXoa { get => daXoa; set => daXoa = value; }

        public PhieuTraPhongDTO()
        {
        }

        public PhieuTraPhongDTO(string maPhieuTra, string maPT, DateTime ngayBao, DateTime ngayTra, double tienHoanTra, string moTa, bool daXoa)
        {
            this.MaPhieuTra = maPhieuTra;
            this.MaPT = maPT;
            this.NgayBao = ngayBao;
            this.NgayTra = ngayTra;
            this.TienHoanTra = tienHoanTra;
            this.MoTa = moTa;
            this.DaXoa = daXoa;
        }
    }
}
