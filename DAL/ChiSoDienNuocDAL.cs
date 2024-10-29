using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiSoDienNuocDAL
    {
        private QLPTDataContext ql = new QLPTDataContext();
        public List<ChiSoDienNuocDTO> loadDienNuoc()
        {
            var sql = from dn in ql.CHISODIENNUOCs
                      select new ChiSoDienNuocDTO
                      {
                          MaCS = dn.MACS,
                          MaPT = dn.MAPT,
                          NgayThang = dn.NGAYTHANG,
                          ChiSoDien = dn.CHISODIEN,
                          ChiSoNuoc = dn.CHISONUOC
                      };
            return sql.ToList();
        }

        public int PhatSinhMaChiSoDN()
        {
            int maCS = 1;
            try
            {
                var lastMaCS = (from dn in ql.CHISODIENNUOCs
                                orderby dn.MACS descending
                                select dn.MACS).FirstOrDefault();

                if (lastMaCS != null)
                {
                    maCS = lastMaCS + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi phát sinh mã dịch vụ: " + ex.Message);
            }

            return maCS;
        }

        public bool themDienNuoc(ChiSoDienNuocDTO dienNuoc)
        {
            try
            {
                CHISODIENNUOC dn = new CHISODIENNUOC();
                dn.MACS = dienNuoc.MaCS;
                dn.MAPT = dienNuoc.MaPT;
                dn.NGAYTHANG = dienNuoc.NgayThang;
                dn.CHISODIEN = dienNuoc.ChiSoDien;
                dn.CHISONUOC = dienNuoc.ChiSoNuoc;

                ql.CHISODIENNUOCs.InsertOnSubmit(dn);
                ql.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<string> loadMaPT()
        {
            var maPT = (from pt in ql.PHONGTROs
                        select pt.MAPT).ToList();
            return maPT;
        }

        public bool suaDienNuoc(ChiSoDienNuocDTO dienNuoc)
        {
            try
            {
                int maCS = dienNuoc.MaCS;
                CHISODIENNUOC dn = ql.CHISODIENNUOCs.Where(t => t.MACS == maCS).FirstOrDefault();
                dn.MAPT = dienNuoc.MaPT;
                dn.NGAYTHANG = dienNuoc.NgayThang;
                dn.CHISODIEN = dienNuoc.ChiSoDien;
                dn.CHISONUOC = dienNuoc.ChiSoNuoc;

                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool xoaDienNuoc(ChiSoDienNuocDTO dienNuoc)
        {
            try
            {
                int maCS = dienNuoc.MaCS;
                CHISODIENNUOC dn = ql.CHISODIENNUOCs.Where(t => t.MACS == maCS).FirstOrDefault();
                ql.CHISODIENNUOCs.DeleteOnSubmit(dn);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<ChiSoDienNuocDTO> TimKiemDienNuoc(string keyword)
        {
            try
            {
                var result = from dn in ql.CHISODIENNUOCs
                             where dn.MAPT.Contains(keyword) ||
                                   dn.MACS.ToString().Contains(keyword) ||
                                   dn.NGAYTHANG.ToString().Contains(keyword) ||
                                   dn.CHISODIEN.ToString().Contains(keyword) ||
                                   dn.CHISONUOC.ToString().Contains(keyword)
                             select new ChiSoDienNuocDTO
                             {
                                 MaCS = dn.MACS,
                                 MaPT = dn.MAPT,
                                 NgayThang = DateTime.Parse(dn.NGAYTHANG.ToString()),
                                 ChiSoDien = int.Parse(dn.CHISODIEN.ToString()),
                                 ChiSoNuoc = int.Parse(dn.CHISONUOC.ToString())
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<ChiSoDienNuocDTO>();
            }
        }
    }
}
