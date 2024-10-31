namespace GUI
{
    partial class frmDoiPhong
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
            this.dtpNgayChuyen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaNT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaPT = new System.Windows.Forms.ComboBox();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiPhong = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(143, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(170, 38);
            this.lblTieuDe.TabIndex = 41;
            this.lblTieuDe.Text = "ĐỔI PHÒNG";
            // 
            // dtpNgayChuyen
            // 
            this.dtpNgayChuyen.Checked = true;
            this.dtpNgayChuyen.Enabled = false;
            this.dtpNgayChuyen.FillColor = System.Drawing.Color.White;
            this.dtpNgayChuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayChuyen.Location = new System.Drawing.Point(133, 88);
            this.dtpNgayChuyen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayChuyen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(254, 33);
            this.dtpNgayChuyen.TabIndex = 148;
            this.dtpNgayChuyen.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(30, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 147;
            this.label5.Text = "Ngày Đổi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(30, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 146;
            this.label6.Text = "Mã Nhà:";
            // 
            // cboMaNT
            // 
            this.cboMaNT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboMaNT.FormattingEnabled = true;
            this.cboMaNT.Location = new System.Drawing.Point(133, 153);
            this.cboMaNT.Name = "cboMaNT";
            this.cboMaNT.Size = new System.Drawing.Size(251, 31);
            this.cboMaNT.TabIndex = 145;
            this.cboMaNT.SelectedValueChanged += new System.EventHandler(this.cboMaNT_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(30, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 143;
            this.label1.Text = "Mã Phòng:";
            // 
            // cboMaPT
            // 
            this.cboMaPT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboMaPT.FormattingEnabled = true;
            this.cboMaPT.Location = new System.Drawing.Point(133, 219);
            this.cboMaPT.Name = "cboMaPT";
            this.cboMaPT.Size = new System.Drawing.Size(251, 31);
            this.cboMaPT.TabIndex = 149;
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
            this.btnHuy.Location = new System.Drawing.Point(269, 288);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(115, 35);
            this.btnHuy.TabIndex = 151;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnDoiPhong.BorderRadius = 4;
            this.btnDoiPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDoiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPhong.ForeColor = System.Drawing.Color.White;
            this.btnDoiPhong.Image = global::GUI.Properties.Resources.Done;
            this.btnDoiPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiPhong.Location = new System.Drawing.Point(133, 288);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDoiPhong.Size = new System.Drawing.Size(115, 35);
            this.btnDoiPhong.TabIndex = 150;
            this.btnDoiPhong.Text = "Đồng ý";
            this.btnDoiPhong.Click += new System.EventHandler(this.btnDoiPhong_Click);
            // 
            // frmDoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 354);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDoiPhong);
            this.Controls.Add(this.cboMaPT);
            this.Controls.Add(this.dtpNgayChuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmDoiPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayChuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboMaNT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboMaPT;
        private Guna.UI2.WinForms.Guna2Button btnDoiPhong;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}