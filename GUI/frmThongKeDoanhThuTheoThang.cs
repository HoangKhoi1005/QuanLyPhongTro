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
    public partial class frmThongKeDoanhThuTheoThang : MetroFramework.Forms.MetroForm
    {
        DoanhThuBUL DoanhThuBUL = new DoanhThuBUL();
        public frmThongKeDoanhThuTheoThang()
        {
            InitializeComponent();
            
        }

        private void loadChartDoanhThu(List<DoanhThuDTO> doanhThuList)
        {
            chartDoanhThu.Legends.Clear();
            chartDoanhThu.Series.Clear();

            Series series = new Series("Doanh Thu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            chartDoanhThu.Series.Add(series);

            var doanhThuByMonth = new Dictionary<int, decimal>();
            for (int i = 1; i <= 12; i++)
            {
                doanhThuByMonth[i] = 0;
            }

            foreach (var item in doanhThuList)
            {
                doanhThuByMonth[item.Thang] = item.DoanhThu;
            }

            foreach (var month in doanhThuByMonth)
            {
                series.Points.AddXY(month.Key, month.Value);
            }

            chartDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";
        }





        private void frmThongKeDoanhThuTheoThang_Load(object sender, EventArgs e)
        {

        }
    }
}
