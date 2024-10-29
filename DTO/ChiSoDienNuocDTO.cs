using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiSoDienNuocDTO
    {
        private string maPT;
        private DateTime ngayThang;
        private int chiSoDien, chiSoNuoc, maCS;

        public string MaPT { get => maPT; set => maPT = value; }
        public DateTime NgayThang { get => ngayThang; set => ngayThang = value; }
        public int ChiSoDien { get => chiSoDien; set => chiSoDien = value; }
        public int ChiSoNuoc { get => chiSoNuoc; set => chiSoNuoc = value; }
        public int MaCS { get => maCS; set => maCS = value; }

        public ChiSoDienNuocDTO() { }

        public ChiSoDienNuocDTO(int maCS, string maPT, DateTime ngayThang, int chiSoDien, int chiSoNuoc)
        {
            MaCS = maCS;
            MaPT = maPT;
            NgayThang = ngayThang;
            ChiSoDien = chiSoDien;
            ChiSoNuoc = chiSoNuoc;
            MaCS = maCS;
            MaPT = maPT;
            NgayThang = ngayThang;
            ChiSoDien = chiSoDien;
            ChiSoNuoc = chiSoNuoc;
        }
    }
}
