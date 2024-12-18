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
    public class KhachTroDAL
    {
        DBConnect db;

        public KhachTroDAL()
        {
            db = new DBConnect();
        }

        //Lấy danh sách khách trọ
        public List<KhachTroDTO> LayDanhSachKhachTro()
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách khách trọ: " + ex.Message);
            }
            return lstKhachTro;
        }

        public List<KhachTroDTO> LayDSKhachTroChuaThuePhong()
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND MaKT NOT IN (SELECT MaKT FROM KHACHTRO_HOPDONG)";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách khách trọ chưa thuê phòng: " + ex.Message);
            }
            return lstKhachTro;
        }

        public List<KhachTroDTO> LayDSKhachTroDaThuePhong()
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND MaKT IN (SELECT MaKT FROM KHACHTRO_HOPDONG)";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách khách trọ chưa thuê phòng: " + ex.Message);
            }
            return lstKhachTro;
        }

        public List<KhachTroDTO> TimKiemKhachTro(string ten)
        {
            List<KhachTroDTO> lstKhachTro = new List<KhachTroDTO>();
            string sql = "SELECT * FROM KHACHTRO WHERE DAXOA = 0 AND HOTEN LIKE N'%" + ten + "%'";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
                {
                    while (reader.Read())
                    {
                        KhachTroDTO khachTro = new KhachTroDTO();

                        khachTro.MaKT = reader["MaKT"].ToString();
                        khachTro.HoTen = reader["HoTen"].ToString();
                        khachTro.DiaChi = reader["DiaChi"].ToString();
                        khachTro.SoDT = reader["SoDT"].ToString();
                        khachTro.CCCD = reader["CCCD"].ToString();
                        khachTro.Email = reader["Email"].ToString();
                        khachTro.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        khachTro.GioiTinh = reader["GioiTinh"].ToString();
                        khachTro.Anh = reader["Anh"].ToString();
                        khachTro.MoTa = reader["MoTa"].ToString();
                        khachTro.DaXoa = Convert.ToInt32(reader["DaXoa"]);

                        lstKhachTro.Add(khachTro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm khách trọ: " + ex.Message);
            }
            return lstKhachTro;
        }

        public string PhatSinhMaKhachTro()
        {
            string sql = "SELECT TOP 1 MaKT FROM KHACHTRO ORDER BY MaKT DESC";
            string maKT = "KT001";
            try
            {
                using (var reader = db.ExecuteQuery(sql))
                {
                    if (reader.Read())
                    {
                        string ma = reader["MaKT"].ToString();
                        int thuTu = Convert.ToInt32(ma.Substring(2)) + 1;
                        maKT = "KT" + thuTu.ToString("000");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi phát sinh mã khách trọ: " + ex.Message);
            }
            return maKT;
        }

        //Kiem tra khach tro co ton tai
        public bool KiemTraKhachTroTonTai(string MaKT)
        {
            string sql = "SELECT COUNT(*) FROM KHACHTRO WHERE MAKT = '" + MaKT + "'";
            int count = 0;
            try
            {
                using (var reader = db.ExecuteQuery(sql))
                {
                    if (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra khách trọ tồn tại: " + ex.Message);
            }
            return count > 0;
        }

        public bool ThemKhachTro(KhachTroDTO khachTro)
        {
            string sql = "INSERT INTO KHACHTRO VALUES('" + khachTro.MaKT + "', N'" + khachTro.HoTen + "', N'" + khachTro.DiaChi + "', '" + khachTro.SoDT + "', '" + khachTro.CCCD + "', '" + khachTro.Email + "', '" + khachTro.NgaySinh + "', N'" + khachTro.GioiTinh + "', N'" + khachTro.Anh + "', N'" + khachTro.MoTa + "', 0)";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public string LayTenNguoiDaiDienTheoPhong(string maPT)
        {
            string sql = "SELECT HOTEN FROM KHACHTRO, HOPDONG WHERE KHACHTRO.MAKT = HOPDONG.MAKTDAIDIEN AND HOPDONG.MAPT = '" + maPT + "'";
            object ten = db.ExecuteScalar(sql);
            return (string)ten;
        }

        public DataTable LayThanhVienTheoPhong(string maPT)
        {
            string sql = "SELECT KHACHTRO.MAKT, KHACHTRO.HOTEN, KHACHTRO.CCCD, KHACHTRO.NGAYSINH, KHACHTRO.GIOITINH, KHACHTRO.SODT, KHACHTRO.EMAIL, KHACHTRO.DIACHI, KHACHTRO.ANH, KHACHTRO.MOTA FROM KHACHTRO, HOPDONG, KHACHTRO_HOPDONG WHERE KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT AND HOPDONG.MAHOPDONG = KHACHTRO_HOPDONG.MAHOPDONG AND HOPDONG.MAPT = '" + maPT + "' AND KHACHTRO.MAKT != HOPDONG.MAKTDAIDIEN";
            return db.GetDataTable(sql);
        }

        public bool SuaKhachTro(KhachTroDTO khachTroDTO)
        {
            string sql = "UPDATE KHACHTRO SET HOTEN = N'" + khachTroDTO.HoTen + "', CCCD = '" + khachTroDTO.CCCD + "', SODT = '" + khachTroDTO.SoDT + "', DIACHI = N'" + khachTroDTO.DiaChi + "', EMAIL = '" + khachTroDTO.Email + "', NGAYSINH = '" + khachTroDTO.NgaySinh + "', GIOITINH = N'" + khachTroDTO.GioiTinh + "', ANH = N'" + khachTroDTO.Anh + "', MOTA = N'" + khachTroDTO.MoTa + "' WHERE MAKT = '" + khachTroDTO.MaKT + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool XoaKhachTroHopDong(string maKT)
        {
            string sql = "DELETE FROM KHACHTRO_HOPDONG WHERE MAKT = '" + maKT + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }


        public KhachTroDTO LayNguoiDaiDienTheoPhong(string maPT)
        {
            string sql = "SELECT KHACHTRO.MAKT, KHACHTRO.HOTEN, KHACHTRO.CCCD, KHACHTRO.NGAYSINH, KHACHTRO.GIOITINH, KHACHTRO.SODT, KHACHTRO.EMAIL, KHACHTRO.DIACHI, KHACHTRO.ANH, KHACHTRO.MOTA FROM KHACHTRO, HOPDONG WHERE KHACHTRO.MAKT = HOPDONG.MAKTDAIDIEN AND HOPDONG.MAPT = '" + maPT + "' AND TRANGTHAIHOPDONG = 1" +
                " UNION " +
                "SELECT TOP 1 KHACHTRO.MAKT, KHACHTRO.HOTEN, KHACHTRO.CCCD, KHACHTRO.NGAYSINH, KHACHTRO.GIOITINH, KHACHTRO.SODT, KHACHTRO.EMAIL, KHACHTRO.DIACHI, KHACHTRO.ANH, KHACHTRO.MOTA FROM KHACHTRO, PHIEUDATPHONG WHERE KHACHTRO.MAKT = PHIEUDATPHONG.MAKT AND PHIEUDATPHONG.MAPT = '" + maPT + "' AND PHIEUDATPHONG.DAXOA = 0";

            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    KhachTroDTO khachTro = new KhachTroDTO
                    {
                        MaKT = reader["MaKT"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        CCCD = reader["CCCD"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SoDT = reader["SoDT"].ToString(),
                        Email = reader["Email"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Anh = reader["Anh"].ToString(),
                        MoTa = reader["MoTa"].ToString()
                    };
                    return khachTro;
                }
            }
            return null;
        }
        public bool XoaKhachTro(string maKT)
        {
            string sql = "UPDATE KHACHTRO SET DAXOA = 1 WHERE MAKT = '" + maKT + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public DataTable TraCuuKhachTro(string hoTen, string cccd, string maPT)
        {
            string sql = "SELECT DISTINCT KHACHTRO.MAKT, HOTEN, DIACHI, SODT, CCCD, EMAIL, NGAYSINH, GIOITINH, ANH, KHACHTRO.MOTA, KHACHTRO.DAXOA " +
                         "FROM KHACHTRO " +
                         "JOIN KHACHTRO_HOPDONG ON KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT " +
                         "JOIN HOPDONG ON KHACHTRO_HOPDONG.MAHOPDONG = HOPDONG.MAHOPDONG " +
                         "WHERE KHACHTRO.DAXOA = 0 ";
           
            if (!string.IsNullOrEmpty(hoTen))
            {
                sql += "AND HOTEN LIKE N'%" + hoTen + "%' ";
            }

            if (!string.IsNullOrEmpty(cccd))
            {
                sql += "AND CCCD LIKE '%" + cccd + "%' ";
            }

            if (!string.IsNullOrEmpty(maPT))
            {
                sql += "AND HOPDONG.MAPT LIKE '%" + maPT + "%' ";
            }

            return db.GetDataTable(sql);
        }

        public DataRow LayKhachTroTheoMaKT(string maKT)
        {
            /*
             CREATE TABLE HOPDONG (
    MAHOPDONG NVARCHAR(20) NOT NULL,					-- Mã hợp đồng (khóa chính)
    MAPT NVARCHAR(20) NOT NULL,							-- Mã phòng trọ (khóa ngoại từ bảng PHONGTRO)
	MAQL NVARCHAR(10) NOT NULL,							-- Mã quản lý (khóa ngoại từ bảng QUANLY)
	MAKTDAIDIEN NVARCHAR(10) NOT NULL,					-- Mã khách trọ đại diện (khóa ngoại từ bảng KHACHTRO)
    NGAYLAP DATE,										-- Ngày lập hợp đồng
    NGAYHETHAN DATE,									-- Ngày hết hạn hợp đồng
    TIENCOC MONEY,										-- Tiền cọc
	TRANGTHAIHOPDONG BIT NOT NULL DEFAULT 0,			-- Trạng thái hợp đồng (0: Chưa kết thúc, 1: Đã kết thúc)
	MOTA NVARCHAR(255),									-- Ghi chú thêm
    CONSTRAINT PK_HOPDONG PRIMARY KEY (MAHOPDONG),		-- Thiết lập khóa chính cho MAHD
	CONSTRAINT FK_HOPDONG_QUANLY FOREIGN KEY (MAQL) REFERENCES QUANLY(MAQL),  -- Liên kết với bảng QUANLY
	CONSTRAINT FK_HOPDONG_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),  -- Liên kết với bảng PHONGTRO
	CONSTRAINT FK_HOPDONG_KHACHTRO FOREIGN KEY (MAKTDAIDIEN) REFERENCES KHACHTRO(MAKT) -- Liên kết với khách trọ đại diện
);


CREATE TABLE KHACHTRO_HOPDONG (
    MAHOPDONG NVARCHAR(20) NOT NULL,	-- Mã hợp đồng (khóa ngoại từ bảng HOPDONG)
    MAKT NVARCHAR(10) NOT NULL,			-- Mã khách trọ (khóa ngoại từ bảng KHACHTRO)
    CONSTRAINT FK_KHACHTRO_HOPDONG_HOPDONG FOREIGN KEY (MAHOPDONG) REFERENCES HOPDONG(MAHOPDONG),
    CONSTRAINT FK_KHACHTRO_HOPDONG_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),
    CONSTRAINT PK_KHACHTRO_HOPDONG PRIMARY KEY (MAHOPDONG, MAKT)
);
            CREATE TABLE KHACHTRO (
    MAKT NVARCHAR(10) NOT NULL,
    HOTEN NVARCHAR(50),
    DIACHI NVARCHAR(100),
    SODT NVARCHAR(20),
    CCCD NVARCHAR(12),
	EMAIL NVARCHAR(50),
    NGAYSINH DATE,
    GIOITINH NVARCHAR(10),
	ANH NVARCHAR(MAX),
	MOTA NVARCHAR(255),
	DAXOA BIT NOT NULL DEFAULT 0,	-- Trạng thái (0: Đã rời đi, 1: Đang ở)
    CONSTRAINT PK_KHACHTRO PRIMARY KEY (MAKT)
);
            //Lấy cả mã phòng
             */
            string sql = "SELECT KHACHTRO.MAKT, HOTEN, DIACHI, SODT, CCCD, EMAIL, NGAYSINH, GIOITINH, ANH, KHACHTRO.MOTA, KHACHTRO.DAXOA, HOPDONG.MAPT " +
                         "FROM KHACHTRO " +
                         "JOIN KHACHTRO_HOPDONG ON KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT " +
                         "JOIN HOPDONG ON KHACHTRO_HOPDONG.MAHOPDONG = HOPDONG.MAHOPDONG " +
                         "WHERE KHACHTRO.MAKT = '" + maKT + "'";
            return db.GetDataRow(sql);

        }
    }
}
