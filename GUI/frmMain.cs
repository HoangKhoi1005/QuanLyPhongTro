using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Label arrowLabel = new Label();
        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Tạo Label cho mũi tên
            arrowLabel.BackColor = Color.Transparent;
            arrowLabel.Text = "▶";
            arrowLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            arrowLabel.ForeColor = Color.Gainsboro;
            arrowLabel.Location = new Point(btnQuanLyDichVu.Width - 30, btnQuanLyDichVu.Height / 2 - 8);
            arrowLabel.AutoSize = true;
            btnQuanLyDichVu.Controls.Add(arrowLabel);

            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Text = "  " + menuButton.Tag.ToString();

            }
            foreach (Button menuButton in groupAdmin.Controls.OfType<Button>())
            {
                menuButton.Text = "  " + menuButton.Tag.ToString();

            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(220, 212, 203);
            public static Color color8 = Color.FromArgb(220, 21, 103);
            public static Color color9 = Color.FromArgb(20, 212, 203);
            public static Color color10 = Color.FromArgb(123, 212, 203);
            public static Color color11 = Color.FromArgb(220, 91, 203);
            public static Color color12 = Color.FromArgb(220, 212, 20);
            public static Color color13 = Color.FromArgb(220, 33, 20);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                if (groupAdmin.Controls.Contains(currentBtn))
                {
                    leftBorderBtn.Location = new Point(0, groupAdmin.Location.Y);
                }
                else
                {
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                }
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(42, 63, 84);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            lblTitleChildForm.ForeColor = currentBtn.IconColor;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTrangChu());
            CollapseMenuWithButton();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmPhong());
            CollapseMenuWithButton();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmDichVu());
            CollapseMenuWithButton();
        }

        private void btnChiSoDien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmChiSoDien());
            CollapseMenuWithButton();
        }

        private void btnChiSoNuoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new frmChiSoNuoc());
            CollapseMenuWithButton();
        }

        private void btnTienPhatSinh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmTienPhatSinh());
            CollapseMenuWithButton();
        }

        private void btnTienPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new frmTinhTienPhong());
            CollapseMenuWithButton();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new frmNhanVien());
            CollapseMenuWithButton();
        }

        private void btnTaiSan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(new frmTaiSan());
            CollapseMenuWithButton();
        }

        private void btnCocGiuPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            OpenChildForm(new frmCocGiuPhong());
            CollapseMenuWithButton();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color13);
            OpenChildForm(new frmHopDong());
            CollapseMenuWithButton();
        }

        bool isExpanded = false;

        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            ActivateButton(sender, RGBColors.color12);
            CollapseMenuWithButton();
            lblTitleChildForm.Text = "Quản lý dịch vụ";
            lblTitleChildForm.ForeColor = currentBtn.IconColor;
            isExpanded = !isExpanded;

            if (isExpanded)
            {
                arrowLabel.Text = "▼";
            }
            else
            {
                arrowLabel.Text = "▶";
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color11);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Trang chủ";
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnThuPhongMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnThuPhongMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                groupAdmin.Width = 100;
                foreach (Button menuButton in groupAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(25, 0, 0, 10);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnThuPhongMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                groupAdmin.Width = 230;
                foreach (Button menuButton in groupAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void CollapseMenuWithButton()
        {
            panelMenu.Width = 230;
            pictureBox1.Visible = true;
            btnThuPhongMenu.Dock = DockStyle.None;
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Text = "   " + menuButton.Tag.ToString();
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                menuButton.Padding = new Padding(10, 0, 0, 0);
            }
            foreach (Button menuButton in groupAdmin.Controls.OfType<Button>())
            {
                menuButton.Text = "   " + menuButton.Tag.ToString();
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                menuButton.Padding = new Padding(10, 0, 0, 0);
            }
        }

        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                groupAdmin.Height += 10;
                if (groupAdmin.Height >= 254)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                groupAdmin.Height -= 10;
                if (groupAdmin.Height <= 60)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }


    }
}
