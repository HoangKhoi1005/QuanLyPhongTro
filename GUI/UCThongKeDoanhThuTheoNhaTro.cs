using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class UCThongKeDoanhThuTheoNhaTro : UserControl
    {
        DoanhThuBUL DoanhThuBUL = new DoanhThuBUL();
        public UCThongKeDoanhThuTheoNhaTro()
        {
            InitializeComponent();
        }

        private void loadChartDoanhThu(List<DoanhThuDTO> doanhThuList, List<string> danhSachNhaTro)
        {
            chartDoanhThu.Legends.Clear();
            chartDoanhThu.Series.Clear();

            Series series = new Series("Doanh Thu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            chartDoanhThu.Series.Add(series);

            var doanhThuByNhaTro = new Dictionary<string, decimal>();

            foreach (var nhaTro in danhSachNhaTro)
            {
                doanhThuByNhaTro[nhaTro] = 0;
            }

            foreach (var item in doanhThuList)
            {
                if (doanhThuByNhaTro.ContainsKey(item.IDNhaTro))
                {
                    doanhThuByNhaTro[item.IDNhaTro] += item.DoanhThu;
                }
            }

            foreach (var nhaTro in doanhThuByNhaTro)
            {
                var point = series.Points.AddXY(nhaTro.Key, nhaTro.Value);
                series.Points[point].Label = string.Format("{0:#,##0} VND", nhaTro.Value);
            }

            chartDoanhThu.ChartAreas[0].AxisX.Title = "Nhà Trọ";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";
        }


        private void UCThongKeDoanhThuTheoNhaTro_Load(object sender, EventArgs e)
        {
            var doanhThuList = DoanhThuBUL.LayDoanhThuTheoNhaTro();
            var danhSachNhaTro = DoanhThuBUL.LayDanhSachNhaTro();
            loadChartDoanhThu(doanhThuList, danhSachNhaTro);
        }
    }
}
