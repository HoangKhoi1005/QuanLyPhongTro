using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChiSoDienNuocBUL
    {
        ChiSoDienNuocDAL chiSoDienNuocDAL;
        public ChiSoDienNuocBUL() 
        { 
            chiSoDienNuocDAL = new ChiSoDienNuocDAL();
        }

        public List<ChiSoDienNuocDTO> loadDienNuoc()
        {
            return chiSoDienNuocDAL.loadDienNuoc();
        }

        public List<string> loadMaPT()
        {
            return chiSoDienNuocDAL.loadMaPT();
        }

        public bool themDienNuoc(ChiSoDienNuocDTO dienNuoc)
        {
            return chiSoDienNuocDAL.themDienNuoc(dienNuoc);
        }

        public int PhatSinhMaChiSoDN()
        {
            return chiSoDienNuocDAL.PhatSinhMaChiSoDN();
        }

        public bool suaDienNuoc(ChiSoDienNuocDTO dienNuoc)
        {
            return chiSoDienNuocDAL.suaDienNuoc(dienNuoc);
        }

        public bool xoaDienNuoc(ChiSoDienNuocDTO dienNuoc)
        {
            return chiSoDienNuocDAL.xoaDienNuoc(dienNuoc);
        }

        public List<ChiSoDienNuocDTO> TimKiemDienNuoc(string mapt)
        {
            return chiSoDienNuocDAL.TimKiemDienNuoc(mapt);
        }
    }
}
