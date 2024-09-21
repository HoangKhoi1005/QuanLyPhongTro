using BUL;
using DTO;
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
    public partial class frmPhong : Form
    {
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        PhongBUL phongBUL = new PhongBUL();
        public frmPhong()
        {
            InitializeComponent();
            LoadNhaTro();
            
        }

        public void LoadNhaTro()
        {
            // Xóa tất cả các control hiện tại trong panel trước khi thêm mới
            panelDSNha.Controls.Clear();

            // Lấy danh sách nhà trọ từ tầng nghiệp vụ (Business Layer)
            List<NhaTroDTO> lstNhaTro = nhaTroBUL.LayDanhSachNhaTro();

            int buttonWidth = 155;
            int buttonHeight = 54;
            int buttonSpacing = 10;
            int xPosition = 0;
            bool isFirstButton = true;

            foreach (var nhaTro in lstNhaTro)
            {
                // Tạo button mới
                Guna.UI2.WinForms.Guna2Button btnNhaTro = new Guna.UI2.WinForms.Guna2Button();
                btnNhaTro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                btnNhaTro.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnNhaTro.CheckedState.FillColor = System.Drawing.Color.White;
                btnNhaTro.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
                btnNhaTro.FillColor = System.Drawing.Color.White;
                btnNhaTro.Font = new System.Drawing.Font("Segoe UI", 9F);
                btnNhaTro.ForeColor = System.Drawing.Color.Black;
                btnNhaTro.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnNhaTro.HoverState.FillColor = System.Drawing.Color.White;
                btnNhaTro.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                btnNhaTro.Location = new System.Drawing.Point(xPosition, 0);
                btnNhaTro.Text = nhaTro.TenNT;
                btnNhaTro.Tag = nhaTro.MaNT;

                if (isFirstButton)
                {
                    btnNhaTro.Checked = true;
                    MessageBox.Show(nhaTro.MaNT);
                    LoadPhongByNhaTro(nhaTro.MaNT);
                    isFirstButton = false;
                }


                panelDSNha.Controls.Add(btnNhaTro);
                btnNhaTro.Click += BtnNhaTro_Click;

                xPosition += buttonWidth + buttonSpacing;
            }
        }

        private void BtnNhaTro_Click(object sender, EventArgs e)

        {
            Guna.UI2.WinForms.Guna2Button btnNhaTro = (Guna.UI2.WinForms.Guna2Button)sender;
            string maNT = btnNhaTro.Tag.ToString();
            LoadPhongByNhaTro(maNT);
        }
    

        public void LoadPhongByNhaTro(string MaNT)
        {
            groupDSPhong.Controls.Clear();

            List<PhongDTO> lstPhong = phongBUL.LayPhongTheoNhaTro(MaNT);

            int panelSpacing = 270;
            int xPosition = 19;
            // Khởi tạo ToolTip trong Form
            ToolTip toolTip1 = new ToolTip();

            foreach (var phong in lstPhong)
            {
                // Tạo Guna2Panel
                Guna.UI2.WinForms.Guna2Panel guna2Panel = new Guna.UI2.WinForms.Guna2Panel();

                // Cấu hình thuộc tính cho Guna2Panel
                guna2Panel.BackColor = System.Drawing.SystemColors.Control;
                guna2Panel.BorderColor = System.Drawing.Color.Silver;
                guna2Panel.BorderRadius = 4;
                guna2Panel.BorderThickness = 2;
                guna2Panel.Location = new System.Drawing.Point(xPosition, 19);
                guna2Panel.Size = new System.Drawing.Size(250, 250);
                guna2Panel.TabIndex = 23;

                // Tạo và cấu hình các điều khiển bên trong Guna2Panel
                // Label2
                Guna.UI2.WinForms.Guna2HtmlLabel label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
                label2.AutoSize = true;
                label2.ForeColor = System.Drawing.Color.Gray;
                label2.Location = new System.Drawing.Point(33, 33);
                label2.Text = "3/4";
                label2.TabIndex = 38;
                guna2Panel.Controls.Add(label2);

                // IconPictureBox20
                FontAwesome.Sharp.IconPictureBox iconPictureBox20 = new FontAwesome.Sharp.IconPictureBox();
                iconPictureBox20.BackColor = System.Drawing.Color.Transparent;
                iconPictureBox20.ForeColor = System.Drawing.Color.Gray;
                iconPictureBox20.IconChar = FontAwesome.Sharp.IconChar.Users;
                iconPictureBox20.IconColor = System.Drawing.Color.Gray;
                iconPictureBox20.IconFont = FontAwesome.Sharp.IconFont.Auto;
                iconPictureBox20.IconSize = 20;
                iconPictureBox20.Location = new System.Drawing.Point(10, 33);
                iconPictureBox20.Size = new System.Drawing.Size(20, 20);
                iconPictureBox20.TabIndex = 37;
                guna2Panel.Controls.Add(iconPictureBox20);

                // Label3
                Guna.UI2.WinForms.Guna2HtmlLabel label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
                label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
                label3.Location = new System.Drawing.Point(33, 153);
                label3.Size = new System.Drawing.Size(112, 17);
                label3.Text = "Trần Hoàng Khôi";
                label3.TabIndex = 34;
                guna2Panel.Controls.Add(label3);

                // IconPictureBox4
                FontAwesome.Sharp.IconPictureBox iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
                iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
                iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
                iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
                iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(125, 137, 149);
                iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
                iconPictureBox4.IconSize = 20;
                iconPictureBox4.Location = new System.Drawing.Point(10, 150);
                iconPictureBox4.Size = new System.Drawing.Size(20, 20);
                iconPictureBox4.TabIndex = 33;
                iconPictureBox4.TabStop = false;
                guna2Panel.Controls.Add(iconPictureBox4);

                // Label4
                Guna.UI2.WinForms.Guna2HtmlLabel label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
                label4.AutoSize = true;
                label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
                label4.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
                label4.Location = new System.Drawing.Point(33, 176);
                label4.Text = "3.000.000 VNĐ";
                label4.Size = new System.Drawing.Size(98, 17);
                label4.TabIndex = 32;
                guna2Panel.Controls.Add(label4);

                // IconPictureBox5
                FontAwesome.Sharp.IconPictureBox iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
                iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
                iconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
                iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
                iconPictureBox5.IconColor = System.Drawing.Color.FromArgb(125, 137, 149);
                iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
                iconPictureBox5.IconSize = 20;
                iconPictureBox5.Location = new System.Drawing.Point(10, 176);
                iconPictureBox5.Size = new System.Drawing.Size(20, 20);
                iconPictureBox5.TabIndex = 31;
                iconPictureBox5.TabStop = false;
                guna2Panel.Controls.Add(iconPictureBox5);

                // Guna2Button14
                Guna.UI2.WinForms.Guna2Button guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
                guna2Button14.BorderColor = System.Drawing.Color.FromArgb(46, 109, 164);
                guna2Button14.BorderRadius = 4;
                guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                guna2Button14.FillColor = System.Drawing.Color.FromArgb(51, 122, 183);
                guna2Button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold);
                guna2Button14.ForeColor = System.Drawing.Color.White;
                guna2Button14.Image = global::GUI.Properties.Resources.Edit;
                guna2Button14.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                guna2Button14.Location = new System.Drawing.Point(10, 202);
                guna2Button14.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
                guna2Button14.Size = new System.Drawing.Size(115, 35);
                guna2Button14.TabIndex = 30;
                guna2Button14.Text = "Chỉnh sửa";
                toolTip1.SetToolTip(guna2Button14, "Chỉnh sửa phòng");
                guna2Panel.Controls.Add(guna2Button14);

                // Guna2Button15
                Guna.UI2.WinForms.Guna2Button guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
                guna2Button15.BorderColor = System.Drawing.Color.FromArgb(22, 159, 133);
                guna2Button15.BorderRadius = 4;
                guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                guna2Button15.FillColor = System.Drawing.Color.FromArgb(217, 83, 79);
                guna2Button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                guna2Button15.ForeColor = System.Drawing.Color.White;
                guna2Button15.Image = global::GUI.Properties.Resources.Delete;
                guna2Button15.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                guna2Button15.Location = new System.Drawing.Point(131, 202);
                guna2Button15.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
                guna2Button15.Size = new System.Drawing.Size(94, 35);
                guna2Button15.Text = "Xóa";
                guna2Button15.TabIndex = 29;
                toolTip1.SetToolTip(guna2Button15, "Xóa phòng");
                guna2Panel.Controls.Add(guna2Button15);

                // Guna2Button16
                Guna.UI2.WinForms.Guna2Button guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
                guna2Button16.BorderColor = System.Drawing.Color.FromArgb(70, 184, 218);
                guna2Button16.BorderRadius = 4;
                guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
                guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
                guna2Button16.FillColor = System.Drawing.Color.FromArgb(22, 159, 133);
                guna2Button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold);
                guna2Button16.ForeColor = System.Drawing.Color.White;
                guna2Button16.Image = global::GUI.Properties.Resources.AddUser;
                guna2Button16.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                guna2Button16.Location = new System.Drawing.Point(146, 9);
                guna2Button16.Size = new System.Drawing.Size(89, 37);
                guna2Button16.TabIndex = 28;
                guna2Button16.Text = "Thêm";
                guna2Button16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                toolTip1.SetToolTip(guna2Button16, "Thêm khách");
                guna2Panel.Controls.Add(guna2Button16);

                // Label5
                Guna.UI2.WinForms.Guna2HtmlLabel label5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
                label5.AutoSize = true;
                label5.Location = new System.Drawing.Point(33, 9);
                label5.Size = new System.Drawing.Size(41, 20);
                label5.TabIndex = 1;
                label5.Text = "P101";
                guna2Panel.Controls.Add(label5);

                // IconPictureBox6
                FontAwesome.Sharp.IconPictureBox iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
                iconPictureBox6.BackColor = System.Drawing.SystemColors.Control;
                iconPictureBox6.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
                iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.House;
                iconPictureBox6.IconColor = System.Drawing.Color.FromArgb(125, 137, 149);
                iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
                iconPictureBox6.IconSize = 20;
                iconPictureBox6.Location = new System.Drawing.Point(10, 9);
                iconPictureBox6.Size = new System.Drawing.Size(20, 20);
                iconPictureBox6.TabIndex = 0;
                iconPictureBox6.TabStop = false;
                guna2Panel.Controls.Add(iconPictureBox6);

                // Thêm Guna2Panel vào form hoặc panel cha của bạn
                groupDSPhong.Controls.Add(guna2Panel); // Thay thế bằng panel của bạn nếu cần

                xPosition += panelSpacing;

                if (phongBUL.KiemTraPhongDaCoHopDong(phong.MaPT))
                {
                    Guna.UI2.WinForms.Guna2Button btnSuaKhach = new Guna.UI2.WinForms.Guna2Button();
                    Guna.UI2.WinForms.Guna2Button btnXemThongTin = new Guna.UI2.WinForms.Guna2Button();
                    Guna.UI2.WinForms.Guna2Button btnTraPhong = new Guna.UI2.WinForms.Guna2Button();
                    Guna.UI2.WinForms.Guna2Button btnDoiPhong = new Guna.UI2.WinForms.Guna2Button();

                    guna2Panel.BackColor = System.Drawing.Color.FromArgb(133, 193, 233);


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
                    toolTip1.SetToolTip( btnSuaKhach, "Sửa khách");
                    guna2Panel.Controls.Add(btnSuaKhach);
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
                    toolTip1.SetToolTip( btnXemThongTin, "Xem thông tin");
                    guna2Panel.Controls.Add(btnXemThongTin);
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
                    toolTip1.SetToolTip( btnTraPhong, "Trả phòng");
                    guna2Panel.Controls.Add(btnTraPhong);
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
                    toolTip1.SetToolTip( btnDoiPhong, "Đổi phòng");
                    guna2Panel.Controls.Add(btnDoiPhong);
                }
            }    
        }    
    }
}
