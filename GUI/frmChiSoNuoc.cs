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
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace GUI
{
    public partial class frmChiSoNuoc : Form
    {
        ChiSoDienNuocBUL chiSoDienNuocBUL = new ChiSoDienNuocBUL();
        public frmChiSoNuoc()
        {
            InitializeComponent();
        }

        public void loadCSDienNuoc()
        {
            dgvChiSo.DataSource = chiSoDienNuocBUL.loadDienNuoc();
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

        private void frmChiSoNuoc_Load(object sender, EventArgs e)
        {
            loadCSDienNuoc();
        }

        private void btnThemChiSo_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemDienNuoc frmThemDN = new frmThemDienNuoc();
            frmThemDN.FormClosed += (s, args) =>
            {
                if (frmThemDN.kiemTraThanhCong)
                {
                    loadCSDienNuoc();
                }
            };
            frmThemDN.ShowDialog();
            HideOverlay();
        }

        private void btnSuaChiSo_Click(object sender, EventArgs e)
        {
            ChiSoDienNuocDTO chiSoDienNuocDTO = new ChiSoDienNuocDTO();

            chiSoDienNuocDTO.MaCS = int.Parse(dgvChiSo.CurrentRow.Cells["MACS"].Value.ToString());
            chiSoDienNuocDTO.MaPT = dgvChiSo.CurrentRow.Cells["MAPT"].Value.ToString();
            chiSoDienNuocDTO.NgayThang = DateTime.Parse(dgvChiSo.CurrentRow.Cells["NGAYTHANG"].Value.ToString());
            chiSoDienNuocDTO.ChiSoDien = int.Parse(dgvChiSo.CurrentRow.Cells["CHISODIEN"].Value.ToString());
            chiSoDienNuocDTO.ChiSoNuoc = int.Parse(dgvChiSo.CurrentRow.Cells["CHISONUOC"].Value.ToString());

            ShowOverlay();
            frmSuaDienNuoc frmSuaDN = new frmSuaDienNuoc(chiSoDienNuocDTO);
            frmSuaDN.FormClosed += (s, args) =>
            {
                if (frmSuaDN.kiemTraThanhCong)
                {
                    loadCSDienNuoc();
                }
            };
            frmSuaDN.ShowDialog();
            HideOverlay();
        }

        private void btnXoaChiSo_Click(object sender, EventArgs e)
        {
            ChiSoDienNuocDTO chiSoDienNuocDTO = new ChiSoDienNuocDTO();

            chiSoDienNuocDTO.MaCS = int.Parse(dgvChiSo.CurrentRow.Cells["MACS"].Value.ToString());
            chiSoDienNuocDTO.MaPT = dgvChiSo.CurrentRow.Cells["MAPT"].Value.ToString();
            chiSoDienNuocDTO.NgayThang = DateTime.Parse(dgvChiSo.CurrentRow.Cells["NGAYTHANG"].Value.ToString());
            chiSoDienNuocDTO.ChiSoDien = int.Parse(dgvChiSo.CurrentRow.Cells["CHISODIEN"].Value.ToString());
            chiSoDienNuocDTO.ChiSoNuoc = int.Parse(dgvChiSo.CurrentRow.Cells["CHISONUOC"].Value.ToString());

            ShowOverlay();
            frmXoaDienNuoc frmXoaDN = new frmXoaDienNuoc(chiSoDienNuocDTO);
            frmXoaDN.FormClosed += (s, args) =>
            {
                if (frmXoaDN.kiemTraThanhCong)
                {
                    loadCSDienNuoc();
                }
            };
            frmXoaDN.ShowDialog();
            HideOverlay();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string input = txtTraCuu.Text.Trim();
            string maPT = "";
            int ngay = 0;
            int thang = 0;
            int nam = 0;

            // Phân tích chuỗi
            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 1) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    else
                    {
                        maPT = parts[0]; 
                    }
                }
                else if (parts.Length == 2) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                }
                else if (parts.Length == 3) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                    if (int.TryParse(parts[2], out int year))
                    {
                        nam = year; 
                    }
                }
            }

            dgvChiSo.DataSource = chiSoDienNuocBUL.TimKiemDienNuoc(maPT, ngay, thang, nam);
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string input = txtTraCuu.Text.Trim();
            string maPT = "";
            int ngay = 0; 
            int thang = 0; 
            int nam = 0;

            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 1) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    else
                    {
                        maPT = parts[0]; 
                    }
                }
                else if (parts.Length == 2) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                }
                else if (parts.Length == 3) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                    if (int.TryParse(parts[2], out int year))
                    {
                        nam = year; 
                    }
                }
            }

            dgvChiSo.DataSource = chiSoDienNuocBUL.TimKiemDienNuoc(maPT, ngay, thang, nam);
        }
    }
}
