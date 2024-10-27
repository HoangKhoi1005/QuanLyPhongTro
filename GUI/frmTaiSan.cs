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
    public partial class frmTaiSan : Form
    {
        TaiSanBUL taiSanBUL = new TaiSanBUL();

        public frmTaiSan()
        {
            InitializeComponent();
            
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

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string tenTS = txtTaiSan.Text;
            string maPT = txtMaPhong.Text;

            dgvTaiSan.DataSource = taiSanBUL.TraCuuTaiSan(tenTS, maPT);
        }

        private void frmTaiSan_Load(object sender, EventArgs e)
        {
            dgvTaiSan.DataSource = taiSanBUL.LayDSTaiSan();

            dgvTaiSan.Columns["DaXoa"].Visible = false;
            dgvTaiSan.Columns["DaHu"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemTaiSan frm = new frmThemTaiSan();
            frm.FormClosed += (s, args) =>
            {
                if (frm.kiemTraThanhCong)
                {
                    dgvTaiSan.DataSource = taiSanBUL.LayDSTaiSan();
                }
            };
            frm.ShowDialog();
            HideOverlay();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            TaiSanDTO taiSan = new TaiSanDTO();
            taiSan.MaTS = dgvTaiSan.CurrentRow.Cells["MaTS"].Value.ToString();
            taiSan.MaPT = dgvTaiSan.CurrentRow.Cells["MaPT"].Value.ToString();
            taiSan.TenTaiSan = dgvTaiSan.CurrentRow.Cells["TenTaiSan"].Value.ToString();
            taiSan.DonGia = decimal.Parse(dgvTaiSan.CurrentRow.Cells["DonGia"].Value.ToString());
            taiSan.NgaySuDung = DateTime.Parse(dgvTaiSan.CurrentRow.Cells["NgaySuDung"].Value.ToString());
            taiSan.NgayThanhLy = dgvTaiSan.CurrentRow.Cells["NgayThanhLy"].Value != null
                ? (DateTime?)DateTime.Parse(dgvTaiSan.CurrentRow.Cells["NgayThanhLy"].Value.ToString())
                : null;
            taiSan.MoTa = dgvTaiSan.CurrentRow.Cells["MoTa"].Value.ToString();
            taiSan.DaXoa = bool.Parse(dgvTaiSan.CurrentRow.Cells["DaXoa"].Value.ToString());
            taiSan.DaHu = bool.Parse(dgvTaiSan.CurrentRow.Cells["DaHu"].Value.ToString());
            frmSuaTaiSan frm = new frmSuaTaiSan(taiSan);
            frm.FormClosed += (s, args) =>
            {
                if (frm.kiemTraThanhCong)
                {
                    dgvTaiSan.DataSource = taiSanBUL.LayDSTaiSan();
                }
            };
            frm.ShowDialog();
            HideOverlay();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            TaiSanDTO taiSan = new TaiSanDTO();
            taiSan.MaTS = dgvTaiSan.CurrentRow.Cells["MaTS"].Value.ToString();
            taiSan.MaPT = dgvTaiSan.CurrentRow.Cells["MaPT"].Value.ToString();
            taiSan.TenTaiSan = dgvTaiSan.CurrentRow.Cells["TenTaiSan"].Value.ToString();
            taiSan.DonGia = decimal.Parse(dgvTaiSan.CurrentRow.Cells["DonGia"].Value.ToString());
            taiSan.NgaySuDung = DateTime.Parse(dgvTaiSan.CurrentRow.Cells["NgaySuDung"].Value.ToString());
            taiSan.NgayThanhLy = dgvTaiSan.CurrentRow.Cells["NgayThanhLy"].Value != null
                ? (DateTime?)DateTime.Parse(dgvTaiSan.CurrentRow.Cells["NgayThanhLy"].Value.ToString())
                : null;
            taiSan.MoTa = dgvTaiSan.CurrentRow.Cells["MoTa"].Value.ToString();
            taiSan.DaXoa = bool.Parse(dgvTaiSan.CurrentRow.Cells["DaXoa"].Value.ToString());
            taiSan.DaHu = bool.Parse(dgvTaiSan.CurrentRow.Cells["DaHu"].Value.ToString());
            frmXoaTaiSan frm = new frmXoaTaiSan(taiSan);
            frm.FormClosed += (s, args) =>
            {
                if (frm.kiemTraThanhCong)
                {
                    dgvTaiSan.DataSource = taiSanBUL.LayDSTaiSan();
                }
            };
            frm.ShowDialog();
            HideOverlay();
        }
    }
}
