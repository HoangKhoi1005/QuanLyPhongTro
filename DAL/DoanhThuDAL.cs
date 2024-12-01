using DTO;
using SQLServerProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DoanhThuDAL
    {

        private DBConnect db;

        public DoanhThuDAL()
        {
            db = new DBConnect();
        }

        public DataTable LoadDoanhThu(DateTime ngay)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MaPhong", typeof(string));
            dataTable.Columns.Add("GiaPhong", typeof(decimal));
            dataTable.Columns.Add("ProratedRent", typeof(decimal));
            dataTable.Columns.Add("TienDien", typeof(decimal));
            dataTable.Columns.Add("TienNuoc", typeof(decimal));
            dataTable.Columns.Add("TienDichVu", typeof(decimal));
            dataTable.Columns.Add("PhatSinh", typeof(decimal));
            dataTable.Columns.Add("TongTien", typeof(decimal));

            DateTime firstDayOfMonth = new DateTime(ngay.Year, ngay.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            int totalDaysInMonth = DateTime.DaysInMonth(ngay.Year, ngay.Month);

            string sqlRooms = "SELECT MAPT, DONGIA FROM PHONGTRO ";
            DataTable rooms = db.GetDataTable(sqlRooms);

            foreach (DataRow room in rooms.Rows)
            {
                string maPT = room["MAPT"].ToString();
                decimal donGiaPhong = room["DONGIA"] != DBNull.Value ? Convert.ToDecimal(room["DONGIA"]) : 0;

                string sqlCheckInvoice = $@"
            SELECT COUNT(*) 
            FROM HOADON
            WHERE MAPT = '{maPT}' 
            AND NGAYLAP BETWEEN '{firstDayOfMonth:yyyy-MM-dd}' AND '{lastDayOfMonth:yyyy-MM-dd}'
            AND DAXOA = 0";
                int invoiceCount = Convert.ToInt32(db.ExecuteScalar(sqlCheckInvoice));

                if (invoiceCount == 0)
                {
                    dataTable.Rows.Add(maPT, donGiaPhong, 0, 0, 0, 0, 0, 0);
                    continue; 
                }

                string sqlDaysOccupied = $@"
                SELECT DATEDIFF(DAY, 
                        CASE WHEN NGAYLAP < '{firstDayOfMonth:yyyy-MM-dd}' THEN '{firstDayOfMonth:yyyy-MM-dd}' ELSE NGAYLAP END,
                        '{ngay:yyyy-MM-dd}') + 1
                FROM HOPDONG
                WHERE MAPT = '{maPT}' AND NGAYLAP <= '{lastDayOfMonth:yyyy-MM-dd}'";
                object resultDaysOccupied = db.ExecuteScalar(sqlDaysOccupied);
                int daysOccupied = resultDaysOccupied != null && resultDaysOccupied != DBNull.Value ? Convert.ToInt32(resultDaysOccupied) : totalDaysInMonth;
                decimal proratedRent = (donGiaPhong / totalDaysInMonth) * daysOccupied;

                string sqlDichVu = $@"
                SELECT 
                    SUM(
                        CASE 
                            WHEN SD.NGAYBATDAU <= '{lastDayOfMonth:yyyy-MM-dd}' 
                                 AND (SD.NGAYKETTHUC IS NULL OR SD.NGAYKETTHUC >= '{firstDayOfMonth:yyyy-MM-dd}')
                            THEN (DV.DONGIA / {totalDaysInMonth}) * SD.SOLUONG * 
                                 (DATEDIFF(DAY, 
                                           CASE WHEN SD.NGAYBATDAU < '{firstDayOfMonth:yyyy-MM-dd}' THEN '{firstDayOfMonth:yyyy-MM-dd}' ELSE SD.NGAYBATDAU END, 
                                           CASE WHEN SD.NGAYKETTHUC IS NULL OR SD.NGAYKETTHUC > '{lastDayOfMonth:yyyy-MM-dd}' THEN '{lastDayOfMonth:yyyy-MM-dd}' ELSE SD.NGAYKETTHUC END) + 1)
                            ELSE 0 
                        END
                    ) AS TongTienDichVu
FROM SUDUNGDV SD
                JOIN DICHVU DV ON SD.MADV = DV.MADV
                WHERE SD.MAPT = '{maPT}'
                  AND SD.DAXOA = 0 
                  AND DV.TENDV NOT LIKE N'%Điện%' 
                  AND DV.TENDV NOT LIKE N'%Nước%'";
                object resultDichVu = db.ExecuteScalar(sqlDichVu);
                decimal tongTienDichVu = resultDichVu != null && resultDichVu != DBNull.Value ? Convert.ToDecimal(resultDichVu) : 0;

                string sqlDien = $@"
                DECLARE @donGiaDien MONEY, @chiSoDienMax INT, @chiSoDienMin INT;
                SELECT @donGiaDien = DONGIA
                FROM DICHVU DV
                JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                WHERE SD.MAPT = '{maPT}' AND DV.TENDV LIKE N'%Điện%';

                SELECT TOP 1 @chiSoDienMax = CHISODIEN
                FROM CHISODIENNUOC
                WHERE MAPT = '{maPT}' AND NGAYTHANG BETWEEN '{firstDayOfMonth:yyyy-MM-dd}' AND '{lastDayOfMonth:yyyy-MM-dd}'
                ORDER BY NGAYTHANG DESC;

                SELECT @chiSoDienMin = CHISODIEN
                FROM CHISODIENNUOC
                WHERE MAPT = '{maPT}' 
                AND NGAYTHANG < '{firstDayOfMonth:yyyy-MM-dd}'
                ORDER BY NGAYTHANG DESC;

                SELECT (@chiSoDienMax - @chiSoDienMin) * ISNULL(@donGiaDien, 0) AS TienDien;";
                object resultDien = db.ExecuteScalar(sqlDien);
                decimal tongTienDien = resultDien != null && resultDien != DBNull.Value ? Convert.ToDecimal(resultDien) : 0;

                string sqlNuoc = $@"
                DECLARE @donGiaNuoc MONEY, @chiSoNuocMax INT, @chiSoNuocMin INT;
                SELECT @donGiaNuoc = DONGIA
                FROM DICHVU DV
                JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                WHERE SD.MAPT = '{maPT}' AND DV.TENDV LIKE N'%Nước%';

                SELECT TOP 1 @chiSoNuocMax = CHISONUOC
                FROM CHISODIENNUOC
                WHERE MAPT = '{maPT}' AND NGAYTHANG BETWEEN '{firstDayOfMonth:yyyy-MM-dd}' AND '{lastDayOfMonth:yyyy-MM-dd}'
                ORDER BY NGAYTHANG DESC;

                SELECT @chiSoNuocMin = CHISONUOC
                FROM CHISODIENNUOC
                WHERE MAPT = '{maPT}' 
                AND NGAYTHANG < '{firstDayOfMonth:yyyy-MM-dd}'
                ORDER BY NGAYTHANG DESC;

                SELECT (@chiSoNuocMax - @chiSoNuocMin) * ISNULL(@donGiaNuoc, 0) AS TienNuoc;";
                object resultNuoc = db.ExecuteScalar(sqlNuoc);
                decimal tongTienNuoc = resultNuoc != null && resultNuoc != DBNull.Value ? Convert.ToDecimal(resultNuoc) : 0;

                string sqlPhatSinh = $@"
                SELECT SUM(SoTien)
                FROM PHATSINH
                WHERE MaPT = '{maPT}' AND NGAYTHANG BETWEEN '{firstDayOfMonth:yyyy-MM-dd}' AND '{lastDayOfMonth:yyyy-MM-dd}'";
                object resultPhatSinh = db.ExecuteScalar(sqlPhatSinh);
                decimal tongTienPhatSinh = resultPhatSinh != null && resultPhatSinh != DBNull.Value ? Convert.ToDecimal(resultPhatSinh) : 0;

                decimal tongTien = proratedRent + tongTienDichVu + tongTienDien + tongTienNuoc + tongTienPhatSinh;

                dataTable.Rows.Add(maPT, donGiaPhong, proratedRent, tongTienDien, tongTienNuoc, tongTienDichVu, tongTienPhatSinh, tongTien);
            }

            return dataTable;
        }

        public object TongTienTrongThang(DateTime value)
        {
            DateTime firstDayOfMonth = new DateTime(value.Year, value.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            string sql = $@"
            SELECT SUM(TongTien)
            FROM (
                SELECT 
                    SUM(ProratedRent + TienDien + TienNuoc + TienDichVu + PhatSinh) AS TongTien
                FROM HOADON
                WHERE NGAYLAP BETWEEN '{firstDayOfMonth:yyyy-MM-dd}' AND '{lastDayOfMonth:yyyy-MM-dd}'
                GROUP BY MAPT
            ) AS T";
            object result = db.ExecuteScalar(sql);
            return result != null && result != DBNull.Value ? result : 0;
        }
    }
}
