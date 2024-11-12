namespace GUI
{
    partial class frmThanhToan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThangNam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMaNT = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtCongNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMaxCongNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnThuTien = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(50, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 159;
            this.label3.Text = "Tổng Tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(50, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 158;
            this.label6.Text = "Nhà Trọ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 156;
            this.label1.Text = "Tháng/Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 38);
            this.label2.TabIndex = 155;
            this.label2.Text = "THU TIỀN PHÒNG";
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.Checked = true;
            this.dtpThangNam.Enabled = false;
            this.dtpThangNam.FillColor = System.Drawing.Color.White;
            this.dtpThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpThangNam.Location = new System.Drawing.Point(221, 87);
            this.dtpThangNam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpThangNam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(252, 33);
            this.dtpThangNam.TabIndex = 154;
            this.dtpThangNam.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // txtMaNT
            // 
            this.txtMaNT.Enabled = false;
            this.txtMaNT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNT.Location = new System.Drawing.Point(221, 225);
            this.txtMaNT.Name = "txtMaNT";
            this.txtMaNT.ReadOnly = true;
            this.txtMaNT.Size = new System.Drawing.Size(252, 30);
            this.txtMaNT.TabIndex = 163;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(221, 293);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(252, 30);
            this.txtTongTien.TabIndex = 164;
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.txtSoTienThu.Location = new System.Drawing.Point(221, 429);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(252, 30);
            this.txtSoTienThu.TabIndex = 168;
            // 
            // txtCongNo
            // 
            this.txtCongNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongNo.ForeColor = System.Drawing.Color.Red;
            this.txtCongNo.Location = new System.Drawing.Point(221, 361);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.ReadOnly = true;
            this.txtCongNo.Size = new System.Drawing.Size(252, 30);
            this.txtCongNo.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(50, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 166;
            this.label4.Text = "Nhập Số Tiền Thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(50, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 165;
            this.label5.Text = "Công Nợ:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(221, 157);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(252, 30);
            this.txtMaHD.TabIndex = 170;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(50, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 169;
            this.label7.Text = "Mã Hóa Đơn:";
            // 
            // btnMaxCongNo
            // 
            this.btnMaxCongNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnMaxCongNo.BorderRadius = 14;
            this.btnMaxCongNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaxCongNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaxCongNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaxCongNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaxCongNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMaxCongNo.FocusedColor = System.Drawing.Color.Lime;
            this.btnMaxCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnMaxCongNo.ForeColor = System.Drawing.Color.White;
            this.btnMaxCongNo.Image = global::GUI.Properties.Resources.ScrollUp;
            this.btnMaxCongNo.Location = new System.Drawing.Point(479, 429);
            this.btnMaxCongNo.Name = "btnMaxCongNo";
            this.btnMaxCongNo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMaxCongNo.Size = new System.Drawing.Size(34, 30);
            this.btnMaxCongNo.TabIndex = 171;
            this.btnMaxCongNo.Click += new System.EventHandler(this.btnMaxCongNo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnHuy.BorderRadius = 4;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::GUI.Properties.Resources.Cancel;
            this.btnHuy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuy.Location = new System.Drawing.Point(358, 504);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(115, 35);
            this.btnHuy.TabIndex = 162;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThuTien
            // 
            this.btnThuTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnThuTien.BorderRadius = 4;
            this.btnThuTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThuTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThuTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThuTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThuTien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnThuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuTien.ForeColor = System.Drawing.Color.White;
            this.btnThuTien.Image = global::GUI.Properties.Resources.Estimate;
            this.btnThuTien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThuTien.Location = new System.Drawing.Point(221, 504);
            this.btnThuTien.Name = "btnThuTien";
            this.btnThuTien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThuTien.Size = new System.Drawing.Size(116, 35);
            this.btnThuTien.TabIndex = 161;
            this.btnThuTien.Text = "Thu";
            this.btnThuTien.Click += new System.EventHandler(this.btnThuTien_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 575);
            this.Controls.Add(this.btnMaxCongNo);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoTienThu);
            this.Controls.Add(this.txtCongNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaNT);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThuTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThangNam);
            this.Name = "frmThanhToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnThuTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpThangNam;
        private System.Windows.Forms.TextBox txtMaNT;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.TextBox txtCongNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnMaxCongNo;
    }
}