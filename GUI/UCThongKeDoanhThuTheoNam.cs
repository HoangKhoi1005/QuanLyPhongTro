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
    public partial class UCThongKeDoanhThuTheoNam : UserControl
    {
        DoanhThuBUL DoanhThuBUL = new DoanhThuBUL();
        public UCThongKeDoanhThuTheoNam()
        {
            InitializeComponent();
        }

        private void loadChartDoanhThu(List<DoanhThuDTO> doanhThuList)
        {
            chartDoanhThu.Legends.Clear();
            chartDoanhThu.Series.Clear();

            Series series = new Series("Doanh Thu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            chartDoanhThu.Series.Add(series);

            var doanhThuByYear = new Dictionary<int, decimal>();
            for (int i = 2019; i <= 2021; i++)
            {
                doanhThuByYear[i] = 0;
            }

            foreach (var item in doanhThuList)
            {
                doanhThuByYear[item.Nam] = item.DoanhThu;
            }

            foreach (var year in doanhThuByYear)
            {
                var point = series.Points.AddXY(year.Key, year.Value);
                series.Points[point].Label = string.Format("{0:#,##0} VND", year.Value);
            }

            chartDoanhThu.ChartAreas[0].AxisX.Title = "Năm";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";
        }

        private void UCThongKeDoanhThuTheoNam_Load(object sender, EventArgs e)
        {
            var doanhThuList = DoanhThuBUL.LayDoanhThuTheoNam();
            loadChartDoanhThu(doanhThuList);
        }
    }
}
