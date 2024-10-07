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
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        private NhaTroDTO nhaTroDangChon;

        public frmPhong()
        {
            InitializeComponent();
            LoadNhaTro();
            LoadTrangThai();
        }

        Form overlayPanel;

        private void ShowOverlay()
        {
            overlayPanel = new Form();
            overlayPanel.FormBorderStyle = FormBorderStyle.None;
            overlayPanel.StartPosition = FormStartPosition.Manual;
            overlayPanel.Location = this.Location;
            overlayPanel.Opacity = .50d;
            overlayPanel.BackColor = Color.Black;
            overlayPanel.WindowState = FormWindowState.Maximized;
            overlayPanel.ShowInTaskbar = false;
            overlayPanel.Show();
        }

        private void HideOverlay()
        {
            overlayPanel.Dispose();
        }

        public void LoadNhaTro()
        {
            panelDSNha.Controls.Clear();

            List<NhaTroDTO> lstNhaTro = nhaTroBUL.LayDanhSachNhaTro();

            int buttonWidth = 155;
            int buttonHeight = 54;
            int buttonSpacing = 10;
            int xPosition = 0;
            bool isFirstButton = true;

            foreach (var nhaTro in lstNhaTro)
            {
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
                btnNhaTro.Tag = nhaTro;

                if (isFirstButton)
                {
                    btnNhaTro.Checked = true;
                    string diaChi = nhaTroBUL.LayDiaChiNTTheoMaNT(nhaTro.MaNT);
                    groupMain.Text = "Danh sách phòng trọ tại " + diaChi;
                    nhaTroDangChon = (NhaTroDTO)btnNhaTro.Tag;
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
            nhaTroDangChon = (NhaTroDTO)btnNhaTro.Tag;
            string maNT = nhaTroDangChon.MaNT;
            string diaChi = nhaTroBUL.LayDiaChiNTTheoMaNT(maNT);
            groupMain.Text = "Danh sách phòng trọ tại " + diaChi;
            LoadPhongByNhaTro(maNT);
        }
    

        public void LoadPhongByNhaTro(string MaNT)
        {
            groupDSPhong.Controls.Clear();

            List<PhongDTO> lstPhong = phongBUL.LayPhongTheoNhaTro(MaNT);

            int ucXPosition = 19;
            int ucYPosition = 19;
            int kt = 0;

            foreach (var phong in lstPhong)
            {
                UCPhong uCPhong = new UCPhong();
                if (kt == 6)
                {
                    ucXPosition = 19;
                    ucYPosition += 19 + uCPhong.Width;
                    kt = 0;
                }
                
                uCPhong.LoadPhongTro(phong);
                uCPhong.Left = ucXPosition;
                uCPhong.Top = ucYPosition;

                ucXPosition += uCPhong.Width +19;
                kt++;
                groupDSPhong.Controls.Add(uCPhong);
            }
        }

        private void btnThemNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemNhaTro frmThemNhaTro = new frmThemNhaTro();
            frmThemNhaTro.FormClosed += (s, args) =>
            {
                if (frmThemNhaTro.kiemTraThanhCong)
                {
                    LoadNhaTro();
                }
            };
            frmThemNhaTro.ShowDialog();
            HideOverlay();
        }

        private void btnXoaNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmXoaNT frmXoaNT = new frmXoaNT(nhaTroDangChon);
            frmXoaNT.FormClosed += (s, args) =>
            {
                if (frmXoaNT.kiemTraThanhCong)
                {
                    LoadNhaTro();
                }
            };
            frmXoaNT.ShowDialog();
            HideOverlay();
        }

        private void btnSuaNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmSuaNT frmSuaNT = new frmSuaNT(nhaTroDangChon);
            frmSuaNT.FormClosed += (s, args) =>
            {
                if (frmSuaNT.kiemTraThanhCong)
                {
                    LoadNhaTro();
                }
            };
            frmSuaNT.ShowDialog();
            HideOverlay();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        public void LoadTrangThai()
        {
            var tatCaTrangThai = trangThaiPhongBUL.LayTatCaTrangThaiPhong();

            List<TrangThaiPhongDTO> danhSachTrangThai = new List<TrangThaiPhongDTO>
            {
                new TrangThaiPhongDTO { MaTT = "all", TenTrangThai = "Tất cả" }
            };
            danhSachTrangThai.AddRange(tatCaTrangThai);

            cboTrangThai.DataSource = danhSachTrangThai;
            cboTrangThai.DisplayMember = "TENTRANGTHAI";
            cboTrangThai.ValueMember = "MATT";


            cboTrangThai.SelectedIndex = 0;
        }

        //Lọc phòng theo trạng thái
        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.SelectedIndex == 0)
            {
                LoadPhongByNhaTro(nhaTroDangChon.MaNT);
            }
            else
            {
                string maTT = cboTrangThai.SelectedValue.ToString();
                List<PhongDTO> lstPhong = phongBUL.LayPhongTheoTrangThai(maTT, nhaTroDangChon.MaNT);
                groupDSPhong.Controls.Clear();

                int ucXPosition = 19;
                int ucYPosition = 19;
                int kt = 0;

                foreach (var phong in lstPhong)
                {
                    UCPhong uCPhong = new UCPhong();
                    if (kt == 6)
                    {
                        ucXPosition = 19;
                        ucYPosition += 19 + uCPhong.Width;
                        kt = 0;
                    }

                    uCPhong.LoadPhongTro(phong);
                    uCPhong.Left = ucXPosition;
                    uCPhong.Top = ucYPosition;

                    ucXPosition += uCPhong.Width + 19;
                    kt++;
                    groupDSPhong.Controls.Add(uCPhong);
                }
            }
        }
    }
}
