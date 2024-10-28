namespace GUI
{
    partial class frmSuaDienNuoc
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
            this.dtpNgayThang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboMaPT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtChiSoDien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChiSoNuoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.Checked = true;
            this.dtpNgayThang.FillColor = System.Drawing.Color.White;
            this.dtpNgayThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayThang.Location = new System.Drawing.Point(164, 169);
            this.dtpNgayThang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayThang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(237, 33);
            this.dtpNgayThang.TabIndex = 152;
            this.dtpNgayThang.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // cboMaPT
            // 
            this.cboMaPT.BackColor = System.Drawing.Color.Transparent;
            this.cboMaPT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaPT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaPT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMaPT.ItemHeight = 30;
            this.cboMaPT.Location = new System.Drawing.Point(583, 101);
            this.cboMaPT.Name = "cboMaPT";
            this.cboMaPT.Size = new System.Drawing.Size(237, 36);
            this.cboMaPT.TabIndex = 151;
            // 
            // txtChiSoDien
            // 
            this.txtChiSoDien.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtChiSoDien.Location = new System.Drawing.Point(583, 164);
            this.txtChiSoDien.Multiline = true;
            this.txtChiSoDien.Name = "txtChiSoDien";
            this.txtChiSoDien.Size = new System.Drawing.Size(237, 33);
            this.txtChiSoDien.TabIndex = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(449, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 149;
            this.label4.Text = "Chỉ số điện";
            // 
            // txtChiSoNuoc
            // 
            this.txtChiSoNuoc.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtChiSoNuoc.Location = new System.Drawing.Point(164, 235);
            this.txtChiSoNuoc.Multiline = true;
            this.txtChiSoNuoc.Name = "txtChiSoNuoc";
            this.txtChiSoNuoc.Size = new System.Drawing.Size(237, 33);
            this.txtChiSoNuoc.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(14, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 147;
            this.label10.Text = "Chỉ số nước";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(14, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 146;
            this.label8.Text = "Ngày tháng";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(164, 303);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSua.Size = new System.Drawing.Size(191, 60);
            this.btnSua.TabIndex = 145;
            this.btnSua.Tag = "Xóa";
            this.btnSua.Text = "Cập nhật";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(361, 303);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHuy.Size = new System.Drawing.Size(135, 60);
            this.btnHuy.TabIndex = 144;
            this.btnHuy.Tag = "Thêm";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaCS
            // 
            this.txtMaCS.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaCS.Location = new System.Drawing.Point(164, 101);
            this.txtMaCS.Multiline = true;
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.ReadOnly = true;
            this.txtMaCS.Size = new System.Drawing.Size(237, 33);
            this.txtMaCS.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(451, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 142;
            this.label3.Text = "Mã phòng trọ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 141;
            this.label1.Text = "Mã chỉ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 38);
            this.label2.TabIndex = 140;
            this.label2.Text = "SỬA ĐIỆN NƯỚC";
            // 
            // frmSuaDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 378);
            this.Controls.Add(this.dtpNgayThang);
            this.Controls.Add(this.cboMaPT);
            this.Controls.Add(this.txtChiSoDien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChiSoNuoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMaCS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuaDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaDienNuoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayThang;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaPT;
        private System.Windows.Forms.TextBox txtChiSoDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChiSoNuoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}