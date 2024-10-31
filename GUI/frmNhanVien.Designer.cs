namespace GUI
{
    partial class frmNhanVien
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
            this.dtpNgayVao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemAnh = new FontAwesome.Sharp.IconButton();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.Checked = true;
            this.dtpNgayVao.FillColor = System.Drawing.Color.White;
            this.dtpNgayVao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayVao.Location = new System.Drawing.Point(1214, 309);
            this.dtpNgayVao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayVao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(403, 30);
            this.dtpNgayVao.TabIndex = 128;
            this.dtpNgayVao.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(1085, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 127;
            this.label2.Text = "Ngày Vào:";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnThemAnh.FlatAppearance.BorderSize = 0;
            this.btnThemAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemAnh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.ForeColor = System.Drawing.Color.White;
            this.btnThemAnh.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemAnh.IconColor = System.Drawing.Color.White;
            this.btnThemAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemAnh.IconSize = 38;
            this.btnThemAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemAnh.Location = new System.Drawing.Point(92, 486);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThemAnh.Size = new System.Drawing.Size(171, 46);
            this.btnThemAnh.TabIndex = 126;
            this.btnThemAnh.Tag = "Xóa";
            this.btnThemAnh.Text = "Thêm Ảnh";
            this.btnThemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemAnh.UseVisualStyleBackColor = false;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // ptbAnh
            // 
            this.ptbAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptbAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAnh.Image = global::GUI.Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
            this.ptbAnh.Location = new System.Drawing.Point(30, 136);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(291, 326);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnh.TabIndex = 125;
            this.ptbAnh.TabStop = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaySinh.Location = new System.Drawing.Point(1214, 373);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(403, 30);
            this.dtpNgaySinh.TabIndex = 124;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(1212, 184);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(403, 31);
            this.txtDiaChi.TabIndex = 123;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(1085, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 122;
            this.label8.Text = "Địa Chỉ:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtNgaySinh.Location = new System.Drawing.Point(1085, 380);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(92, 23);
            this.txtNgaySinh.TabIndex = 121;
            this.txtNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(529, 369);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(403, 31);
            this.txtEmail.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(357, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 119;
            this.label7.Text = "Email: ";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(1212, 253);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(403, 31);
            this.txtMatKhau.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(1085, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 117;
            this.label6.Text = "Mật Khẩu: ";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(529, 305);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(403, 31);
            this.txtSoDT.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(357, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 115;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txtTenQL
            // 
            this.txtTenQL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQL.Location = new System.Drawing.Point(531, 247);
            this.txtTenQL.Name = "txtTenQL";
            this.txtTenQL.Size = new System.Drawing.Size(403, 31);
            this.txtTenQL.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(358, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 113;
            this.label3.Text = "Tên Quản Lý:";
            // 
            // txtMaQL
            // 
            this.txtMaQL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQL.Location = new System.Drawing.Point(529, 177);
            this.txtMaQL.Multiline = true;
            this.txtMaQL.Name = "txtMaQL";
            this.txtMaQL.ReadOnly = true;
            this.txtMaQL.Size = new System.Drawing.Size(403, 30);
            this.txtMaQL.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(357, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 111;
            this.label1.Text = "Mã quản lý:";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnLuu.IconColor = System.Drawing.Color.White;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(30, 591);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLuu.Size = new System.Drawing.Size(132, 60);
            this.btnLuu.TabIndex = 150;
            this.btnLuu.Tag = "Xóa";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnHuy.IconColor = System.Drawing.Color.White;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(168, 591);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHuy.Size = new System.Drawing.Size(135, 60);
            this.btnHuy.TabIndex = 149;
            this.btnHuy.Tag = "Thêm";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 948);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dtpNgayVao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.ptbAnh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaQL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayVao;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnThemAnh;
        private System.Windows.Forms.PictureBox ptbAnh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaQL;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnHuy;
    }
}