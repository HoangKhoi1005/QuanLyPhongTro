using BUL;
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
    public partial class frmDichVu : Form
    {
        private DichVuBUL dichVuBUL = new DichVuBUL();
        public frmDichVu()
        {
            InitializeComponent();
        }
        
        public void loadDichVu()
        {

        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = dichVuBUL.loadDichVu();
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemDichVu frmThemDV = new frmThemDichVu();
            //frmThemNhaTro.FormClosed += (s, args) =>
            //{
            //    if (frmThemNhaTro.kiemTraThanhCong)
            //    {
            //        LoadNhaTro();
            //    }
            //};
            frmThemDV.ShowDialog();
            HideOverlay();
        }

        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmSuaDichVu frmSuaDV = new frmSuaDichVu();
            frmSuaDV.ShowDialog();
            HideOverlay();
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmXoaDichVu frmXoaDV = new frmXoaDichVu();
            frmXoaDV.ShowDialog();
            HideOverlay();
        }
    }
}
