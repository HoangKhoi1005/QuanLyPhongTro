using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCPhong : UserControl
    {
        private bool trangThai;
        ToolTip toolTip1 = new ToolTip();
        public bool TrangThai
        {
            get { return trangThai; }
            set
            {
                trangThai = value;
                LoadPhongTro();
            }
        }
        public UCPhong()
        {
            InitializeComponent();

            TrangThai = false;
        }

        private void LoadPhongTro()
        {
            // Xóa các controls cũ trước khi cập nhật giao diện

            if (TrangThai)
            {
                Guna.UI2.WinForms.Guna2Button btnSuaKhach = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnXemThongTin = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnTraPhong = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnDoiPhong = new Guna.UI2.WinForms.Guna2Button();

                guna2Panel2.BackColor = System.Drawing.Color.FromArgb(133, 193, 233);


                btnSuaKhach.BorderColor = System.Drawing.Color.FromArgb(70, 184, 218);
                btnSuaKhach.BorderRadius = 4;
                btnSuaKhach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btnSuaKhach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnSuaKhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                btnSuaKhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                btnSuaKhach.FillColor = System.Drawing.Color.Purple;
                btnSuaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
                btnSuaKhach.ForeColor = System.Drawing.Color.White;
                btnSuaKhach.Image = global::GUI.Properties.Resources.EditUser;
                btnSuaKhach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                btnSuaKhach.Location = new System.Drawing.Point(151, 90);
                btnSuaKhach.Name = "btnSuaKhach";
                btnSuaKhach.Size = new System.Drawing.Size(41, 37);
                btnSuaKhach.TabIndex = 40;
                btnSuaKhach.Tag = "";
                btnSuaKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                toolTip1.SetToolTip(btnSuaKhach, "Sửa khách");
                guna2Panel2.Controls.Add(btnSuaKhach);
                // 
                // btnXemThongTin
                // 
                btnXemThongTin.BorderColor = System.Drawing.Color.FromArgb(70, 184, 218);
                btnXemThongTin.BorderRadius = 4;
                btnXemThongTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btnXemThongTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnXemThongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                btnXemThongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                btnXemThongTin.FillColor = System.Drawing.Color.DodgerBlue;
                btnXemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
                btnXemThongTin.ForeColor = System.Drawing.Color.White;
                btnXemThongTin.Image = global::GUI.Properties.Resources.Eye;
                btnXemThongTin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                btnXemThongTin.Location = new System.Drawing.Point(104, 90);
                btnXemThongTin.Name = "btnXemThongTin";
                btnXemThongTin.Size = new System.Drawing.Size(41, 37);
                btnXemThongTin.TabIndex = 39;
                btnXemThongTin.Tag = "";
                btnXemThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                toolTip1.SetToolTip(btnXemThongTin, "Xem thông tin");
                guna2Panel2.Controls.Add(btnXemThongTin);
                // 
                // btnTraPhong
                // 
                btnTraPhong.BorderColor = System.Drawing.Color.FromArgb(70, 184, 218);
                btnTraPhong.BorderRadius = 4;
                btnTraPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btnTraPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnTraPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                btnTraPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                btnTraPhong.FillColor = System.Drawing.Color.OrangeRed;
                btnTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
                btnTraPhong.ForeColor = System.Drawing.Color.White;
                btnTraPhong.Image = global::GUI.Properties.Resources.Door;
                btnTraPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                btnTraPhong.Location = new System.Drawing.Point(10, 90);
                btnTraPhong.Name = "btnTraPhong";
                btnTraPhong.Size = new System.Drawing.Size(41, 37);
                btnTraPhong.TabIndex = 38;
                btnTraPhong.Tag = "";
                btnTraPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                toolTip1.SetToolTip(btnTraPhong, "Trả phòng");
                guna2Panel2.Controls.Add(btnTraPhong);
                // 
                // btnDoiPhong
                // 
                btnDoiPhong.BorderColor = System.Drawing.Color.FromArgb(70, 184, 218);
                btnDoiPhong.BorderRadius = 4;
                btnDoiPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btnDoiPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnDoiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                btnDoiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                btnDoiPhong.FillColor = System.Drawing.Color.Orange;
                btnDoiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
                btnDoiPhong.ForeColor = System.Drawing.Color.White;
                btnDoiPhong.Image = global::GUI.Properties.Resources.ChangeRoom;
                btnDoiPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                btnDoiPhong.Location = new System.Drawing.Point(57, 90);
                btnDoiPhong.Name = "btnDoiPhong";
                btnDoiPhong.Size = new System.Drawing.Size(41, 37);
                btnDoiPhong.TabIndex = 37;
                btnDoiPhong.Tag = "";
                btnDoiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                toolTip1.SetToolTip(btnDoiPhong, "Đổi phòng");
                guna2Panel2.Controls.Add(btnDoiPhong);
            }
        }
    }
}