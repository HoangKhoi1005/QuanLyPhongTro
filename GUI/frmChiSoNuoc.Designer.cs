namespace GUI
{
    partial class frmChiSoNuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvChiSo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MACS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHISODIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHISONUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtTraCuu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaChiSo = new FontAwesome.Sharp.IconButton();
            this.btnSuaChiSo = new FontAwesome.Sharp.IconButton();
            this.btnThemChiSo = new FontAwesome.Sharp.IconButton();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.dgvChiSo);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 74);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1589, 530);
            this.guna2GroupBox2.TabIndex = 52;
            this.guna2GroupBox2.Text = "Danh sách chỉ số điện/nước";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvChiSo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiSo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiSo.ColumnHeadersHeight = 50;
            this.dgvChiSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACS,
            this.MAPT,
            this.NGAYTHANG,
            this.CHISODIEN,
            this.CHISONUOC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiSo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiSo.Location = new System.Drawing.Point(0, 40);
            this.dgvChiSo.Name = "dgvChiSo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiSo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiSo.RowHeadersVisible = false;
            this.dgvChiSo.RowHeadersWidth = 51;
            this.dgvChiSo.RowTemplate.Height = 50;
            this.dgvChiSo.RowTemplate.ReadOnly = true;
            this.dgvChiSo.Size = new System.Drawing.Size(1589, 490);
            this.dgvChiSo.TabIndex = 46;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiSo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChiSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiSo.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvChiSo.ThemeStyle.ReadOnly = false;
            this.dgvChiSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiSo.ThemeStyle.RowsStyle.Height = 50;
            this.dgvChiSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MACS
            // 
            this.MACS.DataPropertyName = "MACS";
            this.MACS.FillWeight = 102.7595F;
            this.MACS.HeaderText = "Mã chỉ số";
            this.MACS.MinimumWidth = 6;
            this.MACS.Name = "MACS";
            // 
            // MAPT
            // 
            this.MAPT.DataPropertyName = "MAPT";
            this.MAPT.FillWeight = 83.63564F;
            this.MAPT.HeaderText = "Mã phòng trọ";
            this.MAPT.MinimumWidth = 6;
            this.MAPT.Name = "MAPT";
            // 
            // NGAYTHANG
            // 
            this.NGAYTHANG.DataPropertyName = "NGAYTHANG";
            this.NGAYTHANG.FillWeight = 86.85548F;
            this.NGAYTHANG.HeaderText = "Ngày tháng";
            this.NGAYTHANG.MinimumWidth = 6;
            this.NGAYTHANG.Name = "NGAYTHANG";
            // 
            // CHISODIEN
            // 
            this.CHISODIEN.DataPropertyName = "CHISODIEN";
            this.CHISODIEN.FillWeight = 89.2562F;
            this.CHISODIEN.HeaderText = "Chỉ số điện";
            this.CHISODIEN.MinimumWidth = 6;
            this.CHISODIEN.Name = "CHISODIEN";
            // 
            // CHISONUOC
            // 
            this.CHISONUOC.DataPropertyName = "CHISONUOC";
            this.CHISONUOC.HeaderText = "Chỉ số nước";
            this.CHISONUOC.MinimumWidth = 6;
            this.CHISONUOC.Name = "CHISONUOC";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.btnTraCuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.BorderRadius = 5;
            this.btnTraCuu.BorderThickness = 2;
            this.btnTraCuu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.CustomBorderColor = System.Drawing.Color.White;
            this.btnTraCuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraCuu.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.FillColor = System.Drawing.Color.White;
            this.btnTraCuu.FocusedColor = System.Drawing.Color.White;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(300, 13);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.PressedColor = System.Drawing.Color.Blue;
            this.btnTraCuu.Size = new System.Drawing.Size(109, 43);
            this.btnTraCuu.TabIndex = 54;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.txtTraCuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTraCuu.BorderRadius = 5;
            this.txtTraCuu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTraCuu.BorderThickness = 2;
            this.txtTraCuu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuu.DefaultText = "";
            this.txtTraCuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuu.Location = new System.Drawing.Point(12, 13);
            this.txtTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.PasswordChar = '\0';
            this.txtTraCuu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTraCuu.PlaceholderText = "Nhập vào thông tin để tra cứu";
            this.txtTraCuu.SelectedText = "";
            this.txtTraCuu.Size = new System.Drawing.Size(269, 43);
            this.txtTraCuu.TabIndex = 53;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // btnXoaChiSo
            // 
            this.btnXoaChiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaChiSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoaChiSo.FlatAppearance.BorderSize = 0;
            this.btnXoaChiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChiSo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiSo.ForeColor = System.Drawing.Color.White;
            this.btnXoaChiSo.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaChiSo.IconColor = System.Drawing.Color.White;
            this.btnXoaChiSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaChiSo.IconSize = 35;
            this.btnXoaChiSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaChiSo.Location = new System.Drawing.Point(609, 617);
            this.btnXoaChiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaChiSo.Name = "btnXoaChiSo";
            this.btnXoaChiSo.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnXoaChiSo.Size = new System.Drawing.Size(282, 60);
            this.btnXoaChiSo.TabIndex = 58;
            this.btnXoaChiSo.Tag = "Thêm";
            this.btnXoaChiSo.Text = "Xóa chỉ số điện nước";
            this.btnXoaChiSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaChiSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaChiSo.UseVisualStyleBackColor = false;
            this.btnXoaChiSo.Click += new System.EventHandler(this.btnXoaChiSo_Click);
            // 
            // btnSuaChiSo
            // 
            this.btnSuaChiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaChiSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnSuaChiSo.FlatAppearance.BorderSize = 0;
            this.btnSuaChiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaChiSo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiSo.ForeColor = System.Drawing.Color.White;
            this.btnSuaChiSo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSuaChiSo.IconColor = System.Drawing.Color.White;
            this.btnSuaChiSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaChiSo.IconSize = 35;
            this.btnSuaChiSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaChiSo.Location = new System.Drawing.Point(321, 617);
            this.btnSuaChiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaChiSo.Name = "btnSuaChiSo";
            this.btnSuaChiSo.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSuaChiSo.Size = new System.Drawing.Size(282, 60);
            this.btnSuaChiSo.TabIndex = 57;
            this.btnSuaChiSo.Tag = "Thêm";
            this.btnSuaChiSo.Text = "Sửa chỉ số điện nước";
            this.btnSuaChiSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaChiSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaChiSo.UseVisualStyleBackColor = false;
            this.btnSuaChiSo.Click += new System.EventHandler(this.btnSuaChiSo_Click);
            // 
            // btnThemChiSo
            // 
            this.btnThemChiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemChiSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.btnThemChiSo.FlatAppearance.BorderSize = 0;
            this.btnThemChiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemChiSo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiSo.ForeColor = System.Drawing.Color.White;
            this.btnThemChiSo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemChiSo.IconColor = System.Drawing.Color.White;
            this.btnThemChiSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemChiSo.IconSize = 35;
            this.btnThemChiSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemChiSo.Location = new System.Drawing.Point(12, 617);
            this.btnThemChiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChiSo.Name = "btnThemChiSo";
            this.btnThemChiSo.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnThemChiSo.Size = new System.Drawing.Size(303, 60);
            this.btnThemChiSo.TabIndex = 56;
            this.btnThemChiSo.Tag = "Thêm";
            this.btnThemChiSo.Text = "Thêm chỉ số điện/nước";
            this.btnThemChiSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemChiSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemChiSo.UseVisualStyleBackColor = false;
            this.btnThemChiSo.Click += new System.EventHandler(this.btnThemChiSo_Click);
            // 
            // frmChiSoNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 737);
            this.Controls.Add(this.btnXoaChiSo);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSuaChiSo);
            this.Controls.Add(this.btnThemChiSo);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.guna2GroupBox2);
            this.Name = "frmChiSoNuoc";
            this.Text = "Chỉ số nước";
            this.Load += new System.EventHandler(this.frmChiSoNuoc_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        public Guna.UI2.WinForms.Guna2DataGridView dgvChiSo;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuu;
        private FontAwesome.Sharp.IconButton btnXoaChiSo;
        private FontAwesome.Sharp.IconButton btnSuaChiSo;
        private FontAwesome.Sharp.IconButton btnThemChiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHISODIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHISONUOC;
    }
}