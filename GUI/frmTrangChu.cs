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

            dtpNgayThang.Format = DateTimePickerFormat.Custom;
            dtpNgayThang.CustomFormat = "MM/yyyy";
            dtpNgayThang.ShowUpDown = true;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            var trangThaiPhongList = trangThaiPhongBUL.LayTrangThaiPhong();
            loadChartTrangThai(trangThaiPhongList);

            var khachTroSapHetHopDong = khachTroSapBUL.LayKhachTroSapHetHopDong();
            dgvKhachSapHetHopDong.DataSource = khachTroSapHetHopDong;

            dtpNgayThang.Value = DateTime.Now;
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

        private void HienThiPhongTrong()
        {
            dgvPhongTrong.DataSource = phongTrongBUL.LayDanhSachPhongTrong();
        }

        private void dtpNgayThang_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtpNgayThang.Value;
                DateTime firstDayOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                DataTable doanhThuData = doanhThuBUL.LoadDoanhThu(selectedDate);
                dgvDoanhThu.DataSource = doanhThuData;

                dgvDoanhThu.Columns["MaPhong"].HeaderText = "Mã Phòng";
                dgvDoanhThu.Columns["GiaPhong"].HeaderText = "Giá Phòng";
                dgvDoanhThu.Columns["ProratedRent"].HeaderText = "Tiền Thuê Tính Theo Ngày";
                dgvDoanhThu.Columns["TienDien"].HeaderText = "Tiền Điện";
                dgvDoanhThu.Columns["TienNuoc"].HeaderText = "Tiền Nước";
                dgvDoanhThu.Columns["TienDichVu"].HeaderText = "Tiền Dịch Vụ";
                dgvDoanhThu.Columns["PhatSinh"].HeaderText = "Phí Phát Sinh";
                dgvDoanhThu.Columns["TongTien"].HeaderText = "Tổng Tiền";

                dgvDoanhThu.Columns["GiaPhong"].DefaultCellStyle.Format = "N0"; // Hiển thị số nguyên, không có thập phân
                                                                                // Hoặc, nếu bạn muốn hiển thị với 2 chữ số thập phân
                dgvDoanhThu.Columns["GiaPhong"].DefaultCellStyle.Format = "N2"; // Hiển thị 2 chữ số thập phân

                // Áp dụng định dạng tương tự cho các cột khác
                dgvDoanhThu.Columns["ProratedRent"].DefaultCellStyle.Format = "N2";
                dgvDoanhThu.Columns["TienDien"].DefaultCellStyle.Format = "N2";
                dgvDoanhThu.Columns["TienNuoc"].DefaultCellStyle.Format = "N2";
                dgvDoanhThu.Columns["TienDichVu"].DefaultCellStyle.Format = "N2";
                dgvDoanhThu.Columns["PhatSinh"].DefaultCellStyle.Format = "N2";
                dgvDoanhThu.Columns["TongTien"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
