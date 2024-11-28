namespace GUI
{
    partial class frmTrangChu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chartTrangThai = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpNgayThang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvDoanhThu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvKhachSapHetHopDong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TENNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHETHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvPhongTrong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrangThai)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachSapHetHopDong)).BeginInit();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.chartTrangThai);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(22, 14);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(818, 444);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "TRẠNG THÁI PHÒNG";
            // 
            // chartTrangThai
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrangThai.ChartAreas.Add(chartArea1);
            this.chartTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTrangThai.Legends.Add(legend1);
            this.chartTrangThai.Location = new System.Drawing.Point(0, 40);
            this.chartTrangThai.Name = "chartTrangThai";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTrangThai.Series.Add(series1);
            this.chartTrangThai.Size = new System.Drawing.Size(818, 404);
            this.chartTrangThai.TabIndex = 0;
            this.chartTrangThai.Text = "chart1";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dtpNgayThang);
            this.guna2GroupBox2.Controls.Add(this.dgvDoanhThu);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(22, 473);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1216, 444);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "DOANH THU TRONG THÁNG";
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.Checked = true;
            this.dtpNgayThang.FillColor = System.Drawing.Color.White;
            this.dtpNgayThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThang.Location = new System.Drawing.Point(213, 4);
            this.dtpNgayThang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayThang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(260, 33);
            this.dtpNgayThang.TabIndex = 120;
            this.dtpNgayThang.Value = new System.DateTime(2024, 11, 11, 0, 0, 0, 0);
            this.dtpNgayThang.ValueChanged += new System.EventHandler(this.dtpNgayThang_ValueChanged);
            // 
            // dgvDoanhThu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoanhThu.ColumnHeadersHeight = 50;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 40);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 50;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1216, 404);
            this.dgvDoanhThu.TabIndex = 3;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDoanhThu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvDoanhThu.ThemeStyle.ReadOnly = false;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDoanhThu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvDoanhThu.ThemeStyle.RowsStyle.Height = 50;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.dgvKhachSapHetHopDong);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(862, 14);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(806, 444);
            this.guna2GroupBox3.TabIndex = 4;
            this.guna2GroupBox3.Text = "DANH SÁCH KHÁCH SẮP HẾT HẠN HỢP ĐỒNG";
            // 
            // dgvKhachSapHetHopDong
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvKhachSapHetHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachSapHetHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKhachSapHetHopDong.ColumnHeadersHeight = 50;
            this.dgvKhachSapHetHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachSapHetHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENNT,
            this.MAPT,
            this.HOTEN,
            this.NGAYHETHAN,
            this.DONGIA});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachSapHetHopDong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKhachSapHetHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachSapHetHopDong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachSapHetHopDong.Location = new System.Drawing.Point(0, 40);
            this.dgvKhachSapHetHopDong.Name = "dgvKhachSapHetHopDong";
            this.dgvKhachSapHetHopDong.RowHeadersVisible = false;
            this.dgvKhachSapHetHopDong.RowHeadersWidth = 51;
            this.dgvKhachSapHetHopDong.RowTemplate.Height = 50;
            this.dgvKhachSapHetHopDong.Size = new System.Drawing.Size(806, 404);
            this.dgvKhachSapHetHopDong.TabIndex = 0;
            this.dgvKhachSapHetHopDong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachSapHetHopDong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachSapHetHopDong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachSapHetHopDong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachSapHetHopDong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachSapHetHopDong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachSapHetHopDong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachSapHetHopDong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhachSapHetHopDong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachSapHetHopDong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKhachSapHetHopDong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachSapHetHopDong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachSapHetHopDong.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvKhachSapHetHopDong.ThemeStyle.ReadOnly = false;
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.Height = 50;
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachSapHetHopDong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TENNT
            // 
            this.TENNT.DataPropertyName = "TenNhaTro";
            this.TENNT.HeaderText = "Nhà";
            this.TENNT.MinimumWidth = 6;
            this.TENNT.Name = "TENNT";
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MaPhong";
            this.MAPT.HeaderText = "Phòng";
            this.MAPT.MinimumWidth = 6;
            this.MAPT.Name = "MAPT";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "TenKhach";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // NGAYHETHAN
            // 
            this.NGAYHETHAN.DataPropertyName = "NGAYHETHAN";
            this.NGAYHETHAN.HeaderText = "Ngày hết hạn";
            this.NGAYHETHAN.MinimumWidth = 6;
            this.NGAYHETHAN.Name = "NGAYHETHAN";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "GiaTien";
            this.DONGIA.HeaderText = "Giá tiền";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.dgvPhongTrong);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(1259, 473);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(409, 444);
            this.guna2GroupBox4.TabIndex = 5;
            this.guna2GroupBox4.Text = "DANH SÁCH SỐ PHÒNG TRỐNG";
            // 
            // dgvPhongTrong
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPhongTrong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongTrong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhongTrong.ColumnHeadersHeight = 50;
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongTrong.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPhongTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongTrong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhongTrong.Location = new System.Drawing.Point(0, 40);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.RowHeadersVisible = false;
            this.dgvPhongTrong.RowHeadersWidth = 51;
            this.dgvPhongTrong.RowTemplate.Height = 50;
            this.dgvPhongTrong.Size = new System.Drawing.Size(409, 404);
            this.dgvPhongTrong.TabIndex = 1;
            this.dgvPhongTrong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhongTrong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhongTrong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhongTrong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhongTrong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhongTrong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhongTrong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhongTrong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhongTrong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhongTrong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPhongTrong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhongTrong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhongTrong.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvPhongTrong.ThemeStyle.ReadOnly = false;
            this.dgvPhongTrong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhongTrong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhongTrong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPhongTrong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvPhongTrong.ThemeStyle.RowsStyle.Height = 50;
            this.dgvPhongTrong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhongTrong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenNhaTro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nhà";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoLuongPhongTrong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số phòng trống";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 948);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "frmTrangChu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrangThai)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachSapHetHopDong)).EndInit();
            this.guna2GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrangThai;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachSapHetHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHETHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDoanhThu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayThang;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}