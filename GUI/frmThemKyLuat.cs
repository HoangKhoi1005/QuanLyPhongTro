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
    public partial class frmThemKyLuat : MetroFramework.Forms.MetroForm
    {
        KhachTroBUL khachTroBUL = new KhachTroBUL();
        private frmKyLuat frmKyLuat;

        public frmThemKyLuat(frmKyLuat frmKyLuat)
        {
            InitializeComponent();
            this.frmKyLuat = frmKyLuat;
            dtpNgayKL.Value = DateTime.Now;
        }

        public void LoadKhachTro()
        {
            List<KhachTroDTO> danhSachKhach = khachTroBUL.LayDSKhachTroDaThuePhong();
            dgvKhachTro.DataSource = danhSachKhach;

            dgvKhachTro.Columns["Anh"].Visible = false;
            dgvKhachTro.Columns["MoTa"].Visible = false;
            dgvKhachTro.Columns["DaXoa"].Visible = false;
        }

        private void frmThemKyLuat_Load(object sender, EventArgs e)
        {
            LoadCboLoaiKyLuat();
            LoadKhachTro();
            dtpNgayKL.Value = DateTime.Now;
        }

        public void dataBinding()
        {
            txtTenKT.DataBindings.Clear();
            txtTenKT.DataBindings.Add("Text", dgvKhachTro.DataSource, "HOTEN");
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", dgvKhachTro.DataSource, "CCCD");
            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", dgvKhachTro.DataSource, "SODT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvKhachTro.DataSource, "DIACHI");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvKhachTro.DataSource, "Email");
            rdbNam.DataBindings.Clear();
            rdbNam.DataBindings.Add("Checked", dgvKhachTro.DataSource, "GIOITINH", true);
            rdbNam.DataBindings[0].Format += (s, e) =>
            {
                if (e.DesiredType == typeof(bool))
                {
                    e.Value = (e.Value.ToString() == "Nam");
                }
            };

            rdbNu.DataBindings.Clear();
            rdbNu.DataBindings.Add("Checked", dgvKhachTro.DataSource, "GIOITINH", true);
            rdbNu.DataBindings[0].Format += (s, e) =>
            {
                if (e.DesiredType == typeof(bool))
                {
                    e.Value = (e.Value.ToString() == "Nữ");
                }
            };
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvKhachTro.DataSource, "NGAYSINH");

            string imagePath = dgvKhachTro.Rows[dgvKhachTro.CurrentCell.RowIndex].Cells["Anh"].Value?.ToString();

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                ptbKhachTro.Image = Image.FromFile(imagePath);
            }
            else
            {
                ptbKhachTro.Image = null;
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

        private void dgvKhachTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataBinding();
        }

        private void btnThemKyLuat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenKT.Text))
            {
                MessageBox.Show("Vui lòng chọn khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả kỷ luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KyLuatBUL kyLuatBUL = new KyLuatBUL();
            KyLuatDTO kyLuatDTO = new KyLuatDTO();
            kyLuatDTO.MaKT = dgvKhachTro.Rows[dgvKhachTro.CurrentCell.RowIndex].Cells["MAKT"].Value.ToString();
            kyLuatDTO.NgayKL = DateTime.Now;
            kyLuatDTO.MoTa = txtMoTa.Text;
            kyLuatDTO.LoaiKL = cboLoatKL.SelectedValue.ToString();

            if (kyLuatBUL.ThemKyLuat(kyLuatDTO))
            {
                frmKyLuat.dgvKyLuat.DataSource = kyLuatBUL.LayDSKyLuatDataGirdView();
                MessageBox.Show("Thêm kỷ luật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm kỷ luật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMoTa.Text = "";
            cboLoatKL.SelectedIndex = 0;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtTraCuuHoTen.Text;
            string cccd = txtTraCuuCCCD.Text;
            string maPT = txtTraCuuMaPT.Text;

            if (string.IsNullOrEmpty(hoTen) && string.IsNullOrEmpty(cccd) && string.IsNullOrEmpty(maPT))
            {
                LoadKhachTro();
                return;
            }

            dgvKhachTro.DataSource = khachTroBUL.TraCuuKhachTro(hoTen, cccd, maPT);
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTraCuuCCCD.Text = "";
            txtTraCuuHoTen.Text = "";
            txtTraCuuMaPT.Text = "";
            LoadKhachTro();
        }
    }
}
