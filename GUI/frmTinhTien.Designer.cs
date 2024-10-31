namespace GUI
{
    partial class frmTinhTien
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
            this.dtpThangNam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNT = new System.Windows.Forms.ComboBox();
            this.cboMaPT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnTinhTien = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.Checked = true;
            this.dtpThangNam.FillColor = System.Drawing.Color.White;
            this.dtpThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpThangNam.Location = new System.Drawing.Point(177, 101);
            this.dtpThangNam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpThangNam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(252, 33);
            this.dtpThangNam.TabIndex = 104;
            this.dtpThangNam.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 38);
            this.label2.TabIndex = 108;
            this.label2.Text = "TÍNH TIỀN PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(47, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 109;
            this.label1.Text = "Tháng/Năm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(47, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 111;
            this.label6.Text = "Nhà Trọ:";
            // 
            // cboNT
            // 
            this.cboNT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboNT.FormattingEnabled = true;
            this.cboNT.Location = new System.Drawing.Point(177, 165);
            this.cboNT.Name = "cboNT";
            this.cboNT.Size = new System.Drawing.Size(252, 31);
            this.cboNT.TabIndex = 110;
            this.cboNT.SelectedValueChanged += new System.EventHandler(this.cboNT_SelectedValueChanged);
            // 
            // cboMaPT
            // 
            this.cboMaPT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboMaPT.FormattingEnabled = true;
            this.cboMaPT.Location = new System.Drawing.Point(177, 233);
            this.cboMaPT.Name = "cboMaPT";
            this.cboMaPT.Size = new System.Drawing.Size(252, 31);
            this.cboMaPT.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(47, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 150;
            this.label3.Text = "Mã Phòng:";
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
            this.btnHuy.Location = new System.Drawing.Point(314, 292);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(115, 35);
            this.btnHuy.TabIndex = 153;
            this.btnHuy.Text = "Đóng";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnTinhTien.BorderRadius = 4;
            this.btnTinhTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhTien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.White;
            this.btnTinhTien.Image = global::GUI.Properties.Resources.Estimate;
            this.btnTinhTien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTinhTien.Location = new System.Drawing.Point(177, 292);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTinhTien.Size = new System.Drawing.Size(116, 35);
            this.btnTinhTien.TabIndex = 152;
            this.btnTinhTien.Text = "Tính";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // frmTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 368);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.cboMaPT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThangNam);
            this.Name = "frmTinhTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNT;
        public System.Windows.Forms.ComboBox cboMaPT;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnTinhTien;
    }
}