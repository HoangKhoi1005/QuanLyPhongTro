using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DAL
{
    public class PhatSinhDAL
    {
        private QLPTDataContext ql = new QLPTDataContext();
        public List<PhatSinhDTO> loadPhatSinh()
        {
            var sql = from ps in ql.PHATSINHs
                      select new PhatSinhDTO
                      {
                          MaPS = ps.MAPHATSINH,
                          MaPT = ps.MAPT,
                          NgayThang = ps.NGAYTHANG,
                          SoTien =decimal.Parse(ps.SOTIEN.ToString()),
                          MoTa = ps.MOTA,
                          LoaiPS = ps.LOAIPHATSINH
                      };
            return sql.ToList();
        }

        public int PhatSinhMaPhatSinh()
        {
            int maPS = 0;
            try
            {
                var lastMaPS = (from ps in ql.PHATSINHs
                                orderby ps.MAPHATSINH descending
                                select ps.MAPHATSINH).FirstOrDefault();

                if (lastMaPS != null)
                {
                    maPS = lastMaPS + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi phát sinh mã phát sinh: " + ex.Message);
            }

            return maPS;
        }

        public bool themPhatSinh(PhatSinhDTO phatSinh)
        {
            try
            {
                PHATSINH ps = new PHATSINH();
                ps.MAPHATSINH = phatSinh.MaPS;
                ps.MAPT = phatSinh.MaPT;
                ps.NGAYTHANG = phatSinh.NgayThang;
                ps.SOTIEN = phatSinh.SoTien;
                ps.MOTA = phatSinh.MoTa;
                ps.LOAIPHATSINH = phatSinh.LoaiPS;

                ql.PHATSINHs.InsertOnSubmit(ps);
                ql.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool suaPhatSinh(PhatSinhDTO phatSinh)
        {
            try
            {
                int maPS = phatSinh.MaPS;
                PHATSINH ps = ql.PHATSINHs.Where(t => t.MAPHATSINH == maPS).FirstOrDefault();
                ps.MAPT = phatSinh.MaPT;
                ps.NGAYTHANG = phatSinh.NgayThang;
                ps.SOTIEN = phatSinh.SoTien;
                ps.MOTA = phatSinh.MoTa;
                ps.LOAIPHATSINH = phatSinh.LoaiPS;

                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool xoaPhatSinh(PhatSinhDTO phatSinh)
        {
            try
            {
                int maPS = phatSinh.MaPS;
                PHATSINH ps = ql.PHATSINHs.Where(t => t.MAPHATSINH == maPS).FirstOrDefault();
                ql.PHATSINHs.DeleteOnSubmit(ps);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
