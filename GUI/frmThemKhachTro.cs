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
    public partial class frmThemKhachTro : MetroFramework.Forms.MetroForm
    {
        private PhongDTO phong;
        KhachTroBUL khachTroBUL = new KhachTroBUL();
        KhachTroDTO khachTro = new KhachTroDTO();
        PhongBUL PhongBUL = new PhongBUL();
        HopDongBUL hopDongBUL = new HopDongBUL();
        string tenAnh = "";
        public bool kiemTraThanhCong = false;

        public frmThemKhachTro(PhongDTO phong)
        {
            InitializeComponent();
            this.phong = phong;

            if (PhongBUL.KiemTraPhongDaCoHopDong(phong.MaPT))
            {
                btnDatPhong.Visible = false;
                btnLapHopDon.Visible = false;

                btnThemKhachTro_HopDong.Visible = true;
            }    
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

        public void LoadKhachTro()
        {
            List<KhachTroDTO> danhSachKhach = khachTroBUL.LayDSKhachTroChuaThuePhong();
            dgvKhachTro.DataSource = danhSachKhach;

            dgvKhachTro.Columns["Anh"].Visible = false;
            dgvKhachTro.Columns["MoTa"].Visible = false;
            dgvKhachTro.Columns["DaXoa"].Visible = false;
        }

        private void frmThemKhachTro_Load(object sender, EventArgs e)
        {
            LoadKhachTro();
            lblTieuDe.Text = "THÊM KHÁCH TRỌ VÀO PHÒNG " + phong.MaPT;
            txtMaKT.Text = khachTroBUL.PhatSinhMaKhachTro();
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

        public void dataBinding()
        {
            txtMaKT.DataBindings.Clear();
            txtMaKT.DataBindings.Add("Text", dgvKhachTro.DataSource, "MaKT");
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
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgvKhachTro.DataSource, "MOTA");
        }

        private void dgvKhachTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataBinding();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadKhachTro();
            txtTraCuu.Text = "";
            txtMaKT.Text = "";
            txtTenKT.Text = "";
            txtCCCD.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtMoTa.Text = "";
            ptbKhachTro.Image = null;
            txtMaKT.Text = khachTroBUL.PhatSinhMaKhachTro();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbKhachTro.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
            }
        }

        public bool KiemTraThongTinNhap()
        {
            if (txtTenKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số CCCD của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSoDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSoDT.Text.Length != 10 || !txtSoDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rdbNam.Checked == false && rdbNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính của khách trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CapNhatThongTinKhachTro()
        {
            khachTro.MaKT = txtMaKT.Text;
            khachTro.HoTen = txtTenKT.Text;
            khachTro.CCCD = txtCCCD.Text;
            khachTro.SoDT = txtSoDT.Text;
            khachTro.DiaChi = txtDiaChi.Text;
            khachTro.Email = txtEmail.Text;
            khachTro.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            khachTro.NgaySinh = dtpNgaySinh.Value;
            khachTro.MoTa = txtMoTa.Text;
            khachTro.Anh = tenAnh;
            khachTro.DaXoa = 0;
        }

        private void btnLapHopDon_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                CapNhatThongTinKhachTro();
                ShowOverlay();
                frmLapHopDong frm = new frmLapHopDong(phong, khachTro, this);
                frm.ShowDialog();
                HideOverlay();
            }
            else
                return;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                CapNhatThongTinKhachTro();
                ShowOverlay();
                frmDatPhong frm = new frmDatPhong(phong, khachTro, this);
                frm.ShowDialog();
                HideOverlay();
            }
            else
                return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát mọi thao tác sẽ không được lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void btnThemKhachTro_HopDong_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                CapNhatThongTinKhachTro();
                if (!khachTroBUL.KiemTraKhachTroTonTai(khachTro.MaKT))
                {
                    khachTroBUL.ThemKhachTro(khachTro);
                }

                KhachTroHopDongDTO khachTroHopDong = new KhachTroHopDongDTO();
                khachTroHopDong.MaKT = khachTro.MaKT;
                khachTroHopDong.MaHopDong = hopDongBUL.TimMaHopDongTheoMaPhong(phong.MaPT);

                if (hopDongBUL.ThemKhachTroHopDong(khachTroHopDong))
                {
                    MessageBox.Show("Thêm khách trọ vào hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kiemTraThanhCong = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách trọ vào hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;
        }
    }
}
