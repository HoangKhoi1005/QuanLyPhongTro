using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class HopDongBUL
    {
        HopDongDAL hopDongDAL;

        public HopDongBUL()
        {
            hopDongDAL = new HopDongDAL();
        }

        public bool ThemHopDong(HopDongDTO hopDong)
        {
            return hopDongDAL.ThemHopDong(hopDong);
        }

        public bool ThemKhachTroHopDong(KhachTroHopDongDTO khachTroHopDong)
        {
            return hopDongDAL.ThemKhachTroHopDong(khachTroHopDong);
        }

        public string PhatSinhMaHopDong()
        {
            return hopDongDAL.PhatSinhMaHopDong();
        }

        public string TimMaHopDongTheoMaPhong(string maPhong)
        {
            return hopDongDAL.TimMaHopDongTheoMaPhong(maPhong);
        }

        public int DemSoLuongKhachTroTrongHopDong(string maHopDong)
        {
            return hopDongDAL.DemSoLuongKhachTroTrongHopDong(maHopDong);
        }

        public DataTable LayDSHopDongDataGirdView()
        {
            return hopDongDAL.LayDSHopDongDataGirdView();
        }

        public HopDongDTO LayHopDongTheoMaPhong(string maPhong)
        {
            return hopDongDAL.LayHopDongTheoMaPhong(maPhong);
        }

        public bool CapNhatHopDong(HopDongDTO hopDong)
        {
            return hopDongDAL.CapNhatHopDong(hopDong);
        }

        public bool KiemTraPhongCoHopDong(string maPT)
        {
            return hopDongDAL.KiemTraPhongCoHopDong(maPT);
        }

        public void CapNhatTrangThaiHopDong(string maHopDong, int v)
        {
            hopDongDAL.CapNhatTrangThaiHopDong(maHopDong, v);
        }

        public List<KhachTroHopDongDTO> LayDanhSachKhachTroHopDong(string maHopDong)
        {
            return hopDongDAL.LayDanhSachKhachTroHopDong(maHopDong);
        }


        public Dictionary<string, string> GetContractDictionary(string maHopDong)
        {
            DataTable dataTable = hopDongDAL.layThongTinHopDong(maHopDong);
            Dictionary<string, string> contractDict = new Dictionary<string, string>();

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                DateTime ngayLap = Convert.ToDateTime(row["NGAYLAP"]);
                DateTime ngayBatDau = Convert.ToDateTime(row["NGAYBATDAU"]);
                DateTime ngayKetThuc = Convert.ToDateTime(row["NGAYKETTHUC"]);

                // Thông tin hợp đồng và bên A (Bên cho thuê)
                contractDict["ngaylap"] = ngayLap.Day.ToString();
                contractDict["thanglap"] = ngayLap.Month.ToString();
                contractDict["namlap"] = ngayLap.Year.ToString();
                contractDict["tenquanly"] = row["TENQUANLY"].ToString();
                //contractDict["cccdquanly"] = row["CCCDQUANLY"].ToString();
                contractDict["diachiquanly"] = row["DIACHIQUANLY"].ToString();
                contractDict["sdtquanly"] = row["SODIENTHOAIQL"].ToString();

                // Thông tin bên B (Bên thuê)
                contractDict["tenkhachtro"] = row["TENKHACHTRO"].ToString();
                contractDict["cccdkhachtro"] = row["CCCDKHACHTRO"].ToString();
                contractDict["diachikhachtro"] = row["DIACHIKHACHTRO"].ToString();
                contractDict["sdtkhachtro"] = row["SODIENTHOAIKT"].ToString();

                // Thông tin phòng trọ
                contractDict["maphongtro"] = row["MAPHONGTRO"].ToString();
                contractDict["diachiphongtro"] = row["DIACHINHATRO"].ToString();
                contractDict["ngaybatdau"] = ngayBatDau.ToString("dd/MM/yyyy");
                contractDict["ngayketthuc"] = ngayKetThuc.ToString("dd/MM/yyyy");
                contractDict["sothangthue"] = ((ngayKetThuc.Year - ngayBatDau.Year) * 12 + ngayKetThuc.Month - ngayBatDau.Month).ToString();
                contractDict["giathue"] = row["GIATHUE"].ToString();
                contractDict["tiencoc"] = row["TIENCOC"].ToString();
            }

            return contractDict;
        }
    }
}
