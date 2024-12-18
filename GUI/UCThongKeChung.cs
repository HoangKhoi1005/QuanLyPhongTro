using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UCThongKeChung : UserControl
    {
        TrangThaiPhong1BUL trangThaiPhongBUL = new TrangThaiPhong1BUL();
        DoanhThuBUL doanhThuBUL = new DoanhThuBUL();
        HoaDonBUL hoaDonBUL = new HoaDonBUL();
        KhachTroSapHetHanHopDongBUL khachTroSapBUL;
        private PhongTrongBUL phongTrongBUL;

        public UCThongKeChung()
        {
            InitializeComponent();
            khachTroSapBUL = new KhachTroSapHetHanHopDongBUL();

            phongTrongBUL = new PhongTrongBUL();
            HienThiPhongTrong();

            dtpNgayThang.Format = DateTimePickerFormat.Custom;
            dtpNgayThang.CustomFormat = "MM/yyyy";
            //dtpNgayThang.ShowUpDown = true;
            dgvKhachSapHetHopDong.Columns["DONGIA"].DefaultCellStyle.Format = "N0";
        }

        private void dtpNgayThang_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = hoaDonBUL.TongTienTrongThang(dtpNgayThang.Value).ToString("N0") + " VNĐ";

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

                dgvDoanhThu.Columns["GiaPhong"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["ProratedRent"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["TienDien"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["TienNuoc"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["TienDichVu"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["PhatSinh"].DefaultCellStyle.Format = "N0";
                dgvDoanhThu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadChartTrangThai(List<TrangThaiPhong1DTO> trangThaiPhongList)
        {
            chartTrangThai.Series.Clear();
            chartTrangThai.Legends.Clear();

            // Tạo chú thích (Legend)
            Legend legend = new Legend
            {
                Docking = Docking.Right, // Vị trí của chú thích
                Alignment = StringAlignment.Center,
                Font = new Font("Arial", 10, FontStyle.Regular),
                LegendStyle = LegendStyle.Table,
                TableStyle = LegendTableStyle.Wide
            };
            chartTrangThai.Legends.Add(legend);

            // Tạo Series cho biểu đồ
            Series series = new Series("Trạng Thái Phòng")
            {
                ChartType = SeriesChartType.Pie,
                Label = "#PERCENT{P1}", // Hiển thị phần trăm trên biểu đồ
                Font = new Font("Arial", 9, FontStyle.Bold),
                IsValueShownAsLabel = true
            };
            chartTrangThai.Series.Add(series);

            foreach (var item in trangThaiPhongList)
            {
                // Tạo điểm dữ liệu
                DataPoint point = new DataPoint
                {
                    AxisLabel = item.TenTrangThai,
                    YValues = new double[] { item.SoLuong },
                    Label = $"{item.PhanTram:F2}%",
                    LegendText = $"{item.TenTrangThai} - {item.SoLuong} phòng ({item.PhanTram:F2}%)"
                };

                // Gán màu sắc cho từng trạng thái
                switch (item.TenTrangThai)
                {
                    case "Trống":
                        point.Color = Color.FromArgb(255, 128, 128);
                        break;
                    case "Có người":
                        point.Color = Color.FromArgb(133, 193, 233);
                        break;
                    case "Đang sửa chữa":
                        point.Color = Color.FromArgb(241, 196, 15);
                        break;
                    case "Đã đặt":
                        point.Color = Color.FromArgb(40, 167, 69);
                        break;
                    case "Báo trả phòng":
                        point.Color = Color.FromArgb(189, 195, 199);
                        break;
                    default:
                        point.Color = Color.Gray;
                        break;
                }

                series.Points.Add(point);
            }

            // Bật chú thích
            chartTrangThai.Legends[0].Enabled = true;
        }



        private void UCThongKeChung_Load(object sender, EventArgs e)
        {
            var trangThaiPhongList = trangThaiPhongBUL.LayTrangThaiPhong();
            loadChartTrangThai(trangThaiPhongList);

            var khachTroSapHetHopDong = khachTroSapBUL.LayKhachTroSapHetHopDong();
            dgvKhachSapHetHopDong.DataSource = khachTroSapHetHopDong;

            dtpNgayThang.Value = DateTime.Now;
        }

        private void HienThiPhongTrong()
        {
            dgvPhongTrong.DataSource = phongTrongBUL.LayDanhSachPhongTrong();
        }
    }
}
