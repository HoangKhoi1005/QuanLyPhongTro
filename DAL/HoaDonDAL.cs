using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
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
            string sql = "SELECT * FROM HOADON WHERE DAXOA = 0";
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

            string sqlDichVu = " SELECT SUM(DV.DONGIA * SD.SOLUONG) " +
                "FROM SUDUNGDV SD " +
                "JOIN DICHVU DV ON SD.MADV = DV.MADV " +
                "WHERE SD.NGAYKETTHUC >= '" + ngayStr + "' " +
                "AND SD.MAPT = '" + maPT + "' " +
                "AND DV.TENDV NOT LIKE N'%Điện%' " +
                "AND DV.TENDV NOT LIKE N'%Nước%'";

            
            object resultDichVu = db.ExecuteScalar(sqlDichVu);
            decimal tongTienDichVu = resultDichVu != null && resultDichVu != DBNull.Value ? Convert.ToDecimal(resultDichVu) : 0;

            string sqlDien = @"
                DECLARE @chiSoDienThangTruoc INT, @chiSoDienThangHienTai INT;
                DECLARE @donGiaDien MONEY;

                SELECT @donGiaDien = DONGIA
                FROM DICHVU DV
                INNER JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                WHERE SD.MAPT = '" + maPT + @"' AND DV.TENDV LIKE N'%Điện%' AND SD.NGAYKETTHUC >= '" + ngayStr + @"';

                SELECT TOP 1 @chiSoDienThangTruoc = CHISODIEN
                FROM CHISODIENNUOC
                WHERE MAPT = '" + maPT + @"' AND NGAYTHANG < '" + ngayStr + @"'
                ORDER BY NGAYTHANG DESC;

                SELECT TOP 1 @chiSoDienThangHienTai = CHISODIEN
                FROM CHISODIENNUOC
                WHERE MAPT = '" + maPT + @"' AND NGAYTHANG = '" + ngayStr + @"';

                SELECT (@chiSoDienThangHienTai - @chiSoDienThangTruoc) * ISNULL(@donGiaDien, 0) AS TienDien;
            ";

            object resultDien = db.ExecuteScalar(sqlDien);
            decimal tongTienDien = resultDien != null && resultDien != DBNull.Value ? Convert.ToDecimal(resultDien) : 0;

            string sqlNuoc = @"
                DECLARE @chiSoNuocThangTruoc INT, @chiSoNuocThangHienTai INT;
                DECLARE @donGiaNuoc MONEY;

                SELECT @donGiaNuoc = DONGIA
                FROM DICHVU DV
                INNER JOIN SUDUNGDV SD ON DV.MADV = SD.MADV
                WHERE SD.MAPT = '" + maPT + @"' AND DV.TENDV LIKE N'%Nước%' AND SD.NGAYKETTHUC >= '" + ngayStr + @"';

                SELECT TOP 1 @chiSoNuocThangTruoc = CHISONUOC
                FROM CHISODIENNUOC
                WHERE MAPT = '" + maPT + @"' AND NGAYTHANG < '" + ngayStr + @"'
                ORDER BY NGAYTHANG DESC;

                SELECT TOP 1 @chiSoNuocThangHienTai = CHISONUOC
                FROM CHISODIENNUOC
                WHERE MAPT = '" + maPT + @"' AND NGAYTHANG = '" + ngayStr + @"';

                SELECT (@chiSoNuocThangHienTai - @chiSoNuocThangTruoc) * ISNULL(@donGiaNuoc, 0) AS TienNuoc;
            ";

            object resultNuoc = db.ExecuteScalar(sqlNuoc);
            decimal tongTienNuoc = resultNuoc != null && resultNuoc != DBNull.Value ? Convert.ToDecimal(resultNuoc) : 0;

            string sqlPhatSinh = "SELECT SUM(SoTien) FROM PHATSINH " +
                                 "WHERE NGAYTHANG >= '" + ngayStr + "' AND MaPT = '" + maPT + "'";

            object resultPhatSinh = db.ExecuteScalar(sqlPhatSinh);
            decimal tongTienPhatSinh = resultPhatSinh != null && resultPhatSinh != DBNull.Value ? Convert.ToDecimal(resultPhatSinh) : 0;

            tongTien = donGiaPhong + tongTienDichVu + tongTienDien + tongTienNuoc + tongTienPhatSinh;

            return tongTien;
        }

        public object LayDanhSachHoaDonTheoThang(DateTime value)
        {
            string sql = "SELECT * FROM HOADON WHERE MONTH(NgayThanhToan) = " + value.Month + " AND YEAR(NgayThanhToan) = " + value.Year;
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

        public object LayDanhSachHoaDonTheoThangVaNT(DateTime value, string maNT)
        {
            string sql = "SELECT HD.* FROM HOADON HD JOIN PHONGTRO PT ON HD.MaPT = PT.MaPT WHERE MONTH(HD.NgayThanhToan) = " + value.Month + " AND YEAR(HD.NgayThanhToan) = " + value.Year + " AND PT.MaNT = '" + maNT + "'";
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

    }
}
