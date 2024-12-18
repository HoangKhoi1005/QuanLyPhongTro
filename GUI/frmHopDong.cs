using BUL;
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
    public partial class frmHopDong : Form
    {
        HopDongBUL hopDongBUL = new HopDongBUL();

        public frmHopDong()
        {
            InitializeComponent();
            LoadData();
            dgvHopDong.Columns[6].DefaultCellStyle.Format = "N0";
        }

        public void LoadData()
        {
            dgvHopDong.DataSource = hopDongBUL.LayDSHopDongDataGirdView();
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

        private void frmHopDong_Load(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string maPhong = txtTraCuuMaPhong.Text;
            string maKhachTro = txtTraCuuTenKhach.Text;

            dgvHopDong.DataSource = hopDongBUL.TraCuuHopDong(maPhong, maKhachTro);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            //frmLapHopDong frmThemHopDong = new frmLapHopDong();
            //frmThemHopDong.ShowDialog();
            HideOverlay();
            LoadData();
        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvHopDong.CurrentRow != null)
            {
                string maHopDong = dgvHopDong.CurrentRow.Cells["MaHopDong"].Value.ToString();

                Dictionary<string, string> contractDict = hopDongBUL.GetContractDictionary(maHopDong);

                string templatePath = @"D:\Nam4KyI\PhatTrienPMUDTM\HopDong.docx";
                WordExport wordExport = new WordExport(Application.StartupPath + "\\HopDong.docx", true);

                wordExport.WriteFields(contractDict);

                MessageBox.Show("Xuất hợp đồng thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để xuất.");
            }
        }
    }
}
