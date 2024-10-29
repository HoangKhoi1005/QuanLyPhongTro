using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DAL
{

    public class DichVuDAL
    {
        private QLPTDataContext ql = new QLPTDataContext();
        public List<DichVuDTO> loadDichVu()
        {
            var sql = from dv in ql.DICHVUs
                      select new DichVuDTO
                      {
                          MaDV = dv.MADV,
                          TenDV = dv.TENDV,
                          DonGia = decimal.Parse(dv.DONGIA.ToString()),
                          MoTa = dv.MOTA
                      };
            return sql.ToList();
        }

        public string PhatSinhMaDichVu()
        {
            string maDV = "DV001";
            try
            {
                var lastMaDV = (from dv in ql.DICHVUs
                                orderby dv.MADV descending
                                select dv.MADV).FirstOrDefault();

                if (lastMaDV != null)
                {
                    int thuTu = int.Parse(lastMaDV.Substring(2)) + 1;
                    maDV = "DV" + thuTu.ToString("000");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi phát sinh mã dịch vụ: " + ex.Message);
            }

            return maDV;
        }

        public bool themDichVu(DichVuDTO dichvu)
        {
            try
            {
                DICHVU dv = new DICHVU();
                dv.MADV = dichvu.MaDV;
                dv.TENDV = dichvu.TenDV;
                dv.DONGIA = dichvu.DonGia;
                dv.MOTA = dichvu.MoTa;
                dv.DAXOA = dichvu.DaXoa;

                ql.DICHVUs.InsertOnSubmit(dv);
                ql.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool suaDichVu(DichVuDTO dichvu)
        {
            try
            {
                string madv = dichvu.MaDV;
                DICHVU dv = ql.DICHVUs.Where(t => t.MADV == dichvu.MaDV).FirstOrDefault();
                dv.TENDV = dichvu.TenDV;
                dv.DONGIA = dichvu.DonGia;
                dv.MOTA = dichvu.MoTa;
                dv.DAXOA = dichvu.DaXoa;

                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool xoaDichVu(DichVuDTO dichvu)
        {
            try
            {
                string madv = dichvu.MaDV;
                DICHVU dv = ql.DICHVUs.Where(t => t.MADV == dichvu.MaDV).FirstOrDefault();
                ql.DICHVUs.DeleteOnSubmit(dv);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<DichVuDTO> TimKiemDichVu(string tendv )
        {
            try
            {
                var result = from dv in ql.DICHVUs
                             where dv.TENDV.Contains(tendv) && dv.DAXOA == false
                             select new DichVuDTO
                             {
                                 MaDV = dv.MADV,
                                 TenDV = dv.TENDV,
                                 DonGia = decimal.Parse(dv.DONGIA.ToString()),
                                 MoTa = dv.MOTA
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<DichVuDTO>(); 
            }
        }

    }
}
