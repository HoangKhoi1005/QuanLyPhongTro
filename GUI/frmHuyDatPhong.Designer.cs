namespace GUI
{
    partial class frmHuyDatPhong
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
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayNhanPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnHuyPhieuDat = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(156, 282);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(665, 88);
            this.txtMoTa.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(22, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 143;
            this.label9.Text = "Mô Tả:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Enabled = false;
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Location = new System.Drawing.Point(156, 211);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(237, 31);
            this.txtTienCoc.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(22, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 141;
            this.label7.Text = "Tiền Đặt Phòng:";
            // 
            // dtpNgayNhanPhong
            // 
            this.dtpNgayNhanPhong.Checked = true;
            this.dtpNgayNhanPhong.Enabled = false;
            this.dtpNgayNhanPhong.FillColor = System.Drawing.Color.White;
            this.dtpNgayNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhanPhong.Location = new System.Drawing.Point(584, 211);
            this.dtpNgayNhanPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhanPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhanPhong.Name = "dtpNgayNhanPhong";
            this.dtpNgayNhanPhong.Size = new System.Drawing.Size(237, 33);
            this.dtpNgayNhanPhong.TabIndex = 140;
            this.dtpNgayNhanPhong.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(422, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 139;
            this.label5.Text = "Ngày Nhận Phòng:";
            // 
            // txtTenKT
            // 
            this.txtTenKT.Enabled = false;
            this.txtTenKT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKT.Location = new System.Drawing.Point(593, 144);
            this.txtTenKT.Multiline = true;
            this.txtTenKT.Name = "txtTenKT";
            this.txtTenKT.ReadOnly = true;
            this.txtTenKT.Size = new System.Drawing.Size(228, 30);
            this.txtTenKT.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(422, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 137;
            this.label4.Text = "Tên Khách Trọ:";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Enabled = false;
            this.txtTenNL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(156, 144);
            this.txtTenNL.Multiline = true;
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.ReadOnly = true;
            this.txtTenNL.Size = new System.Drawing.Size(237, 30);
            this.txtTenNL.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 135;
            this.label3.Text = "Tên Người Lập:";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.Location = new System.Drawing.Point(593, 80);
            this.txtMaPT.Multiline = true;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.ReadOnly = true;
            this.txtMaPT.Size = new System.Drawing.Size(228, 30);
            this.txtMaPT.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(422, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 133;
            this.label2.Text = "Mã Phòng Trọ:";
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Enabled = false;
            this.txtMaPhieuDat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuDat.Location = new System.Drawing.Point(156, 80);
            this.txtMaPhieuDat.Multiline = true;
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.ReadOnly = true;
            this.txtMaPhieuDat.Size = new System.Drawing.Size(237, 30);
            this.txtMaPhieuDat.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 131;
            this.label1.Text = "Mã Phiếu Đặt:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(306, 13);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(237, 38);
            this.lblTieuDe.TabIndex = 130;
            this.lblTieuDe.Text = "HỦY ĐẶT PHÒNG";
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
            this.btnCancel.Location = new System.Drawing.Point(439, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnCancel.Size = new System.Drawing.Size(182, 49);
            this.btnCancel.TabIndex = 146;
            this.btnCancel.Tag = "Thêm";
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHuyPhieuDat
            // 
            this.btnHuyPhieuDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyPhieuDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHuyPhieuDat.FlatAppearance.BorderSize = 0;
            this.btnHuyPhieuDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhieuDat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuDat.ForeColor = System.Drawing.Color.White;
            this.btnHuyPhieuDat.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.btnHuyPhieuDat.IconColor = System.Drawing.Color.White;
            this.btnHuyPhieuDat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyPhieuDat.IconSize = 30;
            this.btnHuyPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPhieuDat.Location = new System.Drawing.Point(189, 394);
            this.btnHuyPhieuDat.Name = "btnHuyPhieuDat";
            this.btnHuyPhieuDat.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnHuyPhieuDat.Size = new System.Drawing.Size(204, 49);
            this.btnHuyPhieuDat.TabIndex = 145;
            this.btnHuyPhieuDat.Tag = "Thêm";
            this.btnHuyPhieuDat.Text = "Hủy Phiếu Đặt";
            this.btnHuyPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPhieuDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyPhieuDat.UseVisualStyleBackColor = false;
            this.btnHuyPhieuDat.Click += new System.EventHandler(this.btnHuyPhieuDat_Click);
            // 
            // frmHuyDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHuyPhieuDat);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayNhanPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPhieuDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmHuyDatPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnHuyPhieuDat;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhanPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTieuDe;
    }
}