namespace GUI
{
    partial class UCHopDong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLuuHopDong = new FontAwesome.Sharp.IconButton();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayDenHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChiSoDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChiSoNuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnLuuHopDong
            // 
            this.btnLuuHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLuuHopDong.FlatAppearance.BorderSize = 0;
            this.btnLuuHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHopDong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHopDong.ForeColor = System.Drawing.Color.White;
            this.btnLuuHopDong.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnLuuHopDong.IconColor = System.Drawing.Color.White;
            this.btnLuuHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuHopDong.IconSize = 30;
            this.btnLuuHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHopDong.Location = new System.Drawing.Point(26, 641);
            this.btnLuuHopDong.Name = "btnLuuHopDong";
            this.btnLuuHopDong.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnLuuHopDong.Size = new System.Drawing.Size(198, 49);
            this.btnLuuHopDong.TabIndex = 128;
            this.btnLuuHopDong.Tag = "Thêm";
            this.btnLuuHopDong.Text = "Lưu Thay Đổi";
            this.btnLuuHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuHopDong.UseVisualStyleBackColor = false;
            this.btnLuuHopDong.Click += new System.EventHandler(this.btnLuuHopDong_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(167, 396);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(821, 88);
            this.txtMoTa.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(22, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 126;
            this.label9.Text = "Mô Tả:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Location = new System.Drawing.Point(167, 321);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(306, 31);
            this.txtTienCoc.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(22, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 124;
            this.label7.Text = "Tiền Cọc:";
            // 
            // dtpNgayDenHan
            // 
            this.dtpNgayDenHan.Checked = true;
            this.dtpNgayDenHan.FillColor = System.Drawing.Color.White;
            this.dtpNgayDenHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDenHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayDenHan.Location = new System.Drawing.Point(682, 243);
            this.dtpNgayDenHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDenHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDenHan.Name = "dtpNgayDenHan";
            this.dtpNgayDenHan.Size = new System.Drawing.Size(306, 30);
            this.dtpNgayDenHan.TabIndex = 123;
            this.dtpNgayDenHan.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(537, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 122;
            this.label5.Text = "Ngày Đến Hạn:";
            // 
            // txtTenKT
            // 
            this.txtTenKT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKT.Location = new System.Drawing.Point(682, 102);
            this.txtTenKT.Multiline = true;
            this.txtTenKT.Name = "txtTenKT";
            this.txtTenKT.ReadOnly = true;
            this.txtTenKT.Size = new System.Drawing.Size(306, 30);
            this.txtTenKT.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(537, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 120;
            this.label4.Text = "Tên Khách Trọ:";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(167, 100);
            this.txtTenNL.Multiline = true;
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.ReadOnly = true;
            this.txtTenNL.Size = new System.Drawing.Size(306, 30);
            this.txtTenNL.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "Tên Người Lập:";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.Location = new System.Drawing.Point(682, 28);
            this.txtMaPT.Multiline = true;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.ReadOnly = true;
            this.txtMaPT.Size = new System.Drawing.Size(306, 30);
            this.txtMaPT.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(537, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Mã Phòng Trọ:";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(167, 28);
            this.txtMaHopDong.Multiline = true;
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.ReadOnly = true;
            this.txtMaHopDong.Size = new System.Drawing.Size(306, 30);
            this.txtMaHopDong.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 114;
            this.label1.Text = "Mã Hợp Đồng:";
            // 
            // txtChiSoDien
            // 
            this.txtChiSoDien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoDien.Location = new System.Drawing.Point(167, 170);
            this.txtChiSoDien.Name = "txtChiSoDien";
            this.txtChiSoDien.ReadOnly = true;
            this.txtChiSoDien.Size = new System.Drawing.Size(306, 31);
            this.txtChiSoDien.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(22, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 130;
            this.label6.Text = "Chỉ Số Điện:";
            // 
            // txtChiSoNuoc
            // 
            this.txtChiSoNuoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoNuoc.Location = new System.Drawing.Point(682, 170);
            this.txtChiSoNuoc.Name = "txtChiSoNuoc";
            this.txtChiSoNuoc.ReadOnly = true;
            this.txtChiSoNuoc.Size = new System.Drawing.Size(306, 31);
            this.txtChiSoNuoc.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(537, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 132;
            this.label8.Text = "Chỉ Số Nước:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Checked = true;
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.FillColor = System.Drawing.Color.White;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLap.Location = new System.Drawing.Point(167, 243);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(306, 30);
            this.dtpNgayLap.TabIndex = 135;
            this.dtpNgayLap.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(22, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 134;
            this.label10.Text = "Ngày Ngày Lập:";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(790, 641);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.iconButton1.Size = new System.Drawing.Size(209, 49);
            this.iconButton1.TabIndex = 137;
            this.iconButton1.Tag = "Thêm";
            this.iconButton1.Text = "In Hợp Đồng";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // UCHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChiSoNuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtChiSoDien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLuuHopDong);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayDenHan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.label1);
            this.Name = "UCHopDong";
            this.Size = new System.Drawing.Size(1022, 703);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLuuHopDong;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDenHan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiSoDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChiSoNuoc;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
