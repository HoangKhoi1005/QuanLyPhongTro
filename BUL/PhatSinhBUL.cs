using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhatSinhBUL
    {
        PhatSinhDAL phatSinhDAL;
        public PhatSinhBUL()
        {
            phatSinhDAL = new PhatSinhDAL();
        }

        public List<PhatSinhDTO> loadPhatSinh()
        {
            return phatSinhDAL.loadPhatSinh();
        }

        public int PhatSinhMaPhatSinh()
        {
            return phatSinhDAL.PhatSinhMaPhatSinh();
        }

        public bool themPhatSinh(PhatSinhDTO phatSinh)
        {
            return phatSinhDAL.themPhatSinh(phatSinh);
        }

        public bool suaPhatSinh(PhatSinhDTO phatSinh)
        {
            return phatSinhDAL.suaPhatSinh(phatSinh);
        }

        public bool xoaPhatSinh(PhatSinhDTO phatSinh)
        {
            return phatSinhDAL.xoaPhatSinh(phatSinh);
        }
    }
}
