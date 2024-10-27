namespace GUI
{
    partial class frmXoaTaiSan
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
            this.label2 = new System.Windows.Forms.Label();
            this.ckbNgayThanhLy = new System.Windows.Forms.CheckBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayThanhLy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgaySuDung = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaPT = new System.Windows.Forms.ComboBox();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 38);
            this.label2.TabIndex = 40;
            this.label2.Text = "XÓA TÀI SẢN";
            // 
            // ckbNgayThanhLy
            // 
            this.ckbNgayThanhLy.AutoSize = true;
            this.ckbNgayThanhLy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ckbNgayThanhLy.Location = new System.Drawing.Point(463, 220);
            this.ckbNgayThanhLy.Name = "ckbNgayThanhLy";
            this.ckbNgayThanhLy.Size = new System.Drawing.Size(149, 27);
            this.ckbNgayThanhLy.TabIndex = 166;
            this.ckbNgayThanhLy.Text = "Ngày Thanh Lý:";
            this.ckbNgayThanhLy.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(493, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCancel.Size = new System.Drawing.Size(135, 60);
            this.btnCancel.TabIndex = 164;
            this.btnCancel.Tag = "Thêm";
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMoTa.Location = new System.Drawing.Point(177, 284);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(694, 86);
            this.txtMoTa.TabIndex = 163;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(15, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 162;
            this.label7.Text = "Mô Tả:";
            // 
            // dtpNgayThanhLy
            // 
            this.dtpNgayThanhLy.Checked = true;
            this.dtpNgayThanhLy.Enabled = false;
            this.dtpNgayThanhLy.FillColor = System.Drawing.Color.White;
            this.dtpNgayThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayThanhLy.Location = new System.Drawing.Point(620, 215);
            this.dtpNgayThanhLy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayThanhLy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayThanhLy.Name = "dtpNgayThanhLy";
            this.dtpNgayThanhLy.Size = new System.Drawing.Size(251, 33);
            this.dtpNgayThanhLy.TabIndex = 161;
            this.dtpNgayThanhLy.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // dtpNgaySuDung
            // 
            this.dtpNgaySuDung.Checked = true;
            this.dtpNgaySuDung.Enabled = false;
            this.dtpNgaySuDung.FillColor = System.Drawing.Color.White;
            this.dtpNgaySuDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySuDung.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaySuDung.Location = new System.Drawing.Point(177, 217);
            this.dtpNgaySuDung.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySuDung.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySuDung.Name = "dtpNgaySuDung";
            this.dtpNgaySuDung.Size = new System.Drawing.Size(254, 33);
            this.dtpNgaySuDung.TabIndex = 160;
            this.dtpNgaySuDung.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(15, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 159;
            this.label5.Text = "Ngày Sử Dụng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDonGia.Location = new System.Drawing.Point(620, 153);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(251, 30);
            this.txtDonGia.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(459, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 157;
            this.label3.Text = "Đơn Giá:";
            // 
            // txtTenTS
            // 
            this.txtTenTS.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTenTS.Location = new System.Drawing.Point(177, 156);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.ReadOnly = true;
            this.txtTenTS.Size = new System.Drawing.Size(254, 30);
            this.txtTenTS.TabIndex = 156;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(15, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 155;
            this.label8.Text = "Tên Tài Sản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(459, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 154;
            this.label6.Text = "Mã Phòng:";
            // 
            // cboMaPT
            // 
            this.cboMaPT.Enabled = false;
            this.cboMaPT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboMaPT.FormattingEnabled = true;
            this.cboMaPT.Location = new System.Drawing.Point(620, 97);
            this.cboMaPT.Name = "cboMaPT";
            this.cboMaPT.Size = new System.Drawing.Size(251, 31);
            this.cboMaPT.TabIndex = 153;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaTS.Location = new System.Drawing.Point(177, 90);
            this.txtMaTS.Multiline = true;
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.ReadOnly = true;
            this.txtMaTS.Size = new System.Drawing.Size(254, 30);
            this.txtMaTS.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 151;
            this.label1.Text = "Mã Tài Sản:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(227, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXoa.Size = new System.Drawing.Size(204, 60);
            this.btnXoa.TabIndex = 167;
            this.btnXoa.Tag = "Xóa";
            this.btnXoa.Text = "Xóa Tài Sản";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmXoaTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 485);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.ckbNgayThanhLy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayThanhLy);
            this.Controls.Add(this.dtpNgaySuDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenTS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaPT);
            this.Controls.Add(this.txtMaTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmXoaTaiSan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbNgayThanhLy;
        private FontAwesome.Sharp.IconButton btnCancel;
        public System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayThanhLy;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySuDung;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTenTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboMaPT;
        public System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnXoa;
    }
}