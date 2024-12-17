namespace GUI
{
    partial class frmChiSoNuoc
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
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtTraCuu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.dgvChiSo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MACS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoDienCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoNuocCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHISODIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHISONUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnLuuSua = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayThang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnTaiAnh = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).BeginInit();
            this.SuspendLayout();
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
            this.btnTraCuu.Location = new System.Drawing.Point(300, 13);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.PressedColor = System.Drawing.Color.Blue;
            this.btnTraCuu.Size = new System.Drawing.Size(109, 43);
            this.btnTraCuu.TabIndex = 54;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.txtTraCuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTraCuu.BorderRadius = 5;
            this.txtTraCuu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTraCuu.BorderThickness = 2;
            this.txtTraCuu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuu.DefaultText = "";
            this.txtTraCuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuu.Location = new System.Drawing.Point(12, 13);
            this.txtTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.PasswordChar = '\0';
            this.txtTraCuu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTraCuu.PlaceholderText = "Nhập vào thông tin để tra cứu";
            this.txtTraCuu.SelectedText = "";
            this.txtTraCuu.Size = new System.Drawing.Size(269, 43);
            this.txtTraCuu.TabIndex = 53;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.pbAnh);
            this.guna2GroupBox2.Controls.Add(this.dgvChiSo);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 62);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1589, 587);
            this.guna2GroupBox2.TabIndex = 65;
            this.guna2GroupBox2.Text = "Danh sách chỉ số điện nước";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(0, 1);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(641, 491);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 47;
            this.pbAnh.TabStop = false;
            this.pbAnh.Visible = false;
            this.pbAnh.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAnh_Paint);
            this.pbAnh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAnh_MouseDown);
            this.pbAnh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbAnh_MouseUp);
            // 
            // dgvChiSo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiSo.ColumnHeadersHeight = 50;
            this.dgvChiSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACS,
            this.MAPT,
            this.NGAYTHANG,
            this.ChiSoDienCu,
            this.ChiSoNuocCu,
            this.CHISODIEN,
            this.CHISONUOC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiSo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiSo.Location = new System.Drawing.Point(0, 40);
            this.dgvChiSo.Name = "dgvChiSo";
            this.dgvChiSo.RowHeadersVisible = false;
            this.dgvChiSo.RowHeadersWidth = 51;
            this.dgvChiSo.RowTemplate.Height = 50;
            this.dgvChiSo.Size = new System.Drawing.Size(1589, 547);
            this.dgvChiSo.TabIndex = 46;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiSo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChiSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiSo.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvChiSo.ThemeStyle.ReadOnly = false;
            this.dgvChiSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvChiSo.ThemeStyle.RowsStyle.Height = 50;
            this.dgvChiSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiSo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvChiSo_CellValidating);
            // 
            // MACS
            // 
            this.MACS.DataPropertyName = "MACS";
            this.MACS.HeaderText = "Mã chỉ số";
            this.MACS.MinimumWidth = 6;
            this.MACS.Name = "MACS";
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MAPT";
            this.MAPT.HeaderText = "Mã phòng trọ";
            this.MAPT.MinimumWidth = 6;
            this.MAPT.Name = "MAPT";
            // 
            // NGAYTHANG
            // 
            this.NGAYTHANG.DataPropertyName = "NGAYTHANG";
            this.NGAYTHANG.HeaderText = "Ngày tháng";
            this.NGAYTHANG.MinimumWidth = 6;
            this.NGAYTHANG.Name = "NGAYTHANG";
            // 
            // ChiSoDienCu
            // 
            this.ChiSoDienCu.DataPropertyName = "ChiSoDienCu";
            this.ChiSoDienCu.HeaderText = "Chỉ số điện cũ";
            this.ChiSoDienCu.MinimumWidth = 6;
            this.ChiSoDienCu.Name = "ChiSoDienCu";
            // 
            // ChiSoNuocCu
            // 
            this.ChiSoNuocCu.DataPropertyName = "ChiSoNuocCu";
            this.ChiSoNuocCu.HeaderText = "Chỉ số nước cũ";
            this.ChiSoNuocCu.MinimumWidth = 6;
            this.ChiSoNuocCu.Name = "ChiSoNuocCu";
            // 
            // CHISODIEN
            // 
            this.CHISODIEN.DataPropertyName = "CHISODIEN";
            this.CHISODIEN.HeaderText = "Chỉ số điện";
            this.CHISODIEN.MinimumWidth = 6;
            this.CHISODIEN.Name = "CHISODIEN";
            // 
            // CHISONUOC
            // 
            this.CHISONUOC.DataPropertyName = "CHISONUOC";
            this.CHISONUOC.HeaderText = "Chỉ số nước";
            this.CHISONUOC.MinimumWidth = 6;
            this.CHISONUOC.Name = "CHISONUOC";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 35;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(150, 666);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnXoa.Size = new System.Drawing.Size(131, 60);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Tag = "Thêm";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnLuuSua.FlatAppearance.BorderSize = 0;
            this.btnLuuSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSua.ForeColor = System.Drawing.Color.White;
            this.btnLuuSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnLuuSua.IconColor = System.Drawing.Color.White;
            this.btnLuuSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuSua.IconSize = 35;
            this.btnLuuSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuSua.Location = new System.Drawing.Point(12, 666);
            this.btnLuuSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnLuuSua.Size = new System.Drawing.Size(130, 60);
            this.btnLuuSua.TabIndex = 66;
            this.btnLuuSua.Tag = "Thêm";
            this.btnLuuSua.Text = "Lưu";
            this.btnLuuSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuSua.UseVisualStyleBackColor = false;
            this.btnLuuSua.Click += new System.EventHandler(this.btnLuuSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(493, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 118;
            this.label6.Text = "Chọn Tháng:";
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.Checked = true;
            this.dtpNgayThang.FillColor = System.Drawing.Color.White;
            this.dtpNgayThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayThang.Location = new System.Drawing.Point(607, 19);
            this.dtpNgayThang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayThang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(260, 33);
            this.dtpNgayThang.TabIndex = 119;
            this.dtpNgayThang.Value = new System.DateTime(2024, 11, 11, 0, 0, 0, 0);
            this.dtpNgayThang.ValueChanged += new System.EventHandler(this.dtpNgayThang_ValueChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnHuy.IconColor = System.Drawing.Color.White;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 40;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(287, 666);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnHuy.Size = new System.Drawing.Size(131, 60);
            this.btnHuy.TabIndex = 120;
            this.btnHuy.Tag = "Thêm";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnTaiAnh.FlatAppearance.BorderSize = 0;
            this.btnTaiAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiAnh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnh.ForeColor = System.Drawing.Color.White;
            this.btnTaiAnh.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnTaiAnh.IconColor = System.Drawing.Color.White;
            this.btnTaiAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiAnh.IconSize = 35;
            this.btnTaiAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiAnh.Location = new System.Drawing.Point(1433, 10);
            this.btnTaiAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnTaiAnh.Size = new System.Drawing.Size(168, 48);
            this.btnTaiAnh.TabIndex = 121;
            this.btnTaiAnh.Tag = "Thêm";
            this.btnTaiAnh.Text = "Tải ảnh";
            this.btnTaiAnh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiAnh.UseVisualStyleBackColor = false;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1191, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 122;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 123;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1354, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 33);
            this.button1.TabIndex = 124;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChiSoNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 737);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgayThang);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuSua);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtTraCuu);
            this.Name = "frmChiSoNuoc";
            this.Text = "Chỉ số điện nước";
            this.Load += new System.EventHandler(this.frmChiSoNuoc_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuu;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiSo;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnLuuSua;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayThang;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoDienCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoNuocCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHISODIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHISONUOC;
        private FontAwesome.Sharp.IconButton btnTaiAnh;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}