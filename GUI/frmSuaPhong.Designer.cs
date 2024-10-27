namespace GUI
{
    partial class frmSuaPhong
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpNoiDung = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHopDong = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTInPhongTro = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(251, 13);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(391, 38);
            this.lblTieuDe.TabIndex = 107;
            this.lblTieuDe.Text = "SỬA THÔNG TIN PHÒNG TRỌ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpNoiDung);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 788);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            // 
            // grpNoiDung
            // 
            this.grpNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNoiDung.Location = new System.Drawing.Point(3, 82);
            this.grpNoiDung.Name = "grpNoiDung";
            this.grpNoiDung.Size = new System.Drawing.Size(1022, 703);
            this.grpNoiDung.TabIndex = 1;
            this.grpNoiDung.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHopDong);
            this.panel1.Controls.Add(this.btnThanhVien);
            this.panel1.Controls.Add(this.btnDichVu);
            this.panel1.Controls.Add(this.btnThongTInPhongTro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnHopDong
            // 
            this.btnHopDong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHopDong.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHopDong.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHopDong.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHopDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHopDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHopDong.FillColor = System.Drawing.Color.White;
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHopDong.ForeColor = System.Drawing.Color.Black;
            this.btnHopDong.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHopDong.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHopDong.Location = new System.Drawing.Point(495, 0);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(155, 64);
            this.btnHopDong.TabIndex = 25;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhVien.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThanhVien.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnThanhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThanhVien.FillColor = System.Drawing.Color.White;
            this.btnThanhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThanhVien.ForeColor = System.Drawing.Color.Black;
            this.btnThanhVien.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThanhVien.Location = new System.Drawing.Point(340, 0);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(155, 64);
            this.btnThanhVien.TabIndex = 24;
            this.btnThanhVien.Text = "Thành Viên";
            this.btnThanhVien.Click += new System.EventHandler(this.btnThanhVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDichVu.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDichVu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDichVu.FillColor = System.Drawing.Color.White;
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDichVu.Location = new System.Drawing.Point(185, 0);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(155, 64);
            this.btnDichVu.TabIndex = 23;
            this.btnDichVu.Text = "Dịch Vụ";
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnThongTInPhongTro
            // 
            this.btnThongTInPhongTro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTInPhongTro.Checked = true;
            this.btnThongTInPhongTro.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTInPhongTro.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongTInPhongTro.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnThongTInPhongTro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTInPhongTro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTInPhongTro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTInPhongTro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTInPhongTro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongTInPhongTro.FillColor = System.Drawing.Color.White;
            this.btnThongTInPhongTro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongTInPhongTro.ForeColor = System.Drawing.Color.Black;
            this.btnThongTInPhongTro.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTInPhongTro.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThongTInPhongTro.Location = new System.Drawing.Point(0, 0);
            this.btnThongTInPhongTro.Name = "btnThongTInPhongTro";
            this.btnThongTInPhongTro.Size = new System.Drawing.Size(185, 64);
            this.btnThongTInPhongTro.TabIndex = 22;
            this.btnThongTInPhongTro.Text = "Thông Tin Phòng Trọ";
            this.btnThongTInPhongTro.Click += new System.EventHandler(this.btnThongTInPhongTro_Click);
            // 
            // frmSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 865);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmSuaPhong";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnHopDong;
        private Guna.UI2.WinForms.Guna2Button btnThanhVien;
        private Guna.UI2.WinForms.Guna2Button btnDichVu;
        private Guna.UI2.WinForms.Guna2Button btnThongTInPhongTro;
        private System.Windows.Forms.GroupBox grpNoiDung;
    }
}