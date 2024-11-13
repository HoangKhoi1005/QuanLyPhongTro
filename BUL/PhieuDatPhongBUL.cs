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
    public class PhieuDatPhongBUL
    {
        PhieuDatPhongDAL PhieuDatPhongDAL;

        public PhieuDatPhongBUL()
        {
            PhieuDatPhongDAL = new PhieuDatPhongDAL();
        }

        public bool ThemPhieuDatPhong(PhieuDatPhongDTO phieuDatPhong)
        {
            return PhieuDatPhongDAL.ThemPhieuDatPhong(phieuDatPhong);
        }

        public string PhatSinhMaPhieuDatPhong()
        {
            return PhieuDatPhongDAL.PhatSinhMaPhieuDatPhong();
        }

        public DataTable LayDSPhieuDatDataGirdView()
        {
            return PhieuDatPhongDAL.LayDSPhieuDatDataGirdView();
        }

        public bool KiemTraPhongDaDatCoc(string maPT)
        {
            return PhieuDatPhongDAL.KiemTraPhongDaDatCoc(maPT);
        }

        public bool XoaPhieuDatPhong(string maPhieuDatPhong)
        {
            return PhieuDatPhongDAL.XoaPhieuDatPhong(maPhieuDatPhong);
        }

        public PhieuDatPhongDTO LayPhieuDatPhongTheoMaPhong(string maPhong)
        {
            return PhieuDatPhongDAL.LayPhieuDatPhongTheoMaPhong(maPhong);
        }

        public Dictionary<string, string> GetContractDictionary(string maPhieuDat)
        {
            DataTable dataTable = PhieuDatPhongDAL.layThongTinPhieuDat(maPhieuDat);
            Dictionary<string, string> contractDict = new Dictionary<string, string>();

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                DateTime ngayLap = Convert.ToDateTime(row["NGAYLAPPHIEU"]);
                DateTime ngayNhan = Convert.ToDateTime(row["NGAYDUKIENNHANPHONG"]);

                // Thông tin hợp đồng và bên A (Bên cho thuê)
                contractDict["ngaydat"] = ngayLap.Day.ToString();
                contractDict["thangdat"] = ngayLap.Month.ToString();
                contractDict["namdat"] = ngayLap.Year.ToString();
                contractDict["tenquanly"] = row["TENQUANLY"].ToString();
                //contractDict["cccdquanly"] = row["CCCDQUANLY"].ToString();
                contractDict["diachiquanly"] = row["DIACHIQUANLY"].ToString();
                contractDict["sdtquanly"] = row["SODIENTHOAIQL"].ToString();

                // Thông tin bên B (Bên thuê)
                contractDict["tenkhachdat"] = row["TENKHACHTRO"].ToString();
                contractDict["cccdkhachdat"] = row["CCCDKHACHTRO"].ToString();
                contractDict["diachikhachdat"] = row["DIACHIKHACHTRO"].ToString();
                contractDict["sdtkhachdat"] = row["SODIENTHOAIKT"].ToString();

                // Thông tin phòng trọ
                contractDict["maphongtro"] = row["MAPHONGTRO"].ToString();
                contractDict["diachiphong"] = row["DIACHINHATRO"].ToString();
                contractDict["ngaydatphong"] = ngayLap.ToString("dd/MM/yyyy");
                contractDict["ngaynhanphong"] = ngayNhan.ToString("dd/MM/yyyy");
                contractDict["giathue"] = row["GIATHUE"].ToString();
                contractDict["tiencoc"] = row["TIENCOC"].ToString();
            }

            return contractDict;
        }
    }
}
