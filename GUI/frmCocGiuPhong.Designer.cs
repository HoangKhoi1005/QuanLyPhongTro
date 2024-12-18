namespace GUI
{
    partial class frmCocGiuPhong
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
            this.btnXuatPhieuNhap = new FontAwesome.Sharp.IconButton();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEUNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvPhieuDat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MAPDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAPPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDUKIENNHANPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDATPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtTraCuuMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTraCuuMaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTraCuuHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatPhieuNhap
            // 
            this.btnXuatPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.btnXuatPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnXuatPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnXuatPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnXuatPhieuNhap.IconColor = System.Drawing.Color.White;
            this.btnXuatPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatPhieuNhap.Location = new System.Drawing.Point(1397, 875);
            this.btnXuatPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatPhieuNhap.Name = "btnXuatPhieuNhap";
            this.btnXuatPhieuNhap.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnXuatPhieuNhap.Size = new System.Drawing.Size(263, 60);
            this.btnXuatPhieuNhap.TabIndex = 59;
            this.btnXuatPhieuNhap.Tag = "Sửa";
            this.btnXuatPhieuNhap.Text = "In phiếu đặt phòng";
            this.btnXuatPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatPhieuNhap.UseVisualStyleBackColor = false;
            this.btnXuatPhieuNhap.Click += new System.EventHandler(this.btnXuatPhieuNhap_Click);
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.FillWeight = 60F;
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 125;
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Nhà cung cấp";
            this.TENNCC.MinimumWidth = 6;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.ReadOnly = true;
            this.TENNCC.Width = 125;
            // 
            // HOTENNV
            // 
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Nhân viên nhập";
            this.HOTENNV.MinimumWidth = 6;
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.ReadOnly = true;
            this.HOTENNV.Width = 125;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.MinimumWidth = 6;
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            this.NGAYNHAP.Width = 125;
            // 
            // MAPHIEUNHAP
            // 
            this.MAPHIEUNHAP.DataPropertyName = "MAPHIEUNHAP";
            this.MAPHIEUNHAP.HeaderText = "Mã phiếu nhập";
            this.MAPHIEUNHAP.MinimumWidth = 6;
            this.MAPHIEUNHAP.Name = "MAPHIEUNHAP";
            this.MAPHIEUNHAP.ReadOnly = true;
            this.MAPHIEUNHAP.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 875);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnThem.Size = new System.Drawing.Size(242, 60);
            this.btnThem.TabIndex = 58;
            this.btnThem.Tag = "Thêm";
            this.btnThem.Text = "Thêm phiếu đặt";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Visible = false;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.dgvPhieuDat);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 68);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1648, 789);
            this.guna2GroupBox2.TabIndex = 55;
            this.guna2GroupBox2.Text = "Danh sách phiếu đặt phòng";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPhieuDat
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPhieuDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuDat.ColumnHeadersHeight = 30;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPDP,
            this.MAPT,
            this.DIACHI,
            this.HOTEN,
            this.NGAYLAPPHIEU,
            this.NGAYDUKIENNHANPHONG,
            this.TIENDATPHONG,
            this.MOTA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuDat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuDat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuDat.Location = new System.Drawing.Point(0, 40);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.RowHeadersVisible = false;
            this.dgvPhieuDat.RowHeadersWidth = 51;
            this.dgvPhieuDat.RowTemplate.Height = 50;
            this.dgvPhieuDat.RowTemplate.ReadOnly = true;
            this.dgvPhieuDat.Size = new System.Drawing.Size(1648, 749);
            this.dgvPhieuDat.TabIndex = 46;
            this.dgvPhieuDat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuDat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhieuDat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuDat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhieuDat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuDat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuDat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuDat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhieuDat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhieuDat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhieuDat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhieuDat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhieuDat.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPhieuDat.ThemeStyle.ReadOnly = false;
            this.dgvPhieuDat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuDat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuDat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhieuDat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhieuDat.ThemeStyle.RowsStyle.Height = 50;
            this.dgvPhieuDat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuDat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MAPDP
            // 
            this.MAPDP.DataPropertyName = "MAPDP";
            this.MAPDP.FillWeight = 102.7595F;
            this.MAPDP.HeaderText = "Mã Phiếu Đặt";
            this.MAPDP.MinimumWidth = 6;
            this.MAPDP.Name = "MAPDP";
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MAPT";
            this.MAPT.FillWeight = 83.63564F;
            this.MAPT.HeaderText = "Mã Phòng";
            this.MAPT.MinimumWidth = 6;
            this.MAPT.Name = "MAPT";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "HOTENNV";
            this.DIACHI.FillWeight = 86.85548F;
            this.DIACHI.HeaderText = "Người Lập";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.FillWeight = 89.2562F;
            this.HOTEN.HeaderText = "Người Thuê";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // NGAYLAPPHIEU
            // 
            this.NGAYLAPPHIEU.DataPropertyName = "NGAYLAPPHIEU";
            this.NGAYLAPPHIEU.FillWeight = 92.83664F;
            this.NGAYLAPPHIEU.HeaderText = "Ngày Lập";
            this.NGAYLAPPHIEU.MinimumWidth = 6;
            this.NGAYLAPPHIEU.Name = "NGAYLAPPHIEU";
            // 
            // NGAYDUKIENNHANPHONG
            // 
            this.NGAYDUKIENNHANPHONG.DataPropertyName = "NGAYDUKIENNHANPHONG";
            this.NGAYDUKIENNHANPHONG.FillWeight = 96.03417F;
            this.NGAYDUKIENNHANPHONG.HeaderText = "Ngày Nhận Phòng";
            this.NGAYDUKIENNHANPHONG.MinimumWidth = 6;
            this.NGAYDUKIENNHANPHONG.Name = "NGAYDUKIENNHANPHONG";
            // 
            // TIENDATPHONG
            // 
            this.TIENDATPHONG.DataPropertyName = "TIENDATPHONG";
            this.TIENDATPHONG.FillWeight = 98.88972F;
            this.TIENDATPHONG.HeaderText = "Tiền Đặt Phòng";
            this.TIENDATPHONG.MinimumWidth = 6;
            this.TIENDATPHONG.Name = "TIENDATPHONG";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.FillWeight = 149.7326F;
            this.MOTA.HeaderText = "Mô Tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
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
            this.btnTraCuu.Location = new System.Drawing.Point(669, 14);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.PressedColor = System.Drawing.Color.Blue;
            this.btnTraCuu.Size = new System.Drawing.Size(109, 35);
            this.btnTraCuu.TabIndex = 54;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTraCuuMaPhieu
            // 
            this.txtTraCuuMaPhieu.BackColor = System.Drawing.Color.Transparent;
            this.txtTraCuuMaPhieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTraCuuMaPhieu.BorderRadius = 5;
            this.txtTraCuuMaPhieu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTraCuuMaPhieu.BorderThickness = 2;
            this.txtTraCuuMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuuMaPhieu.DefaultText = "";
            this.txtTraCuuMaPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuuMaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuuMaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuMaPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuMaPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuuMaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuMaPhieu.Location = new System.Drawing.Point(12, 14);
            this.txtTraCuuMaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuuMaPhieu.Name = "txtTraCuuMaPhieu";
            this.txtTraCuuMaPhieu.PasswordChar = '\0';
            this.txtTraCuuMaPhieu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTraCuuMaPhieu.PlaceholderText = "Nhập mã phiếu để tìm";
            this.txtTraCuuMaPhieu.SelectedText = "";
            this.txtTraCuuMaPhieu.Size = new System.Drawing.Size(213, 35);
            this.txtTraCuuMaPhieu.TabIndex = 53;
            // 
            // txtTraCuuMaPhong
            // 
            this.txtTraCuuMaPhong.BackColor = System.Drawing.Color.Transparent;
            this.txtTraCuuMaPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTraCuuMaPhong.BorderRadius = 5;
            this.txtTraCuuMaPhong.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTraCuuMaPhong.BorderThickness = 2;
            this.txtTraCuuMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuuMaPhong.DefaultText = "";
            this.txtTraCuuMaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuuMaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuuMaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuMaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuMaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuMaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuuMaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuMaPhong.Location = new System.Drawing.Point(231, 14);
            this.txtTraCuuMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuuMaPhong.Name = "txtTraCuuMaPhong";
            this.txtTraCuuMaPhong.PasswordChar = '\0';
            this.txtTraCuuMaPhong.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTraCuuMaPhong.PlaceholderText = "Nhập mã phòng để tìm";
            this.txtTraCuuMaPhong.SelectedText = "";
            this.txtTraCuuMaPhong.Size = new System.Drawing.Size(213, 35);
            this.txtTraCuuMaPhong.TabIndex = 60;
            // 
            // txtTraCuuHoTen
            // 
            this.txtTraCuuHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTraCuuHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTraCuuHoTen.BorderRadius = 5;
            this.txtTraCuuHoTen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTraCuuHoTen.BorderThickness = 2;
            this.txtTraCuuHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuuHoTen.DefaultText = "";
            this.txtTraCuuHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuuHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuuHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuuHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuHoTen.Location = new System.Drawing.Point(450, 14);
            this.txtTraCuuHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuuHoTen.Name = "txtTraCuuHoTen";
            this.txtTraCuuHoTen.PasswordChar = '\0';
            this.txtTraCuuHoTen.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTraCuuHoTen.PlaceholderText = "Nhập họ tên để tìm";
            this.txtTraCuuHoTen.SelectedText = "";
            this.txtTraCuuHoTen.Size = new System.Drawing.Size(213, 35);
            this.txtTraCuuHoTen.TabIndex = 61;
            // 
            // frmCocGiuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 948);
            this.Controls.Add(this.txtTraCuuHoTen);
            this.Controls.Add(this.txtTraCuuMaPhong);
            this.Controls.Add(this.btnXuatPhieuNhap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtTraCuuMaPhieu);
            this.Name = "frmCocGiuPhong";
            this.Text = "Cọc giữ phòng";
            this.Load += new System.EventHandler(this.frmCocGiuPhong_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnXuatPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUNHAP;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhieuDat;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAPPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDUKIENNHANPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDATPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuMaPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuHoTen;
    }
}