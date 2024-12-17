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
    public partial class UCDichVu : UserControl
    {
        private PhongDTO phong;
        SuDungDichVuBUL suDungDichVuBUL = new SuDungDichVuBUL();

        public UCDichVu(PhongDTO phong)
        {
            InitializeComponent();
            this.phong = phong;
            dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(phong.MaPT);
            //định dạng cột DONGIA theo tiền Việt Nam không có dollar
            dgvSDDV.Columns[2].DefaultCellStyle.Format = "N0";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemSDDV frmThemSDDV = new frmThemSDDV(phong, this);
            frmThemSDDV.ShowDialog();
            dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(phong.MaPT);
            HideOverlay();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            if(dgvSDDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HideOverlay();
                return;
            }
            else
            {
                SuDungDichVuDTO suDungDichVu = new SuDungDichVuDTO();
                suDungDichVu.MaPT = phong.MaPT;
                suDungDichVu.MaDV = dgvSDDV.CurrentRow.Cells[0].Value.ToString();
                suDungDichVu.SoLuong = int.Parse(dgvSDDV.CurrentRow.Cells[3].Value.ToString());
                suDungDichVu.NgayBatDau = DateTime.Parse(dgvSDDV.CurrentRow.Cells[4].Value.ToString());
                suDungDichVu.NgayKetThuc = DateTime.Parse(dgvSDDV.CurrentRow.Cells[5].Value.ToString());
                

                frmSuaSDDV frmSuaDichVu = new frmSuaSDDV(suDungDichVu, this);
                frmSuaDichVu.ShowDialog();
                dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(phong.MaPT);
                HideOverlay();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            if (dgvSDDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HideOverlay();
                return;
            }
            else
            {
                SuDungDichVuDTO suDungDichVu = new SuDungDichVuDTO();
                suDungDichVu.MaPT = phong.MaPT;
                suDungDichVu.MaDV = dgvSDDV.CurrentRow.Cells[0].Value.ToString();
                suDungDichVu.SoLuong = int.Parse(dgvSDDV.CurrentRow.Cells[3].Value.ToString());
                suDungDichVu.NgayBatDau = DateTime.Parse(dgvSDDV.CurrentRow.Cells[4].Value.ToString());
                suDungDichVu.NgayKetThuc = DateTime.Parse(dgvSDDV.CurrentRow.Cells[5].Value.ToString());


                frmXoaSDDV frmXoaSDDV = new frmXoaSDDV(suDungDichVu, this);
                frmXoaSDDV.ShowDialog();
                dgvSDDV.DataSource = suDungDichVuBUL.LayDSSuDungDVDataGirdView(phong.MaPT);
                HideOverlay();
            }
        }
    }
}
