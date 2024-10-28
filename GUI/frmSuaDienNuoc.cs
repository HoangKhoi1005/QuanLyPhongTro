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
    public partial class frmSuaDienNuoc : Form
    {
        private ChiSoDienNuocDTO chiSoDienNuocDTO;
        ChiSoDienNuocBUL chiSoDienNuocBUL = new ChiSoDienNuocBUL();
        public bool kiemTraThanhCong;
        public frmSuaDienNuoc(ChiSoDienNuocDTO dienNuocDangChon)
        {
            InitializeComponent();
            

            chiSoDienNuocDTO = dienNuocDangChon;
            txtMaCS.Text = chiSoDienNuocDTO.MaCS.ToString();
            cboMaPT.SelectedValue = chiSoDienNuocDTO.MaPT;
            dtpNgayThang.Value = chiSoDienNuocDTO.NgayThang;
            txtChiSoDien.Text = chiSoDienNuocDTO.ChiSoDien.ToString();
            txtChiSoNuoc.Text = chiSoDienNuocDTO.ChiSoNuoc.ToString();

            loadMaPT();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void loadMaPT()
        {
            cboMaPT.DataSource = chiSoDienNuocBUL.loadMaPT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtChiSoNuoc.Text == string.Empty || txtChiSoDien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (txtChiSoDien.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Chỉ số điện phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtChiSoNuoc.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Chỉ số nước phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChiSoDienNuocDTO chiSoDienNuocDTO = new ChiSoDienNuocDTO();
            chiSoDienNuocDTO.MaCS = int.Parse(txtMaCS.Text);
            chiSoDienNuocDTO.MaPT = cboMaPT.SelectedValue.ToString();
            chiSoDienNuocDTO.NgayThang = dtpNgayThang.Value;
            chiSoDienNuocDTO.ChiSoDien = int.Parse(txtChiSoDien.Text);
            chiSoDienNuocDTO.ChiSoNuoc = int.Parse(txtChiSoNuoc.Text);

            if (chiSoDienNuocBUL.suaDienNuoc(chiSoDienNuocDTO))
            {
                MessageBox.Show("Sửa chỉ số điện nước thành công");
                kiemTraThanhCong = true;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Sửa chỉ số điện nước thất bại");
                kiemTraThanhCong = false;
                return;
            }
        }
    }
}
