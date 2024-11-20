using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhachTro : Form
    {
        private KhachTroDTO khachTro;
        private KhachTroBUL khachTroBUL = new KhachTroBUL();
        string tenAnh = "";
        public frmKhachTro()
        {
            InitializeComponent();
        }

        public void loadKhachTro()
        {
            dgvKhachTro.DataSource = khachTroBUL.LayDanhSachKhachTro();
            dgvKhachTro.Columns["DAXOA"].Visible = false;
            dgvKhachTro.Columns["ANH"].Visible = false;
        }

        private void frmKhachTro_Load(object sender, EventArgs e)
        {
            loadKhachTro();
            dataBinding();
            ptbKhachTro.Enabled = false;
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
            ptbKhachTro.DataBindings.Add("Image", dgvKhachTro.DataSource, "ANH", true, DataSourceUpdateMode.Never);
            ptbKhachTro.DataBindings[0].Format += (s, e) =>
            {
                if (e.DesiredType == typeof(Image) && e.Value != DBNull.Value)
                {
                    string imagePath = e.Value.ToString();
                    if (File.Exists(imagePath))
                    {
                        e.Value = Image.FromFile(imagePath);
                    }
                    else
                    {
                        e.Value = null; 
                    }
                }
            };
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

        private void btnThemKhachTro_Click(object sender, EventArgs e)
        {
            txtMaKT.Clear();
            txtMaKT.Enabled = true;
            txtTenKT.Clear();
            txtCCCD.Clear();
            txtSoDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtMoTa.Clear();
            ptbKhachTro.Enabled = true;
            if (ptbKhachTro.Image != null)
            {
                ptbKhachTro.Image.Dispose();
                ptbKhachTro.Image = null;
            }
            txtMaKT.Text = khachTroBUL.PhatSinhMaKhachTro();
        }

        private void btnLuuKhachTro_Click(object sender, EventArgs e)
        {
            //them
            if(txtMaKT.Enabled == true)
            {
                if (KiemTraThongTinNhap())
                {
                    KhachTroDTO khachTroDTO = new KhachTroDTO();
                    khachTroDTO.MaKT = txtMaKT.Text;
                    khachTroDTO.HoTen = txtTenKT.Text;
                    khachTroDTO.DiaChi = txtDiaChi.Text;
                    khachTroDTO.SoDT = txtSoDT.Text;
                    khachTroDTO.CCCD = txtCCCD.Text;
                    khachTroDTO.Email = txtEmail.Text;
                    khachTroDTO.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString());
                    if (rdbNam.Checked)
                        khachTroDTO.GioiTinh = rdbNam.Text;
                    if (rdbNu.Checked)
                        khachTroDTO.GioiTinh = rdbNu.Text;
                    khachTroDTO.SoDT = txtSoDT.Text;
                    if (File.Exists(khachTroDTO.Anh))
                    {
                        ptbKhachTro.Image = Image.FromFile(khachTroDTO.Anh);
                        tenAnh = khachTroDTO.Anh;
                    }
                    else
                    {
                        ptbKhachTro.Image = Properties.Resources.z5952240387613_efbdaf629b9afa1f2040590b686dca10;
                    }

                    khachTroDTO.Anh = tenAnh;
                    khachTroDTO.MoTa = txtMoTa.Text;
                    khachTroDTO.DaXoa = 0;

                    if (khachTroBUL.ThemKhachTro(khachTroDTO))
                    {
                        MessageBox.Show("Thêm khách trọ thành công");
                        loadKhachTro();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách trọ thất bại");
                        return;
                    }
                }
                else
                    return;

            } 
            else
            {
                KhachTroDTO khachTroDTO = new KhachTroDTO();
                khachTroDTO.MaKT = txtMaKT.Text;
                khachTroDTO.HoTen = txtTenKT.Text;
                khachTroDTO.DiaChi = txtDiaChi.Text;
                khachTroDTO.SoDT = txtSoDT.Text;
                khachTroDTO.CCCD = txtCCCD.Text;
                khachTroDTO.Email = txtEmail.Text;
                khachTroDTO.NgaySinh = dtpNgaySinh.Value;
                if (rdbNam.Checked)
                {
                    khachTroDTO.GioiTinh = "Nam";
                }
                else
                {
                    khachTroDTO.GioiTinh = "Nữ";
                }
                khachTroDTO.MoTa = txtMoTa.Text;
                khachTroDTO.Anh = tenAnh;

                if (khachTroBUL.SuaKhachTro(khachTroDTO))
                {
                    MessageBox.Show("Cập nhật thông tin khách trọ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadKhachTro();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách trọ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void ptbKhachTro_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbKhachTro.Image = Image.FromFile(open.FileName);
                tenAnh = open.FileName;
            }
        }

        private void btnSuaKhachTro_Click(object sender, EventArgs e)
        {
            txtMaKT.Enabled = false;
            ptbKhachTro.Enabled = true;
        }

        private void btnXoaKhachTro_Click(object sender, EventArgs e)
        {
            KhachTroDTO khachTroDTO = new KhachTroDTO();
            khachTroDTO.MaKT = txtMaKT.Text;
            khachTroDTO.HoTen = txtTenKT.Text;
            khachTroDTO.DiaChi = txtDiaChi.Text;
            khachTroDTO.SoDT = txtSoDT.Text;
            khachTroDTO.CCCD = txtCCCD.Text;
            khachTroDTO.Email = txtEmail.Text;
            khachTroDTO.NgaySinh = dtpNgaySinh.Value;
            if (rdbNam.Checked)
            {
                khachTroDTO.GioiTinh = "Nam";
            }
            else
            {
                khachTroDTO.GioiTinh = "Nữ";
            }
            khachTroDTO.MoTa = txtMoTa.Text;
            khachTroDTO.Anh = tenAnh;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách trọ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (khachTroBUL.XoaKhachTro(khachTroDTO.MaKT))
                {
                    MessageBox.Show("Xóa khách trọ thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            loadKhachTro();
        }
    }
}
