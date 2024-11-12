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
    public class KyLuatDAL
    {
        DBConnect db;

        public KyLuatDAL()
        {
            db = new DBConnect();
        }

        public DataTable LayDSKyLuatDataGirdView()
        {
            string sql = "SELECT MAKL,KHACHTRO.MAKT, MAPT, HOTEN, GIOITINH, NGAYSINH, SODT, CCCD, DIACHI, EMAIL, NGAYKL, LOAIKYLUAT, KYLUAT.MOTA, ANH FROM KYLUAT, KHACHTRO, HOPDONG, KHACHTRO_HOPDONG  WHERE KYLUAT.MAKT = KHACHTRO.MAKT AND KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT AND KHACHTRO_HOPDONG.MAHOPDONG = HOPDONG.MAHOPDONG";
            return db.GetDataTable(sql);
        }

        public bool SuaKyLuat(KyLuatDTO kyLuatDTO)
        {
            string sql = "UPDATE KYLUAT SET MOTA = N'" + kyLuatDTO.MoTa + "', NGAYKL = '" + kyLuatDTO.NgayKL + "', LOAIKYLUAT = N'" + kyLuatDTO.LoaiKL + "' WHERE MAKL = '" + kyLuatDTO.MaKL + "'";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public bool ThemKyLuat(KyLuatDTO kyLuatDTO)
        {
            string sql = "INSERT INTO KYLUAT(MAKT, MOTA, NGAYKL, LOAIKYLUAT) VALUES('" + kyLuatDTO.MaKT + "', N'" + kyLuatDTO.MoTa + "', '" + kyLuatDTO.NgayKL + "', N'" + kyLuatDTO.LoaiKL + "')";
            return db.ExecuteNonQuery(sql) > 0;
        }

        public DataTable TraCuuKyLuat(string hoTen, string cccd, string maPT)
        {
            string sql = "SELECT DISTINCT KYLUAT.MAKL, KHACHTRO.MAKT, MAPT, HOTEN, GIOITINH, NGAYSINH, SODT, CCCD, DIACHI, EMAIL, NGAYKL, LOAIKYLUAT, KYLUAT.MOTA, ANH " +
                         "FROM KYLUAT " +
                         "JOIN KHACHTRO ON KYLUAT.MAKT = KHACHTRO.MAKT " +
                         "JOIN KHACHTRO_HOPDONG ON KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT " +
                         "JOIN HOPDONG ON KHACHTRO_HOPDONG.MAHOPDONG = HOPDONG.MAHOPDONG " +
                         "WHERE 1=1 ";

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
                sql += "AND MAPT LIKE '%" + maPT + "%' ";
            }

            return db.GetDataTable(sql);
        }


    }
}
