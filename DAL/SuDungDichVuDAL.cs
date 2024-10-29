using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class SuDungDichVuDAL
    {
        DBConnect db;

        public SuDungDichVuDAL()
        {
            db = new DBConnect();
        }

        public bool CapNhatSuDungDichVu(SuDungDichVuDTO suDungDichVu)
        {
            string sql = "UPDATE SUDUNGDV SET SOLUONG = '" + suDungDichVu.SoLuong +
                         "', NGAYKETTHUC = '" + suDungDichVu.NgayKetThuc +
                         "' WHERE MAPT = '" + suDungDichVu.MaPT +
                         "' AND MADV = '" + suDungDichVu.MaDV +
                         "' AND NGAYBATDAU = '" + suDungDichVu.NgayBatDau.ToString("yyyy-MM-dd") +
                         "' AND DAXOA = 0";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public DataTable LayDSSuDungDVDataGirdView(string maPT)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = "SELECT DV.MADV, DV.TENDV, DV.DONGIA, SD.SOLUONG, SD.NGAYBATDAU, SD.NGAYKETTHUC " +
                         "FROM SUDUNGDV AS SD JOIN DICHVU AS DV ON SD.MADV = DV.MADV " +
                         "WHERE SD.MAPT = '" + maPT + "' AND SD.NGAYKETTHUC >= '" + currentDate +
                         "' AND SD.DAXOA = 0";
            return db.GetDataTable(sql);
        }


        public bool themSuDungDichVu(SuDungDichVuDTO suDungDichVu)
        {
            string sql = "INSERT INTO SUDUNGDV (MAPT, MADV, SOLUONG, NGAYBATDAU, NGAYKETTHUC, DAXOA) " +
                         "VALUES('" + suDungDichVu.MaPT + "', '" + suDungDichVu.MaDV +
                         "', '" + suDungDichVu.SoLuong + "', '" + suDungDichVu.NgayBatDau.ToString("yyyy-MM-dd") +
                         "', '" + suDungDichVu.NgayKetThuc.ToString("yyyy-MM-dd") + "', 0)";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool XoaSuDungDichVu(string maPT, string maDV, DateTime ngayBatDau)
        {
            string sql = "UPDATE SUDUNGDV SET DAXOA = 1, NGAYKETTHUC = '" + DateTime.Now.ToString("yyyy-MM-dd") +
                         "' WHERE MAPT = '" + maPT + "' AND MADV = '" + maDV +
                         "' AND NGAYBATDAU = '" + ngayBatDau.ToString("yyyy-MM-dd") +
                         "' AND DAXOA = 0";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool KiemTraSuDungDichVuTonTai(string maPT, string maDV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string sql = "SELECT COUNT(*) FROM SUDUNGDV WHERE MAPT = '" + maPT +
                         "' AND MADV = '" + maDV + "' AND DAXOA = 0 " +
                         "AND ((NGAYBATDAU <= '" + ngayKetThuc.ToString("yyyy-MM-dd") +
                         "' AND (NGAYKETTHUC IS NULL OR NGAYKETTHUC >= '" + ngayBatDau.ToString("yyyy-MM-dd") + "')))";
            return (int)db.ExecuteScalar(sql) > 0;
        }
    }
}
