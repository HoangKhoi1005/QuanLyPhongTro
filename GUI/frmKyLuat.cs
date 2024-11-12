using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKyLuat : Form
    {
        KyLuatBUL kyLuatBUL = new KyLuatBUL();

        public frmKyLuat()
        {
            InitializeComponent();
            LoadDataGirdViewKyLuat();
            LoadCboLoaiKyLuat();
            dtpNgayKL.Value = DateTime.Now;
        }

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            LoadDataGirdViewKyLuat();
            dtpNgayKL.Value = DateTime.Now;
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

        public void LoadDataGirdViewKyLuat()
        {
            dgvKyLuat.DataSource = kyLuatBUL.LayDSKyLuatDataGirdView();
            dgvKyLuat.Columns["Anh"].Visible = false;
            dgvKyLuat.Columns["MAKL"].Visible = false;
            dgvKyLuat.Columns["MAKT"].Visible = false;

            if (dgvKyLuat.Columns.Contains("LOAIKYLUAT"))
            {
                foreach (DataGridViewRow row in dgvKyLuat.Rows)
                {
                    if (row.Cells["LOAIKYLUAT"].Value != null)
                    {
                        row.Cells["LOAIKYLUAT"].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        public void LoadCboLoaiKyLuat()
        {
            Dictionary<string, string> loaiKyLuat = new Dictionary<string, string>();
            loaiKyLuat.Add("1", "Cảnh cáo");
            loaiKyLuat.Add("2", "Kỷ luật");
            loaiKyLuat.Add("3", "Trục xuất");

            cboLoatKL.DataSource = new BindingSource(loaiKyLuat, null);
            cboLoatKL.DisplayMember = "Value";
            cboLoatKL.ValueMember = "Value";
        }

        public void DataBinding()
        {
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvKyLuat.DataSource, "MAPT");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvKyLuat.DataSource, "HOTEN");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvKyLuat.DataSource, "GIOITINH");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dgvKyLuat.DataSource, "NGAYSINH");
            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", dgvKyLuat.DataSource, "SODT");
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", dgvKyLuat.DataSource, "CCCD");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvKyLuat.DataSource, "DIACHI");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvKyLuat.DataSource, "EMAIL");
            dtpNgayKL.DataBindings.Clear();
            dtpNgayKL.DataBindings.Add("Text", dgvKyLuat.DataSource, "NGAYKL");
            cboLoatKL.DataBindings.Clear();
            cboLoatKL.DataBindings.Add("Text", dgvKyLuat.DataSource, "LOAIKYLUAT");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgvKyLuat.DataSource, "MOTA");

            string imagePath = dgvKyLuat.Rows[dgvKyLuat.CurrentCell.RowIndex].Cells["Anh"].Value?.ToString();

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                ptbAnh.Image = Image.FromFile(imagePath);
            }
            else
            {
                ptbAnh.Image = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemKyLuat frmThemKyLuat = new frmThemKyLuat(this);
            frmThemKyLuat.ShowDialog();
            HideOverlay();
            dgvKyLuat.DataSource = kyLuatBUL.LayDSKyLuatDataGirdView();
        }

        private void dgvKyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBinding();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng chọn khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả kỷ luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KyLuatDTO kyLuatDTO = new KyLuatDTO();
            kyLuatDTO.MaKL = int.Parse(dgvKyLuat.Rows[dgvKyLuat.CurrentCell.RowIndex].Cells["MAKL"].Value.ToString());
            kyLuatDTO.MaKT = dgvKyLuat.Rows[dgvKyLuat.CurrentCell.RowIndex].Cells["MAKT"].Value.ToString();
            kyLuatDTO.NgayKL = dtpNgayKL.Value;
            kyLuatDTO.MoTa = txtMoTa.Text;
            kyLuatDTO.LoaiKL = cboLoatKL.SelectedValue.ToString();

            if (kyLuatBUL.SuaKyLuat(kyLuatDTO))
            {
                MessageBox.Show("Lưu thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGirdViewKyLuat();
            }
            else
            {
                MessageBox.Show("Lưu thay đổi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtTraCuuHoTen.Text;
            string cccd = txtTraCuuCCCD.Text;
            string maPT = txtTraCuuMaPT.Text;

            if (string.IsNullOrEmpty(hoTen) && string.IsNullOrEmpty(cccd) && string.IsNullOrEmpty(maPT))
            {
                LoadDataGirdViewKyLuat();
                return;
            }

            dgvKyLuat.DataSource = kyLuatBUL.TraCuuKyLuat(hoTen, cccd, maPT);

        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTraCuuCCCD.Text = "";
            txtTraCuuHoTen.Text = "";
            txtTraCuuMaPT.Text = "";
            LoadDataGirdViewKyLuat();
        }
    }
}
