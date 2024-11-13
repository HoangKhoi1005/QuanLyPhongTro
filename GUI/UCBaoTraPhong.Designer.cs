namespace GUI
{
    partial class UCBaoTraPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvBaoTraPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MABAOTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRAPHONGDUKIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAXOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTraPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnCapNhat.IconColor = System.Drawing.Color.White;
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(282, 628);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(221, 60);
            this.btnCapNhat.TabIndex = 145;
            this.btnCapNhat.Tag = "Xóa";
            this.btnCapNhat.Text = "Sửa Báo Trả ";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(509, 628);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXoa.Size = new System.Drawing.Size(241, 60);
            this.btnXoa.TabIndex = 144;
            this.btnXoa.Tag = "Xóa";
            this.btnXoa.Text = "Xóa Báo Trả";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 35;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 628);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnThem.Size = new System.Drawing.Size(273, 60);
            this.btnThem.TabIndex = 143;
            this.btnThem.Tag = "Thêm";
            this.btnThem.Text = "Thêm Báo Trả Phòng";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvBaoTraPhong
            // 
            this.dgvBaoTraPhong.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBaoTraPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoTraPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBaoTraPhong.ColumnHeadersHeight = 30;
            this.dgvBaoTraPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBaoTraPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABAOTRA,
            this.MAPT,
            this.NGAYBAO,
            this.NGAYTRAPHONGDUKIEN,
            this.MOTA,
            this.DAXOA});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoTraPhong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBaoTraPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoTraPhong.Location = new System.Drawing.Point(3, 14);
            this.dgvBaoTraPhong.Name = "dgvBaoTraPhong";
            this.dgvBaoTraPhong.RowHeadersVisible = false;
            this.dgvBaoTraPhong.RowHeadersWidth = 51;
            this.dgvBaoTraPhong.RowTemplate.Height = 50;
            this.dgvBaoTraPhong.RowTemplate.ReadOnly = true;
            this.dgvBaoTraPhong.Size = new System.Drawing.Size(1016, 600);
            this.dgvBaoTraPhong.TabIndex = 142;
            this.dgvBaoTraPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoTraPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBaoTraPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBaoTraPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBaoTraPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBaoTraPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoTraPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoTraPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBaoTraPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBaoTraPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoTraPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBaoTraPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBaoTraPhong.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBaoTraPhong.ThemeStyle.ReadOnly = false;
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.Height = 50;
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoTraPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MABAOTRA
            // 
            this.MABAOTRA.DataPropertyName = "MABAOTRA";
            this.MABAOTRA.FillWeight = 87.39673F;
            this.MABAOTRA.HeaderText = "Mã Báo Trả";
            this.MABAOTRA.MinimumWidth = 6;
            this.MABAOTRA.Name = "MABAOTRA";
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MAPT";
            this.MAPT.FillWeight = 80.31824F;
            this.MAPT.HeaderText = "Mã Phòng";
            this.MAPT.MinimumWidth = 6;
            this.MAPT.Name = "MAPT";
            // 
            // NGAYBAO
            // 
            this.NGAYBAO.DataPropertyName = "NGAYBAO";
            this.NGAYBAO.FillWeight = 70.5552F;
            this.NGAYBAO.HeaderText = "Ngày Báo";
            this.NGAYBAO.MinimumWidth = 6;
            this.NGAYBAO.Name = "NGAYBAO";
            // 
            // NGAYTRAPHONGDUKIEN
            // 
            this.NGAYTRAPHONGDUKIEN.DataPropertyName = "NGAYTRAPHONGDUKIEN";
            this.NGAYTRAPHONGDUKIEN.FillWeight = 92.04882F;
            this.NGAYTRAPHONGDUKIEN.HeaderText = "Ngày Trả Dự Kiến";
            this.NGAYTRAPHONGDUKIEN.MinimumWidth = 6;
            this.NGAYTRAPHONGDUKIEN.Name = "NGAYTRAPHONGDUKIEN";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.FillWeight = 161.4847F;
            this.MOTA.HeaderText = "Mô Tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            // 
            // DAXOA
            // 
            this.DAXOA.DataPropertyName = "DAXOA";
            this.DAXOA.FillWeight = 58.89865F;
            this.DAXOA.HeaderText = "Đã Xóa";
            this.DAXOA.MinimumWidth = 6;
            this.DAXOA.Name = "DAXOA";
            // 
            // UCBaoTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvBaoTraPhong);
            this.Name = "UCBaoTraPhong";
            this.Size = new System.Drawing.Size(1022, 703);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTraPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        public Guna.UI2.WinForms.Guna2DataGridView dgvBaoTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABAOTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRAPHONGDUKIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAXOA;
    }
}
