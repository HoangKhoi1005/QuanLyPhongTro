namespace GUI
{
    partial class frmXoaDichVu
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMoTa.Location = new System.Drawing.Point(183, 243);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(568, 86);
            this.txtMoTa.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(33, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
            this.label10.TabIndex = 145;
            this.label10.Text = "Mô Tả:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDonGia.Location = new System.Drawing.Point(183, 176);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(181, 30);
            this.txtDonGia.TabIndex = 144;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(33, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 143;
            this.label8.Text = "Đơn giá:";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTenDV.Location = new System.Drawing.Point(542, 111);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(209, 30);
            this.txtTenDV.TabIndex = 142;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaDV.Location = new System.Drawing.Point(183, 109);
            this.txtMaDV.Multiline = true;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(181, 30);
            this.txtMaDV.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(410, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 140;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(33, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 139;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 38);
            this.label2.TabIndex = 138;
            this.label2.Text = "XÓA DỊCH VỤ";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(183, 361);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXoa.Size = new System.Drawing.Size(132, 60);
            this.btnXoa.TabIndex = 148;
            this.btnXoa.Tag = "Xóa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(333, 361);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHuy.Size = new System.Drawing.Size(135, 60);
            this.btnHuy.TabIndex = 147;
            this.btnHuy.Tag = "Thêm";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmXoaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmXoaDichVu";
            this.Load += new System.EventHandler(this.frmXoaDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}