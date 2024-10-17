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
    public class PhieuDatPhongDAL
    {
        DBConnect db;

        public PhieuDatPhongDAL()
        {
            db = new DBConnect();
        }

        //Thêm phiếu đặt phòng
        public bool ThemPhieuDatPhong(PhieuDatPhongDTO phieuDatPhong)
        {
            string sql = "INSERT INTO PHIEUDATPHONG VALUES('" + phieuDatPhong.MaPhieuDatPhong + "', '" + phieuDatPhong.MaKhachTro + "', '" + phieuDatPhong.MaPhongTro + "', '" + phieuDatPhong.MaQuanLy + "', '" + phieuDatPhong.NgayDuKienNhanPhong + "', " + phieuDatPhong.TienDatPhong + ", '" + phieuDatPhong.NgayLapPhieu + "', N'" + phieuDatPhong.MoTa + "', 0)";
            return db.ExecuteNonQuery(sql) > 0;
        }

        //Phát sinh mã phiếu đặt phòng
        public string PhatSinhMaPhieuDatPhong()
        {
            string maPhieuDatPhong = "PDP" + DateTime.Now.ToString("yyyyMMdd") + "001";
            string sql = "SELECT TOP 1 MAPDP FROM PhieuDatPhong ORDER BY MAPDP DESC";
            using (var reader = db.ExecuteQuery(sql))
            {
                if (reader.Read())
                {
                    string pdp = reader["MAPDP"].ToString();
                    int number = int.Parse(pdp.Substring(pdp.Length - 3)) + 1;
                    maPhieuDatPhong = "PDP" + DateTime.Now.ToString("yyyyMMdd") + number.ToString("000");
                }
            }
            return maPhieuDatPhong;
        }

        public DataTable LayDSPhieuDatDataGirdView()
        {
            string sql = "SELECT PD.MAPDP, PD.MaPT, QL.HOTENNV, KT.HoTen, PD.NGAYLAPPHIEU, PD.NGAYDUKIENNHANPHONG, PD.TIENDATPHONG, PD.MoTa FROM PHIEUDATPHONG PD, PhongTro PT, QuanLy QL , KhachTro KT WHERE PD.MaPT = PT.MaPT AND PD.MaKT = KT.MaKT AND QL.MaQL = PD.MaQL";
            return db.GetDataTable(sql);
        }
    }
}
