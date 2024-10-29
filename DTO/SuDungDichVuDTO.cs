using System;

namespace DTO
{
    public class SuDungDichVuDTO
    {
        public int Id { get; set; }
        public string MaPT { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool DaXoa { get; set; }

        public SuDungDichVuDTO()
        {
            Id = 0;
            MaPT = string.Empty;
            MaDV = string.Empty;
            SoLuong = 0;
            NgayBatDau = DateTime.Now;
            NgayKetThuc = DateTime.Now;
            DaXoa = false;
        }

        public SuDungDichVuDTO(int id, string maPT, string maDV, int soLuong, DateTime ngayBatDau, DateTime ngayKetThuc, bool daXoa)
        {
            Id = id;
            MaPT = maPT;
            MaDV = maDV;
            SoLuong = soLuong;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            DaXoa = daXoa;
        }
    }
}
