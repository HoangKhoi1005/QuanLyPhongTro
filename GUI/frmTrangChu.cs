using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmTrangChu : Form
    {
        
        public frmTrangChu()
        {
            InitializeComponent();
            UCThongKeChung uCThongKeChung = new UCThongKeChung();
            addUserControl(uCThongKeChung);
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

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void dtpNgayThang_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThongKeDoanhThuTheoThang_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThuTheoThang frm = new frmThongKeDoanhThuTheoThang();
            ShowOverlay();
            frm.ShowDialog();
            HideOverlay();
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            grpNoiDung.Controls.Clear();
            grpNoiDung.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThongKeDoanhThuTheoThang_Click_1(object sender, EventArgs e)
        {
            UCThongKeChung uCThongKeChung = new UCThongKeChung();
            addUserControl(uCThongKeChung);
        }

        private void btnThongKeDoanhThuTheoThang_Click_2(object sender, EventArgs e)
        {
            UCThongKeDoanhThuTheoThang uCThongKeDoanhThuTheoThang = new UCThongKeDoanhThuTheoThang();
            addUserControl(uCThongKeDoanhThuTheoThang);
        }

        private void btnThongKeDoanhThuTheoNam_Click(object sender, EventArgs e)
        {
            UCThongKeDoanhThuTheoNam uCThongKeDoanhThuTheoNam = new UCThongKeDoanhThuTheoNam();
            addUserControl(uCThongKeDoanhThuTheoNam);
        }

        private void btnThongKeDoanhThuTheoNhaTro_Click(object sender, EventArgs e)
        {
            UCThongKeDoanhThuTheoNhaTro uCThongKeDoanhThuTheoNhaTro = new UCThongKeDoanhThuTheoNhaTro();
            addUserControl(uCThongKeDoanhThuTheoNhaTro);
        }
    }
}
