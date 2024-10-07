using BUL;
using DTO;
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
        private string trangThai;
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        ToolTip toolTip1 = new ToolTip();

        public string TrangThai
        {
            get { return trangThai; }
            set
            {
                trangThai = value;
            }
        }

        public UCPhong()
        {
            InitializeComponent();
        }

        public void LoadPhongTro(PhongDTO phong)
        {
            string tenTrangThai = trangThaiPhongBUL.LayTenTrangThaiTheoMa(phong.MaTT);
            this.TrangThai = tenTrangThai;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnSuaPhong, "Sửa phòng");
            toolTip.SetToolTip(btnXoaPhong, "Xóa phòng");
            toolTip.SetToolTip(btnThemKT, "Thêm khách");

            lblMaPhong.Text = phong.MaPT;
            lblSoLuong.Text = phong.SoLuongNguoiTD.ToString();
            lblGiaPhong.Text = phong.DonGia.ToString("N0") + " VNĐ";

            switch (TrangThai)
            {
                case "Trống":
                    toolTip.SetToolTip(guna2Panel2, "Phòng trống");
                    break;
                case "Có người":
                    guna2Panel2.BackColor = Color.FromArgb(133, 193, 233);
                    toolTip.SetToolTip(guna2Panel2, "Phòng có người");
                    break;
                case "Đang sửa chữa":
                    guna2Panel2.BackColor = Color.FromArgb(241, 196, 15);
                    toolTip.SetToolTip(guna2Panel2, "Phòng đang sửa chữa");
                    break;
                case "Đã đặt":
                    guna2Panel2.BackColor = Color.FromArgb(40, 167, 69);
                    toolTip.SetToolTip(guna2Panel2, "Phòng đã đặt");
                    break;
                default:
                    guna2Panel2.BackColor = Color.Gray;
                    break;
            }

            if (TrangThai == "Có người" || TrangThai == "Đã đặt")
            {
                Guna.UI2.WinForms.Guna2Button btnSuaKhach = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnXemThongTin = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnTraPhong = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnDoiPhong = new Guna.UI2.WinForms.Guna2Button();

                iconPictureBox20.ForeColor = Color.White;
                iconPictureBox4.ForeColor = Color.White;
                iconPictureBox5.ForeColor = Color.White;
                iconPictureBox6.ForeColor = Color.White;
                lblMaPhong.ForeColor = Color.White;
                lblSoLuong.ForeColor = Color.White;

                btnSuaKhach.BorderColor = Color.FromArgb(70, 184, 218);
                btnSuaKhach.BorderRadius = 4;
                btnSuaKhach.FillColor = Color.Purple;
                btnSuaKhach.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                btnSuaKhach.ForeColor = Color.White;
                btnSuaKhach.Image = global::GUI.Properties.Resources.EditUser;
                btnSuaKhach.Location = new Point(151, 90);
                btnSuaKhach.Size = new Size(41, 37);
                toolTip1.SetToolTip(btnSuaKhach, "Sửa khách");
                guna2Panel2.Controls.Add(btnSuaKhach);

                btnXemThongTin.BorderColor = Color.FromArgb(70, 184, 218);
                btnXemThongTin.BorderRadius = 4;
                btnXemThongTin.FillColor = Color.DodgerBlue;
                btnXemThongTin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                btnXemThongTin.ForeColor = Color.White;
                btnXemThongTin.Image = global::GUI.Properties.Resources.Eye;
                btnXemThongTin.Location = new Point(104, 90);
                btnXemThongTin.Size = new Size(41, 37);
                toolTip1.SetToolTip(btnXemThongTin, "Xem thông tin");
                guna2Panel2.Controls.Add(btnXemThongTin);

                btnTraPhong.BorderColor = Color.FromArgb(70, 184, 218);
                btnTraPhong.BorderRadius = 4;
                btnTraPhong.FillColor = Color.OrangeRed;
                btnTraPhong.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                btnTraPhong.ForeColor = Color.White;
                btnTraPhong.Image = global::GUI.Properties.Resources.Door;
                btnTraPhong.Location = new Point(10, 90);
                btnTraPhong.Size = new Size(41, 37);
                toolTip1.SetToolTip(btnTraPhong, "Trả phòng");
                guna2Panel2.Controls.Add(btnTraPhong);

                btnDoiPhong.BorderColor = Color.FromArgb(70, 184, 218);
                btnDoiPhong.BorderRadius = 4;
                btnDoiPhong.FillColor = Color.Orange;
                btnDoiPhong.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                btnDoiPhong.ForeColor = Color.White;
                btnDoiPhong.Image = global::GUI.Properties.Resources.ChangeRoom;
                btnDoiPhong.Location = new Point(57, 90);
                btnDoiPhong.Size = new Size(41, 37);
                toolTip1.SetToolTip(btnDoiPhong, "Đổi phòng");
                guna2Panel2.Controls.Add(btnDoiPhong);
            }
        }
    }
}
