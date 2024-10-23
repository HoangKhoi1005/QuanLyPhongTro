using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class DichVuBUL
    {
        DichVuDAL DichVuDAL;
        public DichVuBUL()
        {
            DichVuDAL = new DichVuDAL();
        }
        public List<DichVuDTO> loadDichVu()
        {
            return DichVuDAL.loadDichVu();
        }

        public bool themDichVu(DichVuDTO dichVuDTO)
        {
            return DichVuDAL.themDichVu(dichVuDTO);
        }

        public string PhatSinhMaDichVu()
        {
            return DichVuDAL.PhatSinhMaDichVu();
        }

        public bool suaDichVu(DichVuDTO dichVuDTO)
        {
            return DichVuDAL.suaDichVu(dichVuDTO);
        }

        public bool xoaDichVu(DichVuDTO dichVuDTO)
        {
            return DichVuDAL.xoaDichVu(dichVuDTO);
        }

        public List<DichVuDTO> TimKiemDichVu(string tendv)
        {
            return DichVuDAL.TimKiemDichVu(tendv);
        }
    }
}
