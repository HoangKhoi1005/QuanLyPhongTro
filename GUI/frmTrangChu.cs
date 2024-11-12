using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmTrangChu : Form
    {
        TrangThaiPhong1BUL trangThaiPhongBUL = new TrangThaiPhong1BUL();
        DoanhThuBUL doanhThuBUL = new DoanhThuBUL();
        KhachTroSapHetHanHopDongBUL khachTroSapBUL;
        private PhongTrongBUL phongTrongBUL;
        public frmTrangChu()
        {
            InitializeComponent();
            khachTroSapBUL = new KhachTroSapHetHanHopDongBUL();

            phongTrongBUL = new PhongTrongBUL();
            HienThiPhongTrong();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            var trangThaiPhongList = trangThaiPhongBUL.LayTrangThaiPhong();
            loadChartTrangThai(trangThaiPhongList);

            var doanhThuList = doanhThuBUL.LayDoanhThuTheoThang();
            loadChartDoanhThu(doanhThuList);

            var khachTroSapHetHopDong = khachTroSapBUL.LayKhachTroSapHetHopDong();
            dgvKhachSapHetHopDong.DataSource = khachTroSapHetHopDong;
        }

        private void loadChartTrangThai(List<TrangThaiPhong1DTO> trangThaiPhongList)
        {
            // Thiết lập biểu đồ tròn
            chartTrangThai.Series.Clear();
            Series series = new Series("Trạng Thái Phòng");
            series.ChartType = SeriesChartType.Pie;
            chartTrangThai.Series.Add(series);

            // Thêm dữ liệu vào Pie Chart từ danh sách trạng thái phòng
            foreach (var item in trangThaiPhongList)
            {
                series.Points.AddXY(item.TenTrangThai, item.SoLuong);
                // Hiển thị tỷ lệ phần trăm vào từng phần của biểu đồ tròn
                series.Points[series.Points.Count - 1].Label = $"{item.PhanTram:F2}%";  // Hiển thị tỷ lệ phần trăm với 2 chữ số thập phân
            }
            series.LegendText = "#VALX";  // Hiển thị tên trạng thái và phần trăm trên legend

            chartTrangThai.Legends[0].Enabled = true;
        }

        private void loadChartDoanhThu(List<DoanhThuDTO> doanhThuList)
        {
            chartDoanhThu.Legends.Clear();
            chartDoanhThu.Series.Clear();
            Series series = new Series("Doanh Thu");
            series.ChartType = SeriesChartType.Column;
            chartDoanhThu.Series.Add(series);

            // Thêm dữ liệu vào biểu đồ cột
            foreach (var item in doanhThuList)
            {
                series.Points.AddXY(item.Thang, item.DoanhThu);
            }

            // Tùy chỉnh thêm cho biểu đồ nếu cần
            chartDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
        }

        private void HienThiPhongTrong()
        {
            dgvPhongTrong.DataSource = phongTrongBUL.LayDanhSachPhongTrong();
        }


    }
}
