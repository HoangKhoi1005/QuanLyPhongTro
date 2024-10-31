namespace GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.groupAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuanLyDichVu = new FontAwesome.Sharp.IconButton();
            this.btnDichVu = new FontAwesome.Sharp.IconButton();
            this.btnChiSoNuoc = new FontAwesome.Sharp.IconButton();
            this.btnChiSoDien = new FontAwesome.Sharp.IconButton();
            this.btnTaiSan = new FontAwesome.Sharp.IconButton();
            this.btnKyLuat = new FontAwesome.Sharp.IconButton();
            this.btnTienPhatSinh = new FontAwesome.Sharp.IconButton();
            this.btnTienPhong = new FontAwesome.Sharp.IconButton();
            this.btnHopDong = new FontAwesome.Sharp.IconButton();
            this.btnKhachTro = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnCocGiuPhong = new FontAwesome.Sharp.IconButton();
            this.btnPhong = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnThuPhongMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.groupAdmin.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.groupAdmin);
            this.panelMenu.Controls.Add(this.btnTaiSan);
            this.panelMenu.Controls.Add(this.btnKyLuat);
            this.panelMenu.Controls.Add(this.btnTienPhatSinh);
            this.panelMenu.Controls.Add(this.btnTienPhong);
            this.panelMenu.Controls.Add(this.btnHopDong);
            this.panelMenu.Controls.Add(this.btnKhachTro);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.btnCocGiuPhong);
            this.panelMenu.Controls.Add(this.btnPhong);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 962);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.IconSize = 32;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 760);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(230, 60);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Tag = "Đăng xuất";
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // groupAdmin
            // 
            this.groupAdmin.Controls.Add(this.btnQuanLyDichVu);
            this.groupAdmin.Controls.Add(this.btnDichVu);
            this.groupAdmin.Controls.Add(this.btnChiSoNuoc);
            this.groupAdmin.Controls.Add(this.btnChiSoDien);
            this.groupAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAdmin.Location = new System.Drawing.Point(0, 700);
            this.groupAdmin.Name = "groupAdmin";
            this.groupAdmin.Size = new System.Drawing.Size(230, 60);
            this.groupAdmin.TabIndex = 14;
            // 
            // btnQuanLyDichVu
            // 
            this.btnQuanLyDichVu.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDichVu.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnQuanLyDichVu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLyDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyDichVu.IconSize = 32;
            this.btnQuanLyDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDichVu.Location = new System.Drawing.Point(3, 3);
            this.btnQuanLyDichVu.Name = "btnQuanLyDichVu";
            this.btnQuanLyDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQuanLyDichVu.Size = new System.Drawing.Size(220, 60);
            this.btnQuanLyDichVu.TabIndex = 16;
            this.btnQuanLyDichVu.Tag = "Quản lý dịch vụ";
            this.btnQuanLyDichVu.Text = "Quản lý dịch vụ";
            this.btnQuanLyDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyDichVu.UseVisualStyleBackColor = true;
            this.btnQuanLyDichVu.Click += new System.EventHandler(this.btnQuanLyDichVu_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnDichVu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDichVu.IconSize = 32;
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(3, 69);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDichVu.Size = new System.Drawing.Size(220, 60);
            this.btnDichVu.TabIndex = 3;
            this.btnDichVu.Tag = "Dịch vụ";
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnChiSoNuoc
            // 
            this.btnChiSoNuoc.FlatAppearance.BorderSize = 0;
            this.btnChiSoNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiSoNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiSoNuoc.IconChar = FontAwesome.Sharp.IconChar.Droplet;
            this.btnChiSoNuoc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChiSoNuoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiSoNuoc.IconSize = 32;
            this.btnChiSoNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiSoNuoc.Location = new System.Drawing.Point(3, 135);
            this.btnChiSoNuoc.Name = "btnChiSoNuoc";
            this.btnChiSoNuoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChiSoNuoc.Size = new System.Drawing.Size(220, 60);
            this.btnChiSoNuoc.TabIndex = 5;
            this.btnChiSoNuoc.Tag = "Chỉ số nước";
            this.btnChiSoNuoc.Text = "Chỉ số nước";
            this.btnChiSoNuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiSoNuoc.UseVisualStyleBackColor = true;
            this.btnChiSoNuoc.Click += new System.EventHandler(this.btnChiSoNuoc_Click);
            // 
            // btnChiSoDien
            // 
            this.btnChiSoDien.FlatAppearance.BorderSize = 0;
            this.btnChiSoDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiSoDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiSoDien.IconChar = FontAwesome.Sharp.IconChar.Zap;
            this.btnChiSoDien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChiSoDien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiSoDien.IconSize = 32;
            this.btnChiSoDien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiSoDien.Location = new System.Drawing.Point(3, 201);
            this.btnChiSoDien.Name = "btnChiSoDien";
            this.btnChiSoDien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChiSoDien.Size = new System.Drawing.Size(220, 60);
            this.btnChiSoDien.TabIndex = 4;
            this.btnChiSoDien.Tag = "Chỉ số điện";
            this.btnChiSoDien.Text = "Chỉ số điện";
            this.btnChiSoDien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiSoDien.UseVisualStyleBackColor = true;
            this.btnChiSoDien.Click += new System.EventHandler(this.btnChiSoDien_Click);
            // 
            // btnTaiSan
            // 
            this.btnTaiSan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiSan.FlatAppearance.BorderSize = 0;
            this.btnTaiSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiSan.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
            this.btnTaiSan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTaiSan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiSan.IconSize = 32;
            this.btnTaiSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiSan.Location = new System.Drawing.Point(0, 640);
            this.btnTaiSan.Name = "btnTaiSan";
            this.btnTaiSan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTaiSan.Size = new System.Drawing.Size(230, 60);
            this.btnTaiSan.TabIndex = 9;
            this.btnTaiSan.Tag = "Tài sản";
            this.btnTaiSan.Text = "Tài sản";
            this.btnTaiSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiSan.UseVisualStyleBackColor = true;
            this.btnTaiSan.Click += new System.EventHandler(this.btnTaiSan_Click);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKyLuat.FlatAppearance.BorderSize = 0;
            this.btnKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyLuat.IconChar = FontAwesome.Sharp.IconChar.FileShield;
            this.btnKyLuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKyLuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKyLuat.IconSize = 32;
            this.btnKyLuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKyLuat.Location = new System.Drawing.Point(0, 580);
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKyLuat.Size = new System.Drawing.Size(230, 60);
            this.btnKyLuat.TabIndex = 16;
            this.btnKyLuat.Tag = "Kỷ luật";
            this.btnKyLuat.Text = "Kỷ luật";
            this.btnKyLuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKyLuat.UseVisualStyleBackColor = true;
            this.btnKyLuat.Click += new System.EventHandler(this.btnKyLuat_Click);
            // 
            // btnTienPhatSinh
            // 
            this.btnTienPhatSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTienPhatSinh.FlatAppearance.BorderSize = 0;
            this.btnTienPhatSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienPhatSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienPhatSinh.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnTienPhatSinh.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTienPhatSinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTienPhatSinh.IconSize = 32;
            this.btnTienPhatSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienPhatSinh.Location = new System.Drawing.Point(0, 520);
            this.btnTienPhatSinh.Name = "btnTienPhatSinh";
            this.btnTienPhatSinh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTienPhatSinh.Size = new System.Drawing.Size(230, 60);
            this.btnTienPhatSinh.TabIndex = 6;
            this.btnTienPhatSinh.Tag = "Tiền phát sinh";
            this.btnTienPhatSinh.Text = "Tiền phát sinh";
            this.btnTienPhatSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTienPhatSinh.UseVisualStyleBackColor = true;
            this.btnTienPhatSinh.Click += new System.EventHandler(this.btnTienPhatSinh_Click);
            // 
            // btnTienPhong
            // 
            this.btnTienPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTienPhong.FlatAppearance.BorderSize = 0;
            this.btnTienPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienPhong.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnTienPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTienPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTienPhong.IconSize = 32;
            this.btnTienPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienPhong.Location = new System.Drawing.Point(0, 460);
            this.btnTienPhong.Name = "btnTienPhong";
            this.btnTienPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTienPhong.Size = new System.Drawing.Size(230, 60);
            this.btnTienPhong.TabIndex = 7;
            this.btnTienPhong.Tag = "Tính tiền phòng";
            this.btnTienPhong.Text = "Tính tiền phòng";
            this.btnTienPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTienPhong.UseVisualStyleBackColor = true;
            this.btnTienPhong.Click += new System.EventHandler(this.btnTienPhong_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnHopDong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHopDong.IconSize = 32;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.Location = new System.Drawing.Point(0, 400);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHopDong.Size = new System.Drawing.Size(230, 60);
            this.btnHopDong.TabIndex = 12;
            this.btnHopDong.Tag = "Hợp đồng";
            this.btnHopDong.Text = "Hợp đồng";
            this.btnHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnKhachTro
            // 
            this.btnKhachTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachTro.FlatAppearance.BorderSize = 0;
            this.btnKhachTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachTro.IconChar = FontAwesome.Sharp.IconChar.PersonShelter;
            this.btnKhachTro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachTro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachTro.IconSize = 32;
            this.btnKhachTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachTro.Location = new System.Drawing.Point(0, 340);
            this.btnKhachTro.Name = "btnKhachTro";
            this.btnKhachTro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhachTro.Size = new System.Drawing.Size(230, 60);
            this.btnKhachTro.TabIndex = 15;
            this.btnKhachTro.Tag = "Khách trọ";
            this.btnKhachTro.Text = "Khách trọ";
            this.btnKhachTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachTro.UseVisualStyleBackColor = true;
            this.btnKhachTro.Click += new System.EventHandler(this.btnKhachTro_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.IconSize = 32;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 280);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(230, 60);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Tag = "Nhân viên";
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnCocGiuPhong
            // 
            this.btnCocGiuPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCocGiuPhong.FlatAppearance.BorderSize = 0;
            this.btnCocGiuPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocGiuPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocGiuPhong.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnCocGiuPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCocGiuPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCocGiuPhong.IconSize = 32;
            this.btnCocGiuPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCocGiuPhong.Location = new System.Drawing.Point(0, 220);
            this.btnCocGiuPhong.Name = "btnCocGiuPhong";
            this.btnCocGiuPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCocGiuPhong.Size = new System.Drawing.Size(230, 60);
            this.btnCocGiuPhong.TabIndex = 10;
            this.btnCocGiuPhong.Tag = "Cọc giữ phòng";
            this.btnCocGiuPhong.Text = "Cọc giữ phòng";
            this.btnCocGiuPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCocGiuPhong.UseVisualStyleBackColor = true;
            this.btnCocGiuPhong.Click += new System.EventHandler(this.btnCocGiuPhong_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhong.IconSize = 32;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(0, 160);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPhong.Size = new System.Drawing.Size(230, 60);
            this.btnPhong.TabIndex = 2;
            this.btnPhong.Tag = "Phòng";
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.btnTrangChu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.IconSize = 32;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 100);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(230, 60);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Tag = "Trang chủ";
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnThuPhongMenu);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnThuPhongMenu
            // 
            this.btnThuPhongMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThuPhongMenu.FlatAppearance.BorderSize = 0;
            this.btnThuPhongMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuPhongMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnThuPhongMenu.IconColor = System.Drawing.Color.White;
            this.btnThuPhongMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThuPhongMenu.Location = new System.Drawing.Point(172, 0);
            this.btnThuPhongMenu.Name = "btnThuPhongMenu";
            this.btnThuPhongMenu.Size = new System.Drawing.Size(58, 100);
            this.btnThuPhongMenu.TabIndex = 5;
            this.btnThuPhongMenu.Tag = "menu";
            this.btnThuPhongMenu.UseVisualStyleBackColor = true;
            this.btnThuPhongMenu.Click += new System.EventHandler(this.btnThuPhongMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitleBar.Controls.Add(this.guna2ControlBox3);
            this.panelTitleBar.Controls.Add(this.guna2ControlBox2);
            this.panelTitleBar.Controls.Add(this.guna2ControlBox1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(923, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(773, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(824, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(875, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitleChildForm.Location = new System.Drawing.Point(58, 18);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(157, 41);
            this.lblTitleChildForm.TabIndex = 5;
            this.lblTitleChildForm.Text = "Trang chủ";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 45;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 18);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 45);
            this.iconCurrentChildForm.TabIndex = 4;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(230, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(923, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(923, 878);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GUI.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(399, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 1;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 962);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.groupAdmin.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnTienPhatSinh;
        private FontAwesome.Sharp.IconButton btnChiSoNuoc;
        private FontAwesome.Sharp.IconButton btnChiSoDien;
        private FontAwesome.Sharp.IconButton btnDichVu;
        private FontAwesome.Sharp.IconButton btnPhong;
        private FontAwesome.Sharp.IconButton btnCocGiuPhong;
        private FontAwesome.Sharp.IconButton btnTaiSan;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnTienPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private FontAwesome.Sharp.IconButton btnThuPhongMenu;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnHopDong;
        private System.Windows.Forms.FlowLayoutPanel groupAdmin;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FontAwesome.Sharp.IconButton btnQuanLyDichVu;
        private FontAwesome.Sharp.IconButton btnKhachTro;
        private FontAwesome.Sharp.IconButton btnKyLuat;
    }
}

