namespace GUI
{
    partial class frmBaoTraPhong
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
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayBao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienHoanTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dtpNgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnLapBaoTraPhong = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(148, 203);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(639, 88);
            this.txtMoTa.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(14, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 126;
            this.label9.Text = "Mô Tả:";
            // 
            // dtpNgayBao
            // 
            this.dtpNgayBao.Checked = true;
            this.dtpNgayBao.Enabled = false;
            this.dtpNgayBao.FillColor = System.Drawing.Color.White;
            this.dtpNgayBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBao.Location = new System.Drawing.Point(148, 139);
            this.dtpNgayBao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBao.Name = "dtpNgayBao";
            this.dtpNgayBao.Size = new System.Drawing.Size(237, 33);
            this.dtpNgayBao.TabIndex = 123;
            this.dtpNgayBao.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 122;
            this.label5.Text = "Ngày Báo:";
            // 
            // txtTienHoanTra
            // 
            this.txtTienHoanTra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienHoanTra.Location = new System.Drawing.Point(559, 78);
            this.txtTienHoanTra.Multiline = true;
            this.txtTienHoanTra.Name = "txtTienHoanTra";
            this.txtTienHoanTra.Size = new System.Drawing.Size(228, 30);
            this.txtTienHoanTra.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(414, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 120;
            this.label4.Text = "Tiền Hoàn Lại:";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.Location = new System.Drawing.Point(148, 76);
            this.txtMaPT.Multiline = true;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.ReadOnly = true;
            this.txtMaPT.Size = new System.Drawing.Size(237, 30);
            this.txtMaPT.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Mã Phòng Trọ:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(264, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(289, 38);
            this.lblTieuDe.TabIndex = 113;
            this.lblTieuDe.Text = "LẬP BÁO TRẢ PHÒNG";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Checked = true;
            this.dtpNgayTra.FillColor = System.Drawing.Color.White;
            this.dtpNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTra.Location = new System.Drawing.Point(550, 139);
            this.dtpNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(237, 33);
            this.dtpNgayTra.TabIndex = 131;
            this.dtpNgayTra.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(414, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 130;
            this.label1.Text = "Ngày Trả:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(438, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnCancel.Size = new System.Drawing.Size(182, 49);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Tag = "Thêm";
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLapBaoTraPhong
            // 
            this.btnLapBaoTraPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLapBaoTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLapBaoTraPhong.FlatAppearance.BorderSize = 0;
            this.btnLapBaoTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoTraPhong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBaoTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnLapBaoTraPhong.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnLapBaoTraPhong.IconColor = System.Drawing.Color.White;
            this.btnLapBaoTraPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLapBaoTraPhong.IconSize = 30;
            this.btnLapBaoTraPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapBaoTraPhong.Location = new System.Drawing.Point(168, 313);
            this.btnLapBaoTraPhong.Name = "btnLapBaoTraPhong";
            this.btnLapBaoTraPhong.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnLapBaoTraPhong.Size = new System.Drawing.Size(237, 49);
            this.btnLapBaoTraPhong.TabIndex = 128;
            this.btnLapBaoTraPhong.Tag = "Thêm";
            this.btnLapBaoTraPhong.Text = "Lập Báo Trả Phòng";
            this.btnLapBaoTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapBaoTraPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapBaoTraPhong.UseVisualStyleBackColor = false;
            this.btnLapBaoTraPhong.Click += new System.EventHandler(this.btnLapBaoTraPhong_Click);
            // 
            // frmBaoTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLapBaoTraPhong);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpNgayBao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTienHoanTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmBaoTraPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnLapBaoTraPhong;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienHoanTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTieuDe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label1;
    }
}