namespace GUI
{
    partial class UCThongKeDoanhThuTheoThang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpNam = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIỂU ĐỒ DOANH THU THEO THÁNG";
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(37, 88);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(1637, 687);
            this.chartDoanhThu.TabIndex = 2;
            this.chartDoanhThu.Text = "chart1";
            // 
            // dtpNam
            // 
            this.dtpNam.Location = new System.Drawing.Point(37, 40);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Size = new System.Drawing.Size(200, 22);
            this.dtpNam.TabIndex = 4;
            // 
            // UCThongKeDoanhThuTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDoanhThu);
            this.Name = "UCThongKeDoanhThuTheoThang";
            this.Size = new System.Drawing.Size(1702, 884);
            this.Load += new System.EventHandler(this.UCThongKeDoanhThuTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpNam;
    }
}
