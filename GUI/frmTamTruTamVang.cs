using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTamTruTamVang : Form
    {
        TamTruTamVangBUL TamTruTamVangBUL = new TamTruTamVangBUL();
        KhachTroBUL KhachTroBUL = new KhachTroBUL();
        public frmTamTruTamVang()
        {
            InitializeComponent();
            LoadCboKhachTro();
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }

        public void LoadDgvTamTruTamVang()
        {
            dgvTamTruTamVang.DataSource = TamTruTamVangBUL.LayDSTamTruTamVang();
            dgvTamTruTamVang.Columns["MATTTV"].Visible = false;
            dgvTamTruTamVang.Columns["MAKT"].Visible = false;
            dgvTamTruTamVang.Columns["Anh"].Visible = false;

            foreach (DataGridViewRow row in dgvTamTruTamVang.Rows)
            {
                DateTime ngayKT = Convert.ToDateTime(row.Cells["NGAYKETTHUC"].Value);
                if (ngayKT < DateTime.Now.AddMonths(1))
                {
                    row.Cells["NGAYKETTHUC"].Style.ForeColor = Color.Red;
                }
            }

        }

        public void LoadCboLoaiTTTV()
        {
            cboLoaiTTTV.Items.Add("Tạm trú");
            cboLoaiTTTV.Items.Add("Tạm vắng");

            cboTraCuuTheoLoai.Items.Add("Tất cả");
            cboTraCuuTheoLoai.Items.Add("Tạm trú");
            cboTraCuuTheoLoai.Items.Add("Tạm vắng");
            cboTraCuuTheoLoai.SelectedIndex = 0;
        }

        private void LoadCboKhachTro()
        {
            cboKhachTro.SelectedIndexChanged -= cboKhachTro_SelectedIndexChanged;

            List<KhachTroDTO> dtKhachTro = KhachTroBUL.LayDSKhachTroDaThuePhong();
            if (dtKhachTro == null)
            {
                MessageBox.Show("Không có khách trọ nào trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhachTro.SelectedIndexChanged += cboKhachTro_SelectedIndexChanged;
                return;
            }

            cboKhachTro.DataSource = dtKhachTro;
            cboKhachTro.DisplayMember = "HOTEN";
            cboKhachTro.ValueMember = "MAKT";

            cboKhachTro.SelectedIndexChanged += cboKhachTro_SelectedIndexChanged;
        }


        private void frmTamTruTamVang_Load(object sender, EventArgs e)
        {
            LoadDgvTamTruTamVang();
            LoadCboLoaiTTTV();
            LoadCboKhachTro();
        }

        public void Databinding()
        {
            cboKhachTro.DataBindings.Clear();
            cboKhachTro.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "HOTEN");

            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "MAPT");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "GIOITINH");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "NGAYSINH");
            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "SODT");
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "CCCD");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "DIACHI");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "EMAIL");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "MOTA");

            cboLoaiTTTV.DataBindings.Clear();
            cboLoaiTTTV.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "LOAITTV");

            dtpNgayBD.DataBindings.Clear();
            dtpNgayBD.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "NGAYBATDAU");

            dtpNgayKT.DataBindings.Clear();
            dtpNgayKT.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "NGAYKETTHUC");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgvTamTruTamVang.DataSource, "MOTA");

            string imagePath = dgvTamTruTamVang.Rows[dgvTamTruTamVang.CurrentCell.RowIndex].Cells["Anh"].Value?.ToString();

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                ptbAnh.Image = Image.FromFile(imagePath);
            }
            else
            {
                ptbAnh.Image = null;
            }
        }

        private void dgvTamTruTamVang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Databinding();
        }

        private void cboKhachTro_SelectedIndexChanged(object sender, EventArgs e)
        {

            string maKT = cboKhachTro.SelectedValue.ToString();
            DataRow dr = KhachTroBUL.LayKhachTroTheoMaKT(maKT);

            if (dr == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách trọ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMaPT.Text = dr["MAPT"].ToString();
            txtGioiTinh.Text = dr["GIOITINH"].ToString();
            txtNgaySinh.Text = dr["NGAYSINH"].ToString();
            txtSoDT.Text = dr["SODT"].ToString();
            txtCCCD.Text = dr["CCCD"].ToString();
            txtDiaChi.Text = dr["DIACHI"].ToString();
            txtEmail.Text = dr["EMAIL"].ToString();

            string imagePath = dr["Anh"].ToString();
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
            string maKT = cboKhachTro.SelectedValue.ToString();
            if (TamTruTamVangBUL.KiemTraKhachTroDaCoTTTV(maKT, dtpNgayBD.Value, dtpNgayKT.Value))
            {
                MessageBox.Show("Khách trọ đã có thông tin tạm trú/tạm vắng trong thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMaPT.Text))
            {
                MessageBox.Show("Vui lòng chọn khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cboLoaiTTTV.Text))
            {
                MessageBox.Show("Vui lòng chọn loại tạm trú/tạm vắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayBD.Value > dtpNgayKT.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TamTruTamVangDTO tamTruTamVangDTO = new TamTruTamVangDTO();
            tamTruTamVangDTO.MaKT = cboKhachTro.SelectedValue.ToString();
            tamTruTamVangDTO.LoaiTTTV = cboLoaiTTTV.Text;
            tamTruTamVangDTO.NgayBatDau = dtpNgayBD.Value;
            tamTruTamVangDTO.NgayKetThuc = dtpNgayKT.Value;
            tamTruTamVangDTO.MoTa = txtMoTa.Text;

            if (TamTruTamVangBUL.ThemTamTruTamVang(tamTruTamVangDTO))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvTamTruTamVang();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPT.Text))
            {
                MessageBox.Show("Vui lòng chọn khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cboLoaiTTTV.Text))
            {
                MessageBox.Show("Vui lòng chọn loại tạm trú/tạm vắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayBD.Value > dtpNgayKT.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TamTruTamVangDTO tamTruTamVangDTO = new TamTruTamVangDTO();
            tamTruTamVangDTO.MaTTTV = dgvTamTruTamVang.Rows[dgvTamTruTamVang.CurrentCell.RowIndex].Cells["MATTTV"].Value.ToString();
            tamTruTamVangDTO.MaKT = dgvTamTruTamVang.Rows[dgvTamTruTamVang.CurrentCell.RowIndex].Cells["MAKT"].Value.ToString();
            tamTruTamVangDTO.LoaiTTTV = cboLoaiTTTV.Text;
            tamTruTamVangDTO.NgayBatDau = dtpNgayBD.Value;
            tamTruTamVangDTO.NgayKetThuc = dtpNgayKT.Value;
            tamTruTamVangDTO.MoTa = txtMoTa.Text;

            if (TamTruTamVangBUL.SuaTamTruTamVang(tamTruTamVangDTO))
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvTamTruTamVang();
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtTraCuuHoTen.Text.Trim();
            string cccd = txtTraCuuCCCD.Text.Trim();
            string maPT = txtTraCuuMaPT.Text.Trim();
            string loaiTTTV = cboTraCuuTheoLoai.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(hoTen) && string.IsNullOrEmpty(cccd) && string.IsNullOrEmpty(maPT) && loaiTTTV == "Tất cả")
            {
                LoadDgvTamTruTamVang();
                return;
            }

            DataTable dt = TamTruTamVangBUL.TraCuuTamTruTamVang(hoTen, cccd, maPT, loaiTTTV);

            if (dt.Rows.Count > 0)
            {
                dgvTamTruTamVang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTamTruTamVang.DataSource = null;
            }
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTraCuuCCCD.Text = "";
            txtTraCuuHoTen.Text = "";
            txtTraCuuMaPT.Text = "";
            cboTraCuuTheoLoai.SelectedIndex = 0;
            LoadDgvTamTruTamVang();
        }
    }
}
