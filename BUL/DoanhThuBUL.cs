using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUL
{
    public class DoanhThuBUL
    {
        private DoanhThuDAL doanhThuDAL;

        public DoanhThuBUL()
        {
            doanhThuDAL = new DoanhThuDAL();
        }

        public DataTable LoadDoanhThu(DateTime ngay)
        {
            return doanhThuDAL.LoadDoanhThu(ngay);
        }

        public object TongTienTrongThang(DateTime value)
        {
            return doanhThuDAL.TongTienTrongThang(value);
        }

        public List<DoanhThuDTO> LayDoanhThuTheoThang()
        {
            return doanhThuDAL.LayDoanhThuTheoThang();
        }

        public List<DoanhThuDTO> LayDoanhThuTheoNam()
        {
            return doanhThuDAL.LayDoanhThuTheoNam();
        }

        public List<DoanhThuDTO> LayDoanhThuTheoNhaTro()
        {
            return doanhThuDAL.LayDoanhThuTheoNhaTro();
        }

        public List<string> LayDanhSachNhaTro()
        {
            return doanhThuDAL.LayDanhSachNhaTro();
        }
    }
}
