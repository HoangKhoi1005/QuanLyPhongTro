using DTO;
using SQLServerProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TamTruTamVangDAL
    {
        DBConnect db;

        public TamTruTamVangDAL()
        {
            db = new DBConnect();
        }

        public bool KiemTraKhachTroDaCoTTTV(string maKT, DateTime ngayBD, DateTime ngayKT)
        {
            string query = "SELECT * FROM TAMTRUTAMVANG WHERE MAKT = '" + maKT + "' AND ((NGAYBATDAU <= '" + ngayBD.ToString("yyyy-MM-dd") + "' AND NGAYKETTHUC >= '" + ngayBD.ToString("yyyy-MM-dd") + "') OR (NGAYBATDAU <= '" + ngayKT.ToString("yyyy-MM-dd") + "' AND NGAYKETTHUC >= '" + ngayKT.ToString("yyyy-MM-dd") + "'))";
            return db.GetDataTable(query).Rows.Count > 0;
        }
      
        public DataTable LayDSTamTruTamVang()
        {
            string query = "SELECT TAMTRUTAMVANG.MATTTV, KHACHTRO.MAKT, HOPDONG.MAPT,KHACHTRO.ANH ,KHACHTRO.HOTEN, KHACHTRO.GIOITINH,  KHACHTRO.NGAYSINH, KHACHTRO.SODT,  KHACHTRO.CCCD,   KHACHTRO.DIACHI,   KHACHTRO.EMAIL, TAMTRUTAMVANG.LOAITTV, TAMTRUTAMVANG.NGAYBATDAU,  TAMTRUTAMVANG.NGAYKETTHUC,  TAMTRUTAMVANG.MOTA FROM TAMTRUTAMVANG JOIN  KHACHTRO ON TAMTRUTAMVANG.MAKT = KHACHTRO.MAKT LEFT JOIN KHACHTRO_HOPDONG ON KHACHTRO.MAKT = KHACHTRO_HOPDONG.MAKT LEFT JOIN HOPDONG ON KHACHTRO_HOPDONG.MAHOPDONG = HOPDONG.MAHOPDONG;";
            return db.GetDataTable(query);
        }

        public bool SuaTamTruTamVang(TamTruTamVangDTO tamTruTamVangDTO)
        {
            string query = "UPDATE TAMTRUTAMVANG SET LOAITTV = N'" + tamTruTamVangDTO.LoaiTTTV + "', NGAYBATDAU = '" + tamTruTamVangDTO.NgayBatDau.ToString("yyyy-MM-dd") + "', NGAYKETTHUC = '" + tamTruTamVangDTO.NgayKetThuc.ToString("yyyy-MM-dd") + "', MOTA = N'" + tamTruTamVangDTO.MoTa + "' WHERE MATTTV = '" + tamTruTamVangDTO.MaTTTV + "'";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool ThemTamTruTamVang(TamTruTamVangDTO tamTruTamVangDTO)
        {
            string query = "INSERT INTO TAMTRUTAMVANG (MAKT, LOAITTV, NGAYBATDAU, NGAYKETTHUC, MOTA) VALUES ('" + tamTruTamVangDTO.MaKT + "', N'" + tamTruTamVangDTO.LoaiTTTV + "', '" + tamTruTamVangDTO.NgayBatDau.ToString("yyyy-MM-dd") + "', '" + tamTruTamVangDTO.NgayKetThuc.ToString("yyyy-MM-dd") + "', N'" + tamTruTamVangDTO.MoTa + "')";
            return db.ExecuteNonQuery(query) > 0;
        }

        public DataTable TraCuuTamTruTamVang(string hoTen, string cccd, string maPT, string loaiTTTV)
        {
            string sql = "SELECT DISTINCT TAMTRUTAMVANG.MATTTV, KHACHTRO.MAKT, MAPT, HOTEN, GIOITINH, NGAYSINH, SODT, CCCD, DIACHI, EMAIL, " +
                         "LOAITTV, NGAYBATDAU, NGAYKETTHUC, TAMTRUTAMVANG.MOTA, ANH " +
                         "FROM TAMTRUTAMVANG " +
                         "JOIN KHACHTRO ON TAMTRUTAMVANG.MAKT = KHACHTRO.MAKT " +
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

            if (!string.IsNullOrEmpty(loaiTTTV))
            {
                sql += "AND LOAITTV = N'" + loaiTTTV + "' ";
            }

            return db.GetDataTable(sql);
        }

    }
}
