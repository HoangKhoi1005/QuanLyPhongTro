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
    public partial class frmXoaDienNuoc : Form
    {
        private ChiSoDienNuocDTO chiSoDienNuocDTO;
        ChiSoDienNuocBUL chiSoDienNuocBUL = new ChiSoDienNuocBUL();
        public bool kiemTraThanhCong;
        public frmXoaDienNuoc(ChiSoDienNuocDTO dienNuocDangChon)
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

        private void loadMaPT()
        {
            cboMaPT.DataSource = chiSoDienNuocBUL.loadMaPT();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiSoDienNuocDTO chiSoDienNuocDTO = new ChiSoDienNuocDTO();
            chiSoDienNuocDTO.MaCS = int.Parse(txtMaCS.Text);
            chiSoDienNuocDTO.MaPT = cboMaPT.SelectedValue.ToString();
            chiSoDienNuocDTO.NgayThang = dtpNgayThang.Value;
            chiSoDienNuocDTO.ChiSoDien = int.Parse(txtChiSoDien.Text);
            chiSoDienNuocDTO.ChiSoNuoc = int.Parse(txtChiSoNuoc.Text);

            if (chiSoDienNuocBUL.xoaDienNuoc(chiSoDienNuocDTO))
            {
                MessageBox.Show("Xóa chỉ số điện nước thành công");
                kiemTraThanhCong = true;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Xóa chỉ số điện nước thất bại");
                kiemTraThanhCong = false;
                return;
            }
        }
    }
}
