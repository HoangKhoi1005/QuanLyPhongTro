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
        HopDongBUL HopDongBUL = new HopDongBUL();
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        ToolTip toolTip1 = new ToolTip();
        KhachTroBUL KhachTroBUL = new KhachTroBUL();

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
            
            int soLuongKhach = HopDongBUL.DemSoLuongKhachTroTrongHopDong(HopDongBUL.TimMaHopDongTheoMaPhong(phong.MaPT));

            lblMaPhong.Text = phong.MaPT;
            lblSoLuong.Text = soLuongKhach.ToString() + "/" + phong.SoLuongNguoiTD.ToString();
            lblGiaPhong.Text = phong.DonGia.ToString("N0") + " VNĐ";
            lblTenKT.Text = KhachTroBUL.LayTenNguoiDaiDienTheoPhong(phong.MaPT);

            if(soLuongKhach == phong.SoLuongNguoiTD)
            {
                btnThemKT.Visible = false;
            }

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
                    btnThemKT.Visible = false;
                    break;
                case "Đã đặt":
                    guna2Panel2.BackColor = Color.FromArgb(40, 167, 69);
                    toolTip.SetToolTip(guna2Panel2, "Phòng đã đặt");
                    btnThemKT.Visible = false;
                    break;
                case "Báo trả phòng":
                    guna2Panel2.BackColor = Color.FromArgb(189, 195, 199);
                    toolTip.SetToolTip(guna2Panel2, "Phòng đã báo trả");
                    btnThemKT.Visible = false;
                    break;
                default:
                    guna2Panel2.BackColor = Color.Gray;
                    break;
            }

            if (TrangThai == "Có người")
            {
                //Guna.UI2.WinForms.Guna2Button btnSuaKhach = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnBaoTraPhong = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnTraPhong = new Guna.UI2.WinForms.Guna2Button();
                Guna.UI2.WinForms.Guna2Button btnDoiPhong = new Guna.UI2.WinForms.Guna2Button();

                iconPictureBox20.ForeColor = Color.White;
                iconPictureBox4.ForeColor = Color.White;
                iconPictureBox5.ForeColor = Color.White;
                iconPictureBox6.ForeColor = Color.White;
                lblMaPhong.ForeColor = Color.White;
                lblSoLuong.ForeColor = Color.White;

                //btnSuaKhach.BorderColor = Color.FromArgb(70, 184, 218);
                //btnSuaKhach.BorderRadius = 4;
                //btnSuaKhach.FillColor = Color.Purple;
                //btnSuaKhach.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                //btnSuaKhach.ForeColor = Color.White;
                //btnSuaKhach.Image = global::GUI.Properties.Resources.EditUser;
                //btnSuaKhach.Location = new Point(151, 90);
                //btnSuaKhach.Size = new Size(41, 37);
                //toolTip1.SetToolTip(btnSuaKhach, "Sửa khách");
                //guna2Panel2.Controls.Add(btnSuaKhach);

                btnBaoTraPhong.BorderColor = Color.FromArgb(70, 184, 218);
                btnBaoTraPhong.BorderRadius = 4;
                btnBaoTraPhong.FillColor = Color.DodgerBlue;
                btnBaoTraPhong.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                btnBaoTraPhong.ForeColor = Color.White;
                btnBaoTraPhong.Image = global::GUI.Properties.Resources.Alarm;
                btnBaoTraPhong.Location = new Point(104, 90);
                btnBaoTraPhong.Size = new Size(41, 37);
                btnBaoTraPhong.Click += new EventHandler(btnBaoTraPhong_Click);
                toolTip1.SetToolTip(btnBaoTraPhong, "Báo trả phòng");
                guna2Panel2.Controls.Add(btnBaoTraPhong);

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
                btnDoiPhong.Click += new EventHandler(btnDoiPhong_Click);
                toolTip1.SetToolTip(btnDoiPhong, "Đổi phòng");
                guna2Panel2.Controls.Add(btnDoiPhong);
            }
            else if (TrangThai == "Đã đặt")
            {
                Guna.UI2.WinForms.Guna2Button btnHuyDatPhong = new Guna.UI2.WinForms.Guna2Button();

                iconPictureBox20.ForeColor = Color.White;
                iconPictureBox4.ForeColor = Color.White;
                iconPictureBox5.ForeColor = Color.White;
                iconPictureBox6.ForeColor = Color.White;
                lblMaPhong.ForeColor = Color.White;
                lblSoLuong.ForeColor = Color.White;

                btnHuyDatPhong.BorderColor = Color.FromArgb(70, 184, 218);
                btnHuyDatPhong.BorderRadius = 4;
                btnHuyDatPhong.FillColor = Color.OrangeRed;
                btnHuyDatPhong.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                btnHuyDatPhong.ForeColor = Color.White;
                btnHuyDatPhong.Image = global::GUI.Properties.Resources.Door;
                btnHuyDatPhong.Location = new Point(10, 90);
                btnHuyDatPhong.Size = new Size(41, 37);
                btnHuyDatPhong.Click += new EventHandler(btnHuyDatPhong_Click);
                toolTip1.SetToolTip(btnHuyDatPhong, "Hủy đặt phòng");
                guna2Panel2.Controls.Add(btnHuyDatPhong);
            }
            else if (TrangThai == "Báo trả phòng")
            {
                Guna.UI2.WinForms.Guna2Button btnTraPhong = new Guna.UI2.WinForms.Guna2Button();

                iconPictureBox20.ForeColor = Color.White;
                iconPictureBox4.ForeColor = Color.White;
                iconPictureBox5.ForeColor = Color.White;
                iconPictureBox6.ForeColor = Color.White;
                lblMaPhong.ForeColor = Color.White;
                lblSoLuong.ForeColor = Color.White;

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
            }
        }

        public delegate void BaoTraPhongHandler(object sender, EventArgs e);

        public event BaoTraPhongHandler BaoTraPhongClick;

        private void btnBaoTraPhong_Click(object sender, EventArgs e)
        {
            if (BaoTraPhongClick != null)
            {
                BaoTraPhongClick(this, e);
            }
        }

        public delegate void HuyDatPhongHandler(object sender, EventArgs e);

        public event HuyDatPhongHandler HuyDatPhongClick;

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            if (HuyDatPhongClick != null)
            {
                HuyDatPhongClick(this, e);
            }
        }

        public delegate void ThemKhachTroHandler(object sender, EventArgs e);

        public event ThemKhachTroHandler ThemKhachTroClick;

        private void btnThemKT_Click(object sender, EventArgs e)
        {
            if (ThemKhachTroClick != null)
            {
                ThemKhachTroClick(this, e);
            }
        }

        public delegate void XoaPhongHandler(object sender, EventArgs e);

        public event XoaPhongHandler XoaPhongClick;

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if(XoaPhongClick != null)
            {
                XoaPhongClick(this, e);
            }
        }

        public delegate void SuaPhongHandler(object sender, EventArgs e);

        public event SuaPhongHandler SuaPhongClick;

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (SuaPhongClick != null)
            {
                SuaPhongClick(this, e);
            }
        }

        public delegate void UcClickHandler(object sender, EventArgs e);

        public event UcClickHandler UcClick;

        private void guna2Panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UcClick != null)
            {
                UcClick(this, e);
            }
        }

        public delegate void DoiPhongHandler(object sender, EventArgs e);

        public event DoiPhongHandler DoiPhongClick;

        private void btnDoiPhong_Click(object sender, EventArgs e)
        {
            if (DoiPhongClick != null)
            {
                DoiPhongClick(this, e);
            }
        }
    }
}
