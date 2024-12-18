using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        DBConnect db;

        public HoaDonDAL()
        {
            db = new DBConnect();
        }

        public bool ThemHoaDon(HoaDonDTO hoaDonDTO)
        {
            string sql = "INSERT INTO HOADON VALUES('" + hoaDonDTO.MaHD + "', '" + hoaDonDTO.MaPT + "', '" + hoaDonDTO.MaQL + "', '" + hoaDonDTO.NgayLap + "', '" + hoaDonDTO.NgayThanhToan + "', " + hoaDonDTO.TongTien + ", " + hoaDonDTO.TienDaThanhToan + ", N'" + hoaDonDTO.MoTa + "', '" + hoaDonDTO.DaXoa + "')";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public string PhatSinhMaHoaDon()
        {
            string sql = "SELECT COUNT(*) FROM HOADON WHERE MaHD LIKE 'HDON" + DateTime.Now.ToString("yyyyMMdd") + "%'";
            int count = (int)db.ExecuteScalar(sql);
            return "HDON" + DateTime.Now.ToString("yyyyMMdd") + (count + 1).ToString("000");
        }

        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            string sql = "SELECT * FROM HOADON WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE()) AND DAXOA = 0";
            var reader = db.ExecuteQuery(sql);
            var danhSachHoaDon = new List<HoaDonDTO>();

            while (reader.Read())
            {
                var hoaDon = new HoaDonDTO
                {
                    MaHD = reader["MaHD"].ToString(),
                    MaPT = reader["MaPT"].ToString(),
                    MaQL = reader["MaQL"].ToString(),
                    NgayLap = DateTime.Parse(reader["NgayLap"].ToString()),
                    NgayThanhToan = DateTime.Parse(reader["NgayThanhToan"].ToString()),
                    TongTien = decimal.Parse(reader["TongTien"].ToString()),
                    TienDaThanhToan = decimal.Parse(reader["TienDaThanhToan"].ToString()),
                    MoTa = reader["MoTa"].ToString(),
                    DaXoa = bool.Parse(reader["DaXoa"].ToString())
                };
                danhSachHoaDon.Add(hoaDon);
            }

            reader.Close();
            return danhSachHoaDon;
        }



        public decimal TinhTienHoaDon(DateTime ngay, string maPT)
        {
            decimal tongTien = 0;

            string sqlPhongTro = "SELECT DONGIA  FROM PHONGTRO WHERE MAPT = '" + maPT + "'";
            object resultPhongTro = db.ExecuteScalar(sqlPhongTro);
            decimal donGiaPhong = resultPhongTro != null && resultPhongTro != DBNull.Value ? Convert.ToDecimal(resultPhongTro) : 0;


            string ngayStr = ngay.ToString("yyyy-MM-dd");

            // Xác định ngày đầu và cuối tháng
            DateTime firstDayOfMonth = new DateTime(ngay.Year, ngay.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            int totalDaysInMonth = DateTime.DaysInMonth(ngay.Year, ngay.Month);

            string firstDayOfMonthStr = firstDayOfMonth.ToString("yyyy-MM-dd");
            string lastDayOfMonthStr = lastDayOfMonth.ToString("yyyy-MM-dd");

            string sqlDichVu = $@"
                    SELECT 
                        SUM(
                            CASE 
                                WHEN SD.NGAYBATDAU <= '{lastDayOfMonthStr}' 
                                     AND (SD.NGAYKETTHUC IS NULL OR SD.NGAYKETTHUC >= '{firstDayOfMonthStr}')
                                THEN (DV.DONGIA / {totalDaysInMonth}) * SD.SOLUONG * 
                                     (DATEDIFF(DAY, 
                                               CASE WHEN SD.NGAYBATDAU < '{firstDayOfMonthStr}' THEN '{firstDayOfMonthStr}' ELSE SD.NGAYBATDAU END, 
                                               CASE WHEN SD.NGAYKETTHUC IS NULL OR SD.NGAYKETTHUC > '{lastDayOfMonthStr}' THEN '{lastDayOfMonthStr}' ELSE SD.NGAYKETTHUC END) + 1)
                                ELSE 0 
                            END
                        ) AS TongTienDichVu
                    FROM SUDUNGDV SD
                    JOIN DICHVU DV ON SD.MADV = DV.MADV
                    WHERE SD.MAPT = '{maPT}'
                      AND SD.DAXOA = 0 
                      AND DV.TENDV NOT LIKE N'%Điện%' 
                      AND DV.TENDV NOT LIKE N'%Nước%'";

            Console.WriteLine(sqlDichVu);

            object resultDichVu = db.ExecuteScalar(sqlDichVu);
            decimal tongTienDichVu = resultDichVu != null && resultDichVu != DBNull.Value ? Convert.ToDecimal(resultDichVu) : 0;

            string sqlDien = @"
                        DECLARE @donGiaDien MONEY;
                        DECLARE @chiSoDienMax INT, @chiSoDienMin INT;

                        -- Lấy đơn giá điện cho mã phòng cụ thể
                        SELECT @donGiaDien = DONGIA
                        FROM DICHVU DV
                        INNER JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                        WHERE SD.MAPT = '" + maPT + @"' AND DV.TENDV LIKE N'%điện%' AND SD.NGAYKETTHUC >= '" + ngayStr + @"';

                        -- Lấy chỉ số điện cao nhất trong tháng hiện tại
                        SELECT TOP 1 @chiSoDienMax = CHISODIEN
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND MONTH(NGAYTHANG) = MONTH(GETDATE()) 
                          AND YEAR(NGAYTHANG) = YEAR(GETDATE())
                        ORDER BY NGAYTHANG DESC;

                        -- Lấy chỉ số điện gần nhất trước đó
                        SELECT TOP 1 @chiSoDienMin = CHISODIEN
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND NGAYTHANG < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
                        ORDER BY NGAYTHANG DESC;

                        -- Tính tiền điện
                        SELECT (@chiSoDienMax - @chiSoDienMin) * ISNULL(@donGiaDien, 0) AS TienDien;
                    ";



            object resultDien = db.ExecuteScalar(sqlDien);
            decimal tongTienDien = resultDien != null && resultDien != DBNull.Value ? Convert.ToDecimal(resultDien) : 0;

            string sqlNuoc = @"
                        DECLARE @donGiaNuoc MONEY;
                        DECLARE @chiSoNuocMax INT, @chiSoNuocMin INT;

                        -- Lấy đơn giá nước cho mã phòng cụ thể
                        SELECT @donGiaNuoc = DONGIA
                        FROM DICHVU DV
                        INNER JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                        WHERE SD.MAPT = '" + maPT + @"' AND DV.TENDV LIKE N'%nước%' AND SD.NGAYKETTHUC >= '" + ngayStr + @"';

                        -- Lấy chỉ số nước cao nhất trong tháng hiện tại
                        SELECT TOP 1 @chiSoNuocMax = CHISONUOC
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND MONTH(NGAYTHANG) = MONTH(GETDATE()) 
                          AND YEAR(NGAYTHANG) = YEAR(GETDATE())
                        ORDER BY NGAYTHANG DESC;

                        -- Lấy chỉ số nước gần nhất trước đó
                        SELECT TOP 1 @chiSoNuocMin = CHISONUOC
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND NGAYTHANG < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
                        ORDER BY NGAYTHANG DESC;

                        -- Tính tiền nước
                        SELECT (@chiSoNuocMax - @chiSoNuocMin) * ISNULL(@donGiaNuoc, 0) AS TienNuoc;
                    ";


            object resultNuoc = db.ExecuteScalar(sqlNuoc);
            decimal tongTienNuoc = resultNuoc != null && resultNuoc != DBNull.Value ? Convert.ToDecimal(resultNuoc) : 0;

            string sqlPhatSinh = "SELECT SUM(SoTien) FROM PHATSINH " +
                     "WHERE MONTH(NGAYTHANG) = MONTH('" + ngayStr + "') " +
                     "AND YEAR(NGAYTHANG) = YEAR('" + ngayStr + "') " +
                     "AND MaPT = '" + maPT + "'";


            object resultPhatSinh = db.ExecuteScalar(sqlPhatSinh);
            decimal tongTienPhatSinh = resultPhatSinh != null && resultPhatSinh != DBNull.Value ? Convert.ToDecimal(resultPhatSinh) : 0;

            tongTien = donGiaPhong + tongTienDichVu + tongTienDien + tongTienNuoc + tongTienPhatSinh;

            return tongTien;
        }

        public object LayDanhSachHoaDonTheoThang(DateTime value, string trangThaiThanhToan)
        {
            string sql = "SELECT * FROM HOADON WHERE MONTH(NgayThanhToan) = " + value.Month +
                         " AND DAXOA = 0 AND YEAR(NgayThanhToan) = " + value.Year;

            if (trangThaiThanhToan == "Đã thanh toán")
            {
                sql += " AND TienDaThanhToan >= TongTien";
            }
            else if (trangThaiThanhToan == "Chưa thanh toán")
            {
                sql += " AND TienDaThanhToan < TongTien";
            }

            var reader = db.ExecuteQuery(sql);
            var danhSachHoaDon = new List<HoaDonDTO>();
            while (reader.Read())
            {
                var hoaDon = new HoaDonDTO
                {
                    MaHD = reader["MaHD"].ToString(),
                    MaPT = reader["MaPT"].ToString(),
                    MaQL = reader["MaQL"].ToString(),
                    NgayLap = DateTime.Parse(reader["NgayLap"].ToString()),
                    NgayThanhToan = DateTime.Parse(reader["NgayThanhToan"].ToString()),
                    TongTien = decimal.Parse(reader["TongTien"].ToString()),
                    TienDaThanhToan = decimal.Parse(reader["TienDaThanhToan"].ToString()),
                    MoTa = reader["MoTa"].ToString(),
                    DaXoa = bool.Parse(reader["DaXoa"].ToString())
                };
                danhSachHoaDon.Add(hoaDon);
            }
            reader.Close();
            return danhSachHoaDon;
        }

        public object LayDanhSachHoaDonTheoThangVaNT(DateTime value, string maNT, string trangThaiThanhToan)
        {
            string sql = "SELECT HD.* FROM HOADON HD JOIN PHONGTRO PT ON HD.MaPT = PT.MaPT " +
                         "WHERE MONTH(HD.NgayThanhToan) = " + value.Month +
                         " AND YEAR(HD.NgayThanhToan) = " + value.Year +
                         "AND HD.DAXOA = 0 AND PT.MaNT = '" + maNT + "'";

            if (trangThaiThanhToan == "Đã thanh toán")
            {
                sql += " AND HD.TienDaThanhToan >= HD.TongTien";
            }
            else if (trangThaiThanhToan == "Chưa thanh toán")
            {
                sql += " AND HD.TienDaThanhToan < HD.TongTien";
            }

            var reader = db.ExecuteQuery(sql);
            var danhSachHoaDon = new List<HoaDonDTO>();
            while (reader.Read())
            {
                var hoaDon = new HoaDonDTO
                {
                    MaHD = reader["MaHD"].ToString(),
                    MaPT = reader["MaPT"].ToString(),
                    MaQL = reader["MaQL"].ToString(),
                    NgayLap = DateTime.Parse(reader["NgayLap"].ToString()),
                    NgayThanhToan = DateTime.Parse(reader["NgayThanhToan"].ToString()),
                    TongTien = decimal.Parse(reader["TongTien"].ToString()),
                    TienDaThanhToan = decimal.Parse(reader["TienDaThanhToan"].ToString()),
                    MoTa = reader["MoTa"].ToString(),
                    DaXoa = bool.Parse(reader["DaXoa"].ToString())
                };
                danhSachHoaDon.Add(hoaDon);
            }
            reader.Close();
            return danhSachHoaDon;
        }

        public bool KiemTraHoaDonThang(DateTime thangNam, string maPT)
        {
            string sql = "SELECT COUNT(*) FROM HOADON WHERE MaPT = '"+maPT+"' AND MONTH(NgayLap) = '"+ thangNam.Month + "' AND YEAR(NgayLap) = '"+ thangNam.Year + "' AND DaXoa = 0";
            return (int)db.ExecuteScalar(sql) > 0;
        }

        public bool KiemTraChiSoDienNuoc(DateTime thangNam, string maPT)
        {
            string sql = "SELECT COUNT(*) FROM CHISODIENNUOC WHERE MAPT = '" + maPT + "' AND MONTH(NGAYTHANG) = " + thangNam.Month + " AND YEAR(NGAYTHANG) = " + thangNam.Year;
            return (int)db.ExecuteScalar(sql) > 0;
        }

        public object LayDanhSachHoaDonTheoMaPhongVaThang(string maPT, DateTime value, string trangThaiThanhToan)
        {
            string sql = "SELECT * FROM HOADON WHERE MaPT LIKE '%" + maPT + "%'" +
                         " AND MONTH(NgayThanhToan) = " + value.Month +
                         "AND DAXOA = 0 AND YEAR(NgayThanhToan) = " + value.Year;

            if (trangThaiThanhToan == "Đã thanh toán")
            {
                sql += " AND TienDaThanhToan >= TongTien";
            }
            else if (trangThaiThanhToan == "Chưa thanh toán")
            {
                sql += " AND TienDaThanhToan < TongTien";
            }

            var reader = db.ExecuteQuery(sql);
            var danhSachHoaDon = new List<HoaDonDTO>();
            while (reader.Read())
            {
                var hoaDon = new HoaDonDTO
                {
                    MaHD = reader["MaHD"].ToString(),
                    MaPT = reader["MaPT"].ToString(),
                    MaQL = reader["MaQL"].ToString(),
                    NgayLap = DateTime.Parse(reader["NgayLap"].ToString()),
                    NgayThanhToan = DateTime.Parse(reader["NgayThanhToan"].ToString()),
                    TongTien = decimal.Parse(reader["TongTien"].ToString()),
                    TienDaThanhToan = decimal.Parse(reader["TienDaThanhToan"].ToString()),
                    MoTa = reader["MoTa"].ToString(),
                    DaXoa = bool.Parse(reader["DaXoa"].ToString())
                };
                danhSachHoaDon.Add(hoaDon);
            }
            reader.Close();
            return danhSachHoaDon;
        }

        public void ThuTien(string maHD, decimal soTienThu)
        {
            string sql = "UPDATE HOADON SET TienDaThanhToan = TienDaThanhToan + " + soTienThu + " WHERE MaHD = '" + maHD + "'";
            db.ExecuteNonQuery(sql);
        }

        public DataTable LayHoaDonTheoMaHD(string maHD)
        {
            string sql = "SELECT NHATRO.TENNT, NHATRO.DIACHINT, NHATRO.SODT, HOADON.NGAYLAP, HOADON.MAHD, PHONGTRO.MAPT, PHONGTRO.TENPHONG, PHONGTRO.DONGIA, HOADON.TONGTIEN, QUANLY.HOTENNV " +
                         "FROM ((HOADON INNER JOIN PHONGTRO ON HOADON.MAPT = PHONGTRO.MAPT) INNER JOIN QUANLY ON HOADON.MAQL = QUANLY.MAQL) INNER JOIN NHATRO ON PHONGTRO.MANT = NHATRO.MANT " +
                         "WHERE HOADON.MAHD = '" + maHD + "'";

            return db.GetDataTable(sql);
        }

        public decimal TinhTienHoaDonKhiTraPhong(DateTime ngay, string maPT)
        {
            decimal tongTien = 0;
            string ngayStr = ngay.ToString("yyyy-MM-dd");
            DateTime firstDayOfMonth = new DateTime(ngay.Year, ngay.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            int totalDaysInMonth = DateTime.DaysInMonth(ngay.Year, ngay.Month);

            string sqlPhongTro = $"SELECT DONGIA FROM PHONGTRO WHERE MAPT = '{maPT}'";
            object resultPhongTro = db.ExecuteScalar(sqlPhongTro);
            decimal donGiaPhong = resultPhongTro != null && resultPhongTro != DBNull.Value ? Convert.ToDecimal(resultPhongTro) : 0;

            decimal proratedRent = donGiaPhong;
            string sqlDaysOccupied = $@"
        SELECT DATEDIFF(DAY, 
                CASE WHEN NGAYLAP < '{firstDayOfMonth:yyyy-MM-dd}' THEN '{firstDayOfMonth:yyyy-MM-dd}' ELSE NGAYLAP END,
                '{ngay:yyyy-MM-dd}') + 1
        FROM HOPDONG
        WHERE MAPT = '{maPT}' AND NGAYLAP <= '{lastDayOfMonth:yyyy-MM-dd}' ";

            object resultDaysOccupied = db.ExecuteScalar(sqlDaysOccupied);
            int daysOccupied = resultDaysOccupied != null && resultDaysOccupied != DBNull.Value ? Convert.ToInt32(resultDaysOccupied) : totalDaysInMonth;
            proratedRent = (donGiaPhong / totalDaysInMonth) * daysOccupied;

            string firstDayOfMonthStr = firstDayOfMonth.ToString("yyyy-MM-dd");
            string lastDayOfMonthStr = lastDayOfMonth.ToString("yyyy-MM-dd");

            string sqlDichVu = $@"
                    SELECT 
                        SUM(
                            CASE 
                                WHEN SD.NGAYBATDAU <= '{lastDayOfMonthStr}' 
                                     AND (SD.NGAYKETTHUC IS NULL OR SD.NGAYKETTHUC >= '{firstDayOfMonthStr}')
                                THEN (DV.DONGIA / {totalDaysInMonth}) * SD.SOLUONG * 
                                     (DATEDIFF(DAY, 
                                               CASE WHEN SD.NGAYBATDAU < '{firstDayOfMonthStr}' THEN '{firstDayOfMonthStr}' ELSE SD.NGAYBATDAU END, 
                                               CASE WHEN SD.NGAYKETTHUC IS NULL OR SD.NGAYKETTHUC > '{lastDayOfMonthStr}' THEN '{lastDayOfMonthStr}' ELSE SD.NGAYKETTHUC END) + 1)
                                ELSE 0 
                            END
                        ) AS TongTienDichVu
                    FROM SUDUNGDV SD
                    JOIN DICHVU DV ON SD.MADV = DV.MADV
                    WHERE SD.MAPT = '{maPT}'
                      AND SD.DAXOA = 0 
                      AND DV.TENDV NOT LIKE N'%Điện%' 
                      AND DV.TENDV NOT LIKE N'%Nước%'";

            Console.WriteLine(sqlDichVu);
            object resultDichVu = db.ExecuteScalar(sqlDichVu);
            decimal tongTienDichVu = resultDichVu != null && resultDichVu != DBNull.Value ? Convert.ToDecimal(resultDichVu) : 0;

            string sqlDien = @"
                        DECLARE @donGiaDien MONEY;
                        DECLARE @chiSoDienMax INT, @chiSoDienMin INT;

                        -- Lấy đơn giá điện cho mã phòng cụ thể
                        SELECT @donGiaDien = DONGIA
                        FROM DICHVU DV
                        INNER JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                        WHERE SD.MAPT = '" + maPT + @"' AND DV.TENDV LIKE N'%điện%' AND SD.NGAYKETTHUC >= '" + ngayStr + @"';

                        -- Lấy chỉ số điện cao nhất trong tháng hiện tại
                        SELECT TOP 1 @chiSoDienMax = CHISODIEN
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND MONTH(NGAYTHANG) = MONTH(GETDATE()) 
                          AND YEAR(NGAYTHANG) = YEAR(GETDATE())
                        ORDER BY NGAYTHANG DESC;

                        -- Lấy chỉ số điện gần nhất trước đó
                        SELECT TOP 1 @chiSoDienMin = CHISODIEN
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND NGAYTHANG < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
                        ORDER BY NGAYTHANG DESC;

                        -- Tính tiền điện
                        SELECT (@chiSoDienMax - @chiSoDienMin) * ISNULL(@donGiaDien, 0) AS TienDien;
                    ";

            object resultDien = db.ExecuteScalar(sqlDien);
            decimal tongTienDien = resultDien != null && resultDien != DBNull.Value ? Convert.ToDecimal(resultDien) : 0;

            string sqlNuoc = @"
                        DECLARE @donGiaNuoc MONEY;
                        DECLARE @chiSoNuocMax INT, @chiSoNuocMin INT;

                        -- Lấy đơn giá nước cho mã phòng cụ thể
                        SELECT @donGiaNuoc = DONGIA
                        FROM DICHVU DV
                        INNER JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                        WHERE SD.MAPT = '" + maPT + @"' AND DV.TENDV LIKE N'%nước%' AND SD.NGAYKETTHUC >= '" + ngayStr + @"';

                        -- Lấy chỉ số nước cao nhất trong tháng hiện tại
                        SELECT TOP 1 @chiSoNuocMax = CHISONUOC
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND MONTH(NGAYTHANG) = MONTH(GETDATE()) 
                          AND YEAR(NGAYTHANG) = YEAR(GETDATE())
                        ORDER BY NGAYTHANG DESC;

                        -- Lấy chỉ số nước gần nhất trước đó
                        SELECT TOP 1 @chiSoNuocMin = CHISONUOC
                        FROM CHISODIENNUOC
                        WHERE MAPT = '" + maPT + @"' 
                          AND NGAYTHANG < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
                        ORDER BY NGAYTHANG DESC;

                        -- Tính tiền nước
                        SELECT (@chiSoNuocMax - @chiSoNuocMin) * ISNULL(@donGiaNuoc, 0) AS TienNuoc;
                    ";

            object resultNuoc = db.ExecuteScalar(sqlNuoc);
            decimal tongTienNuoc = resultNuoc != null && resultNuoc != DBNull.Value ? Convert.ToDecimal(resultNuoc) : 0;

            string sqlPhatSinh = $@"
        SELECT SUM(SoTien)
        FROM PHATSINH
        WHERE MaPT = '{maPT}' AND NGAYTHANG BETWEEN '{firstDayOfMonth:yyyy-MM-dd}' AND '{lastDayOfMonth:yyyy-MM-dd}'
    ";

            object resultPhatSinh = db.ExecuteScalar(sqlPhatSinh);
            decimal tongTienPhatSinh = resultPhatSinh != null && resultPhatSinh != DBNull.Value ? Convert.ToDecimal(resultPhatSinh) : 0;

            tongTien = proratedRent + tongTienDichVu + tongTienDien + tongTienNuoc + tongTienPhatSinh;

            return tongTien;
        }

        public decimal TongTienTrongThang(DateTime value)
        {
            string sql = "SELECT ISNULL(SUM(TongTien), 0) FROM HOADON WHERE MONTH(NgayThanhToan) = " + value.Month + " AND YEAR(NgayThanhToan) = " + value.Year;
            return Convert.ToDecimal(db.ExecuteScalar(sql));
        }

        public bool XoaHoaDon(string maHD)
        {
            string sql = "UPDATE HOADON SET DaXoa = 1 WHERE MaHD = '" + maHD + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }
    }
}
