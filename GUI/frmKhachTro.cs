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
    public partial class frmKhachTro : Form
    {
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        public frmKhachTro()
        {
            InitializeComponent();
        }

        public void loadKhachTro()
        {
            dgvKhachTro.DataSource = khachTroBUL.LayDanhSachKhachTro();
            dgvKhachTro.Columns["DAXOA"].Visible = false;
        }

        private void frmKhachTro_Load(object sender, EventArgs e)
        {
            loadKhachTro();
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

        private void btnThemKhachTro_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemKhachTro_QLKT frmThemKT = new frmThemKhachTro_QLKT();
            frmThemKT.FormClosed += (s, args) =>
            {
                if (frmThemKT.kiemTraThanhCong)
                {
                    loadKhachTro();
                }
            };
            frmThemKT.ShowDialog();
            HideOverlay();
        }

        private void btnSuaKhachTro_Click(object sender, EventArgs e)
        {
            KhachTroDTO khachTroDTO = new KhachTroDTO();

            khachTroDTO.MaKT = dgvKhachTro.CurrentRow.Cells["MAKT"].Value.ToString();
            khachTroDTO.HoTen = dgvKhachTro.CurrentRow.Cells["HOTEN"].Value.ToString();
            khachTroDTO.DiaChi = dgvKhachTro.CurrentRow.Cells["DIACHI"].Value.ToString();
            khachTroDTO.SoDT = dgvKhachTro.CurrentRow.Cells["SODT"].Value.ToString();
            khachTroDTO.CCCD = dgvKhachTro.CurrentRow.Cells["CCCD"].Value.ToString();
            khachTroDTO.Email = dgvKhachTro.CurrentRow.Cells["EMAIL"].Value.ToString();
            khachTroDTO.NgaySinh = DateTime.Parse(dgvKhachTro.CurrentRow.Cells["NGAYSINH"].Value.ToString());
            khachTroDTO.GioiTinh = dgvKhachTro.CurrentRow.Cells["GIOITINH"].Value.ToString();
            khachTroDTO.Anh = dgvKhachTro.CurrentRow.Cells["ANH"].Value.ToString();
            khachTroDTO.DaXoa = int.Parse(dgvKhachTro.CurrentRow.Cells["DAXOA"].Value.ToString());
            khachTroDTO.MoTa = dgvKhachTro.CurrentRow.Cells["MOTA"].Value.ToString();

            ShowOverlay();
            frmSuaKhachTro_QLKT frmSuaKT = new frmSuaKhachTro_QLKT(khachTroDTO);
            frmSuaKT.FormClosed += (s, args) =>
            {
                if (frmSuaKT.kiemTraThanhCong)
                {
                    loadKhachTro();
                }
            };
            frmSuaKT.ShowDialog();
            HideOverlay();
        }

        private void btnXoaKhachTro_Click(object sender, EventArgs e)
        {
            KhachTroDTO khachTroDTO = new KhachTroDTO();

            khachTroDTO.MaKT = dgvKhachTro.CurrentRow.Cells["MAKT"].Value.ToString();
            khachTroDTO.HoTen = dgvKhachTro.CurrentRow.Cells["HOTEN"].Value.ToString();
            khachTroDTO.DiaChi = dgvKhachTro.CurrentRow.Cells["DIACHI"].Value.ToString();
            khachTroDTO.SoDT = dgvKhachTro.CurrentRow.Cells["SODT"].Value.ToString();
            khachTroDTO.CCCD = dgvKhachTro.CurrentRow.Cells["CCCD"].Value.ToString();
            khachTroDTO.Email = dgvKhachTro.CurrentRow.Cells["EMAIL"].Value.ToString();
            khachTroDTO.NgaySinh = DateTime.Parse(dgvKhachTro.CurrentRow.Cells["NGAYSINH"].Value.ToString());
            khachTroDTO.GioiTinh = dgvKhachTro.CurrentRow.Cells["GIOITINH"].Value.ToString();
            khachTroDTO.Anh = dgvKhachTro.CurrentRow.Cells["ANH"].Value.ToString();
            khachTroDTO.DaXoa = int.Parse(dgvKhachTro.CurrentRow.Cells["DAXOA"].Value.ToString());
            khachTroDTO.MoTa = dgvKhachTro.CurrentRow.Cells["MOTA"].Value.ToString();

            ShowOverlay();
            frmXoaKhachTro_QLKT frmXoaKT = new frmXoaKhachTro_QLKT(khachTroDTO);
            frmXoaKT.FormClosed += (s, args) =>
            {
                if (frmXoaKT.kiemTraThanhCong)
                {
                    loadKhachTro();
                }
            };
            frmXoaKT.ShowDialog();
            HideOverlay();
        }

        public void LoadKhachTroTimKiem(string ten)
        {
            List<KhachTroDTO> danhSachKhach = khachTroBUL.TimKiemKhachTro(ten);
            dgvKhachTro.DataSource = danhSachKhach;

            dgvKhachTro.Columns["Anh"].Visible = false;
            dgvKhachTro.Columns["MoTa"].Visible = false;
            dgvKhachTro.Columns["DaXoa"].Visible = false;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadKhachTroTimKiem(txtTraCuu.Text);
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string tenDichVu = txtTraCuu.Text.Trim();

            if (string.IsNullOrEmpty(tenDichVu))
            {
                LoadKhachTroTimKiem(tenDichVu);
            }
            else
            {
                LoadKhachTroTimKiem(tenDichVu);
            }
        }
    }
}
