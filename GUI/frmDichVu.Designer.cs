namespace GUI
{
    partial class frmDichVu
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xoasua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSuaDV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaDV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbtnThemDV = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1345, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tìm:";
            // 
            // txtTim
            // 
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Location = new System.Drawing.Point(1396, 40);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.PasswordChar = '\0';
            this.txtTim.PlaceholderText = "";
            this.txtTim.SelectedText = "";
            this.txtTim.Size = new System.Drawing.Size(241, 36);
            this.txtTim.TabIndex = 45;
            // 
            // dgvDichVu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDichVu.ColumnHeadersHeight = 50;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.xoasua,
            this.MADV,
            this.TENDV,
            this.GIATIEN,
            this.MOTA,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDichVu.GridColor = System.Drawing.Color.White;
            this.dgvDichVu.Location = new System.Drawing.Point(38, 108);
            this.dgvDichVu.Name = "dgvDichVu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(1599, 423);
            this.dgvDichVu.TabIndex = 44;
            this.dgvDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDichVu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDichVu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDichVu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDichVu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDichVu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDichVu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDichVu.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvDichVu.ThemeStyle.ReadOnly = false;
            this.dgvDichVu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDichVu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvDichVu.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDichVu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDichVu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 6;
            this.checkbox.Name = "checkbox";
            this.checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xoasua
            // 
            this.xoasua.HeaderText = "";
            this.xoasua.MinimumWidth = 6;
            this.xoasua.Name = "xoasua";
            // 
            // MADV
            // 
            this.MADV.DataPropertyName = "MADV";
            this.MADV.HeaderText = "Mã dịch vụ";
            this.MADV.MinimumWidth = 6;
            this.MADV.Name = "MADV";
            // 
            // TENDV
            // 
            this.TENDV.DataPropertyName = "TENDV";
            this.TENDV.HeaderText = "Tên dịch vụ";
            this.TENDV.MinimumWidth = 6;
            this.TENDV.Name = "TENDV";
            // 
            // GIATIEN
            // 
            this.GIATIEN.DataPropertyName = "GIATIEN";
            this.GIATIEN.HeaderText = "Giá tiền";
            this.GIATIEN.MinimumWidth = 6;
            this.GIATIEN.Name = "GIATIEN";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Đang dùng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnSuaDV.BorderRadius = 4;
            this.btnSuaDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaDV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSuaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.ForeColor = System.Drawing.Color.White;
            this.btnSuaDV.Image = global::GUI.Properties.Resources.Edit;
            this.btnSuaDV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuaDV.Location = new System.Drawing.Point(191, 567);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSuaDV.Size = new System.Drawing.Size(147, 48);
            this.btnSuaDV.TabIndex = 48;
            this.btnSuaDV.Text = "Sửa dịch vụ";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(159)))), ((int)(((byte)(133)))));
            this.btnXoaDV.BorderRadius = 4;
            this.btnXoaDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaDV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Image = global::GUI.Properties.Resources.Delete;
            this.btnXoaDV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaDV.Location = new System.Drawing.Point(344, 567);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnXoaDV.Size = new System.Drawing.Size(147, 48);
            this.btnXoaDV.TabIndex = 47;
            this.btnXoaDV.Text = "Xóa dịch vụ";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(81, 40);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(68, 36);
            this.guna2ComboBox1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Xem";
            // 
            // gbtnThemDV
            // 
            this.gbtnThemDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(159)))), ((int)(((byte)(133)))));
            this.gbtnThemDV.BorderRadius = 4;
            this.gbtnThemDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnThemDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnThemDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnThemDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnThemDV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.gbtnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gbtnThemDV.ForeColor = System.Drawing.Color.White;
            this.gbtnThemDV.Image = global::GUI.Properties.Resources.Home;
            this.gbtnThemDV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtnThemDV.Location = new System.Drawing.Point(38, 567);
            this.gbtnThemDV.Name = "gbtnThemDV";
            this.gbtnThemDV.Size = new System.Drawing.Size(147, 48);
            this.gbtnThemDV.TabIndex = 40;
            this.gbtnThemDV.Text = "Thêm dịch vụ";
            this.gbtnThemDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 948);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbtnThemDV);
            this.Name = "frmDichVu";
            this.Text = "Dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn xoasua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2Button btnSuaDV;
        private Guna.UI2.WinForms.Guna2Button btnXoaDV;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button gbtnThemDV;
    }
}