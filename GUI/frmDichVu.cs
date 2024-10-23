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
    public partial class frmDichVu : Form
    {
        private DichVuBUL dichVuBUL = new DichVuBUL();
        public frmDichVu()
        {
            InitializeComponent();
        }
        
        public void loadDichVu()
        {
            dgvDichVu.DataSource = dichVuBUL.loadDichVu();
            dgvDichVu.Columns["DAXOA"].Visible = false;
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            loadDichVu();
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
            frmThemDV.FormClosed += (s, args) =>
            {
                if (frmThemDV.kiemTraThanhCong)
                {
                    loadDichVu();
                }
            };
            frmThemDV.ShowDialog();
            HideOverlay();
        }

        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            
            DichVuDTO dichVuDTO = new DichVuDTO();

            dichVuDTO.MaDV = dgvDichVu.CurrentRow.Cells["MADV"].Value.ToString();
            dichVuDTO.TenDV = dgvDichVu.CurrentRow.Cells["TENDV"].Value.ToString();
            dichVuDTO.DonGia = decimal.Parse(dgvDichVu.CurrentRow.Cells["DONGIA"].Value.ToString());
            dichVuDTO.MoTa = dgvDichVu.CurrentRow.Cells["MOTA"].Value.ToString();
            dichVuDTO.DaXoa = bool.Parse(dgvDichVu.CurrentRow.Cells["DAXOA"].Value.ToString());

            ShowOverlay();
            frmSuaDichVu frmSuaDV = new frmSuaDichVu(dichVuDTO);
            frmSuaDV.FormClosed += (s, args) =>
            {
                if (frmSuaDV.kiemTraThanhCong)
                {
                    loadDichVu();
                }
            };
            frmSuaDV.ShowDialog();
            HideOverlay();
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            DichVuDTO dichVuDTO = new DichVuDTO();

            dichVuDTO.MaDV = dgvDichVu.CurrentRow.Cells["MADV"].Value.ToString();
            dichVuDTO.TenDV = dgvDichVu.CurrentRow.Cells["TENDV"].Value.ToString();
            dichVuDTO.DonGia = decimal.Parse(dgvDichVu.CurrentRow.Cells["DONGIA"].Value.ToString());
            dichVuDTO.MoTa = dgvDichVu.CurrentRow.Cells["MOTA"].Value.ToString();
            dichVuDTO.DaXoa = bool.Parse(dgvDichVu.CurrentRow.Cells["DAXOA"].Value.ToString());

            ShowOverlay();
            frmXoaDichVu frmXoaDV = new frmXoaDichVu(dichVuDTO);
            frmXoaDV.FormClosed += (s, args) =>
            {
                if (frmXoaDV.kiemTraThanhCong)
                {
                    loadDichVu();
                }
            };
            frmXoaDV.ShowDialog();
            HideOverlay();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = dichVuBUL.TimKiemDichVu(txtTraCuu.Text);
            dgvDichVu.Columns["DAXOA"].Visible = false;
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string tenDichVu = txtTraCuu.Text.Trim();

            if (string.IsNullOrEmpty(tenDichVu))
            {
                dgvDichVu.DataSource = dichVuBUL.loadDichVu(); 
            }
            else
            {
                dgvDichVu.DataSource = dichVuBUL.TimKiemDichVu(tenDichVu); 
            }
            dgvDichVu.Columns["DAXOA"].Visible = false;
        }
    }
}
