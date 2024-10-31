namespace GUI
{
    partial class frmTinhTienPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpThangNam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtThangNam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNT = new System.Windows.Forms.ComboBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDATHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNT = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaNT = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNT = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.Checked = true;
            this.dtpThangNam.FillColor = System.Drawing.Color.White;
            this.dtpThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpThangNam.Location = new System.Drawing.Point(124, 15);
            this.dtpThangNam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpThangNam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(237, 33);
            this.dtpThangNam.TabIndex = 103;
            this.dtpThangNam.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            this.dtpThangNam.ValueChanged += new System.EventHandler(this.dtpThangNam_ValueChanged);
            // 
            // txtThangNam
            // 
            this.txtThangNam.AutoSize = true;
            this.txtThangNam.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtThangNam.Location = new System.Drawing.Point(12, 22);
            this.txtThangNam.Name = "txtThangNam";
            this.txtThangNam.Size = new System.Drawing.Size(106, 23);
            this.txtThangNam.TabIndex = 104;
            this.txtThangNam.Text = "Tháng/Năm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(379, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 106;
            this.label6.Text = "Nhà Trọ:";
            // 
            // cboNT
            // 
            this.cboNT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboNT.FormattingEnabled = true;
            this.cboNT.Location = new System.Drawing.Point(460, 15);
            this.cboNT.Name = "cboNT";
            this.cboNT.Size = new System.Drawing.Size(209, 31);
            this.cboNT.TabIndex = 105;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.dgvHoaDon);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 80);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1648, 789);
            this.guna2GroupBox2.TabIndex = 107;
            this.guna2GroupBox2.Text = "Danh sách tiền phòng";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 30;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MAPT,
            this.MAQL,
            this.NGAYLAP,
            this.NGAYTHANHTOAN,
            this.TONGTIEN,
            this.TIENDATHANHTOAN,
            this.CONGNO,
            this.MOTA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 40);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 50;
            this.dgvHoaDon.RowTemplate.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(1648, 749);
            this.dgvHoaDon.TabIndex = 46;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 50;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.btnTraCuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.BorderRadius = 5;
            this.btnTraCuu.BorderThickness = 2;
            this.btnTraCuu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.CustomBorderColor = System.Drawing.Color.White;
            this.btnTraCuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraCuu.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.FillColor = System.Drawing.Color.White;
            this.btnTraCuu.FocusedColor = System.Drawing.Color.White;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(675, 12);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.PressedColor = System.Drawing.Color.Blue;
            this.btnTraCuu.Size = new System.Drawing.Size(109, 35);
            this.btnTraCuu.TabIndex = 55;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.FillWeight = 102.7595F;
            this.MAHD.HeaderText = "Mã HD";
            this.MAHD.MinimumWidth = 6;
            this.MAHD.Name = "MAHD";
            this.MAHD.Visible = false;
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MAPT";
            this.MAPT.FillWeight = 101.3307F;
            this.MAPT.HeaderText = "Mã Phòng";
            this.MAPT.MinimumWidth = 6;
            this.MAPT.Name = "MAPT";
            // 
            // MAQL
            // 
            this.MAQL.DataPropertyName = "MAQL";
            this.MAQL.FillWeight = 105.2318F;
            this.MAQL.HeaderText = "Tên Người Lập";
            this.MAQL.MinimumWidth = 6;
            this.MAQL.Name = "MAQL";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.FillWeight = 108.1405F;
            this.NGAYLAP.HeaderText = "Ngày Lập";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // NGAYTHANHTOAN
            // 
            this.NGAYTHANHTOAN.DataPropertyName = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.FillWeight = 112.4784F;
            this.NGAYTHANHTOAN.HeaderText = "Ngày Thanh Toán";
            this.NGAYTHANHTOAN.MinimumWidth = 6;
            this.NGAYTHANHTOAN.Name = "NGAYTHANHTOAN";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.FillWeight = 81.53487F;
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // TIENDATHANHTOAN
            // 
            this.TIENDATHANHTOAN.DataPropertyName = "TIENDATHANHTOAN";
            this.TIENDATHANHTOAN.FillWeight = 83.09194F;
            this.TIENDATHANHTOAN.HeaderText = "Tiền Đã Thanh Toán";
            this.TIENDATHANHTOAN.MinimumWidth = 6;
            this.TIENDATHANHTOAN.Name = "TIENDATHANHTOAN";
            // 
            // CONGNO
            // 
            this.CONGNO.DataPropertyName = "CONGNO";
            this.CONGNO.FillWeight = 85.38509F;
            this.CONGNO.HeaderText = "Công Nợ";
            this.CONGNO.MinimumWidth = 6;
            this.CONGNO.Name = "CONGNO";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.FillWeight = 121.1574F;
            this.MOTA.HeaderText = "Mô Tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::GUI.Properties.Resources.LabelPrinter;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(1299, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.guna2Button1.Size = new System.Drawing.Size(141, 48);
            this.guna2Button1.TabIndex = 108;
            this.guna2Button1.Text = "In hóa đơn";
            // 
            // btnThemNT
            // 
            this.btnThemNT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(159)))), ((int)(((byte)(133)))));
            this.btnThemNT.BorderRadius = 4;
            this.btnThemNT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnThemNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNT.ForeColor = System.Drawing.Color.White;
            this.btnThemNT.Image = global::GUI.Properties.Resources.Estimate;
            this.btnThemNT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemNT.Location = new System.Drawing.Point(1179, 12);
            this.btnThemNT.Name = "btnThemNT";
            this.btnThemNT.Size = new System.Drawing.Size(114, 48);
            this.btnThemNT.TabIndex = 21;
            this.btnThemNT.Text = "Tính tiền";
            this.btnThemNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemNT.Click += new System.EventHandler(this.btnThemNT_Click);
            // 
            // btnSuaNT
            // 
            this.btnSuaNT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnSuaNT.BorderRadius = 4;
            this.btnSuaNT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaNT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaNT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaNT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaNT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.btnSuaNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNT.ForeColor = System.Drawing.Color.White;
            this.btnSuaNT.Image = global::GUI.Properties.Resources.MoneyBill;
            this.btnSuaNT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuaNT.Location = new System.Drawing.Point(1446, 12);
            this.btnSuaNT.Name = "btnSuaNT";
            this.btnSuaNT.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSuaNT.Size = new System.Drawing.Size(122, 48);
            this.btnSuaNT.TabIndex = 20;
            this.btnSuaNT.Text = "Tính tiền";
            // 
            // btnXoaNT
            // 
            this.btnXoaNT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(159)))), ((int)(((byte)(133)))));
            this.btnXoaNT.BorderRadius = 4;
            this.btnXoaNT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaNT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaNT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoaNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNT.ForeColor = System.Drawing.Color.White;
            this.btnXoaNT.Image = global::GUI.Properties.Resources.Delete;
            this.btnXoaNT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaNT.Location = new System.Drawing.Point(1574, 12);
            this.btnXoaNT.Name = "btnXoaNT";
            this.btnXoaNT.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnXoaNT.Size = new System.Drawing.Size(86, 48);
            this.btnXoaNT.TabIndex = 19;
            this.btnXoaNT.Text = "Xóa";
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnHuyTimKiem.BorderRadius = 5;
            this.btnHuyTimKiem.BorderThickness = 2;
            this.btnHuyTimKiem.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.CustomBorderColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuyTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuyTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyTimKiem.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.FillColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.FocusedColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnHuyTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuyTimKiem.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuyTimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuyTimKiem.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.Location = new System.Drawing.Point(790, 12);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.PressedColor = System.Drawing.Color.Blue;
            this.btnHuyTimKiem.Size = new System.Drawing.Size(109, 35);
            this.btnHuyTimKiem.TabIndex = 109;
            this.btnHuyTimKiem.Text = "Hủy";
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // frmTinhTienPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 948);
            this.Controls.Add(this.btnHuyTimKiem);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNT);
            this.Controls.Add(this.txtThangNam);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.btnThemNT);
            this.Controls.Add(this.btnSuaNT);
            this.Controls.Add(this.btnXoaNT);
            this.Name = "frmTinhTienPhong";
            this.Text = "Tính tiền phòng";
            this.Load += new System.EventHandler(this.frmTinhTienPhong_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThemNT;
        private Guna.UI2.WinForms.Guna2Button btnSuaNT;
        private Guna.UI2.WinForms.Guna2Button btnXoaNT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label txtThangNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNT;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDATHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnHuyTimKiem;
    }
}