namespace GUI
{
    partial class frmKhachTro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTraCuu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvKhachTro = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaKhachTro = new FontAwesome.Sharp.IconButton();
            this.btnSuaKhachTro = new FontAwesome.Sharp.IconButton();
            this.btnThemKhachTro = new FontAwesome.Sharp.IconButton();
            this.MAKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAXOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachTro)).BeginInit();
            this.SuspendLayout();
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
            this.txtTraCuu.Location = new System.Drawing.Point(29, 13);
            this.txtTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.PasswordChar = '\0';
            this.txtTraCuu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTraCuu.PlaceholderText = "Nhập vào khách trọ muốn tìm";
            this.txtTraCuu.SelectedText = "";
            this.txtTraCuu.Size = new System.Drawing.Size(269, 43);
            this.txtTraCuu.TabIndex = 60;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.dgvKhachTro);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(29, 74);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1589, 530);
            this.guna2GroupBox2.TabIndex = 59;
            this.guna2GroupBox2.Text = "Danh sách khách trọ";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvKhachTro
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvKhachTro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKhachTro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvKhachTro.ColumnHeadersHeight = 50;
            this.dgvKhachTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKT,
            this.HOTEN,
            this.DIACHI,
            this.SODT,
            this.CCCD,
            this.EMAIL,
            this.NGAYSINH,
            this.GIOITINH,
            this.ANH,
            this.MOTA,
            this.DAXOA});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachTro.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKhachTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachTro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachTro.Location = new System.Drawing.Point(0, 40);
            this.dgvKhachTro.Name = "dgvKhachTro";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachTro.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvKhachTro.RowHeadersVisible = false;
            this.dgvKhachTro.RowHeadersWidth = 51;
            this.dgvKhachTro.RowTemplate.Height = 50;
            this.dgvKhachTro.RowTemplate.ReadOnly = true;
            this.dgvKhachTro.Size = new System.Drawing.Size(1589, 490);
            this.dgvKhachTro.TabIndex = 46;
            this.dgvKhachTro.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachTro.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachTro.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachTro.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachTro.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachTro.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachTro.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachTro.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhachTro.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKhachTro.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachTro.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachTro.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachTro.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvKhachTro.ThemeStyle.ReadOnly = false;
            this.dgvKhachTro.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachTro.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachTro.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachTro.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachTro.ThemeStyle.RowsStyle.Height = 50;
            this.dgvKhachTro.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachTro.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnTraCuu.Location = new System.Drawing.Point(317, 13);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.PressedColor = System.Drawing.Color.Blue;
            this.btnTraCuu.Size = new System.Drawing.Size(109, 43);
            this.btnTraCuu.TabIndex = 61;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnXoaKhachTro
            // 
            this.btnXoaKhachTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaKhachTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoaKhachTro.FlatAppearance.BorderSize = 0;
            this.btnXoaKhachTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhachTro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhachTro.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhachTro.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaKhachTro.IconColor = System.Drawing.Color.White;
            this.btnXoaKhachTro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaKhachTro.IconSize = 35;
            this.btnXoaKhachTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKhachTro.Location = new System.Drawing.Point(483, 617);
            this.btnXoaKhachTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKhachTro.Name = "btnXoaKhachTro";
            this.btnXoaKhachTro.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnXoaKhachTro.Size = new System.Drawing.Size(215, 60);
            this.btnXoaKhachTro.TabIndex = 64;
            this.btnXoaKhachTro.Tag = "Thêm";
            this.btnXoaKhachTro.Text = "Xóa khách trọ";
            this.btnXoaKhachTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKhachTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaKhachTro.UseVisualStyleBackColor = false;
            this.btnXoaKhachTro.Click += new System.EventHandler(this.btnXoaKhachTro_Click);
            // 
            // btnSuaKhachTro
            // 
            this.btnSuaKhachTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaKhachTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnSuaKhachTro.FlatAppearance.BorderSize = 0;
            this.btnSuaKhachTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKhachTro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachTro.ForeColor = System.Drawing.Color.White;
            this.btnSuaKhachTro.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSuaKhachTro.IconColor = System.Drawing.Color.White;
            this.btnSuaKhachTro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaKhachTro.IconSize = 35;
            this.btnSuaKhachTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKhachTro.Location = new System.Drawing.Point(262, 617);
            this.btnSuaKhachTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaKhachTro.Name = "btnSuaKhachTro";
            this.btnSuaKhachTro.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSuaKhachTro.Size = new System.Drawing.Size(215, 60);
            this.btnSuaKhachTro.TabIndex = 63;
            this.btnSuaKhachTro.Tag = "Thêm";
            this.btnSuaKhachTro.Text = "Sửa khách trọ";
            this.btnSuaKhachTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKhachTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaKhachTro.UseVisualStyleBackColor = false;
            this.btnSuaKhachTro.Click += new System.EventHandler(this.btnSuaKhachTro_Click);
            // 
            // btnThemKhachTro
            // 
            this.btnThemKhachTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemKhachTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.btnThemKhachTro.FlatAppearance.BorderSize = 0;
            this.btnThemKhachTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhachTro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachTro.ForeColor = System.Drawing.Color.White;
            this.btnThemKhachTro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemKhachTro.IconColor = System.Drawing.Color.White;
            this.btnThemKhachTro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemKhachTro.IconSize = 35;
            this.btnThemKhachTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhachTro.Location = new System.Drawing.Point(29, 617);
            this.btnThemKhachTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKhachTro.Name = "btnThemKhachTro";
            this.btnThemKhachTro.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnThemKhachTro.Size = new System.Drawing.Size(227, 60);
            this.btnThemKhachTro.TabIndex = 62;
            this.btnThemKhachTro.Tag = "Thêm";
            this.btnThemKhachTro.Text = "Thêm khách trọ";
            this.btnThemKhachTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhachTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKhachTro.UseVisualStyleBackColor = false;
            this.btnThemKhachTro.Click += new System.EventHandler(this.btnThemKhachTro_Click);
            // 
            // MAKT
            // 
            this.MAKT.DataPropertyName = "MAKT";
            this.MAKT.FillWeight = 102.7595F;
            this.MAKT.HeaderText = "Mã khách trọ";
            this.MAKT.MinimumWidth = 6;
            this.MAKT.Name = "MAKT";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.FillWeight = 83.63564F;
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.FillWeight = 86.85548F;
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            // 
            // SODT
            // 
            this.SODT.DataPropertyName = "SODT";
            this.SODT.FillWeight = 89.2562F;
            this.SODT.HeaderText = "Số ĐT";
            this.SODT.MinimumWidth = 6;
            this.SODT.Name = "SODT";
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            // 
            // ANH
            // 
            this.ANH.DataPropertyName = "ANH";
            this.ANH.HeaderText = "Ảnh";
            this.ANH.MinimumWidth = 6;
            this.ANH.Name = "ANH";
            this.ANH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            // 
            // DAXOA
            // 
            this.DAXOA.DataPropertyName = "DAXOA";
            this.DAXOA.HeaderText = "Đã xóa";
            this.DAXOA.MinimumWidth = 6;
            this.DAXOA.Name = "DAXOA";
            // 
            // frmKhachTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 901);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.btnXoaKhachTro);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSuaKhachTro);
            this.Controls.Add(this.btnThemKhachTro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách trọ";
            this.Load += new System.EventHandler(this.frmKhachTro_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTraCuu;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        public Guna.UI2.WinForms.Guna2DataGridView dgvKhachTro;
        private FontAwesome.Sharp.IconButton btnXoaKhachTro;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private FontAwesome.Sharp.IconButton btnSuaKhachTro;
        private FontAwesome.Sharp.IconButton btnThemKhachTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAXOA;
    }
}