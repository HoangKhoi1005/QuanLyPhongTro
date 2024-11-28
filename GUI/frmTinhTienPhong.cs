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
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GUI
{
    public partial class frmTinhTienPhong : Form
    {
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        HoaDonBUL hoaDonBUL = new HoaDonBUL();

        public frmTinhTienPhong()
        {
            InitializeComponent();
            LoadCboNhaTro();
            LoadDataGirdViewHoaDon();
            LoadCboTrangThaiThanhToan();

            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.Value = DateTime.Now;

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

        private void LoadCboNhaTro()
        {
            var danhSachNhaTro = nhaTroBUL.LayDanhSachNhaTro();

            var tatCaNhaTro = new NhaTroDTO
            {
                MaNT = "All",
                TenNT = "Tất cả các nhà"
            };

            danhSachNhaTro.Insert(0, tatCaNhaTro);

            cboNT.DataSource = danhSachNhaTro;
            cboNT.DisplayMember = "TenNT";
            cboNT.ValueMember = "MaNT";
        }

        private void LoadCboTrangThaiThanhToan()
        {
            List<string> trangThaiThanhToan = new List<string>
            {
                "Tất cả",
                "Đã thanh toán",
                "Chưa thanh toán"
            };

            cboTrangThaiThanhToan.DataSource = trangThaiThanhToan;
        }

        private void btnThemNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmTinhTien frmTinhTien = new frmTinhTien(this);
            frmTinhTien.ShowDialog();
            HideOverlay();
        }

        public void LoadDataGirdViewHoaDon()
        {
            dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDon();

            dgvHoaDon.Columns["DaXoa"].Visible = false;

            dgvHoaDon.Columns["TONGTIEN"].DefaultCellStyle.Format = "C0";
            dgvHoaDon.Columns["TIENDATHANHTOAN"].DefaultCellStyle.Format = "C0";
            dgvHoaDon.Columns["TONGTIEN"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            dgvHoaDon.Columns["TIENDATHANHTOAN"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");

            if (!dgvHoaDon.Columns.Contains("CONGNO"))
            {
                DataGridViewTextBoxColumn congNoColumn = new DataGridViewTextBoxColumn
                {
                    Name = "CONGNO",
                    HeaderText = "Công Nợ",
                    DefaultCellStyle = { Format = "C0", FormatProvider = new CultureInfo("vi-VN") }
                };
                dgvHoaDon.Columns.Add(congNoColumn);
            }

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                decimal tongTien = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                decimal tienDaThanhToan = Convert.ToDecimal(row.Cells["TIENDATHANHTOAN"].Value);
                decimal congNo = tongTien - tienDaThanhToan;

                row.Cells["TIENDATHANHTOAN"].Style.ForeColor = Color.FromArgb(38, 185, 154);

                row.Cells["CONGNO"].Value = congNo.ToString("C0", new CultureInfo("vi-VN"));
                if (congNo > 0)
                {
                    row.Cells["CONGNO"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void frmTinhTienPhong_Load(object sender, EventArgs e)
        {
            LoadDataGirdViewHoaDon();
        }

        private void dtpThangNam_ValueChanged(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(dtpThangNam.Value, cboTrangThaiThanhToan.SelectedValue.ToString());

            dgvHoaDon.Columns["DaXoa"].Visible = false;
            dgvHoaDon.Columns["TONGTIEN"].DefaultCellStyle.Format = "C0";
            dgvHoaDon.Columns["TIENDATHANHTOAN"].DefaultCellStyle.Format = "C0";
            dgvHoaDon.Columns["TONGTIEN"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            dgvHoaDon.Columns["TIENDATHANHTOAN"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");

            if (!dgvHoaDon.Columns.Contains("CONGNO"))
            {
                DataGridViewTextBoxColumn congNoColumn = new DataGridViewTextBoxColumn
                {
                    Name = "CONGNO",
                    HeaderText = "Công Nợ",
                    DefaultCellStyle = { Format = "C0", FormatProvider = new CultureInfo("vi-VN") }
                };
                dgvHoaDon.Columns.Add(congNoColumn);
            }

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                decimal tongTien = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                decimal tienDaThanhToan = Convert.ToDecimal(row.Cells["TIENDATHANHTOAN"].Value);
                decimal congNo = tongTien - tienDaThanhToan;

                row.Cells["TIENDATHANHTOAN"].Style.ForeColor = Color.FromArgb(38, 185, 154);

                row.Cells["CONGNO"].Value = congNo.ToString("C0", new CultureInfo("vi-VN"));
                if (congNo > 0)
                {
                    row.Cells["CONGNO"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string maPT = txtTraCuuMaPhong.Text;
            
            if (!string.IsNullOrEmpty(maPT))
            {
                dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoMaPhongVaThang(maPT, dtpThangNam.Value, cboTrangThaiThanhToan.SelectedValue.ToString());
            }
            else if (cboNT.SelectedValue.ToString() == "All")
            {
                dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(dtpThangNam.Value, cboTrangThaiThanhToan.SelectedValue.ToString());
            }
            else
            {
                dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThangVaNT(dtpThangNam.Value, cboNT.SelectedValue.ToString(), cboTrangThaiThanhToan.SelectedValue.ToString());
            }

            dgvHoaDon.Columns["DaXoa"].Visible = false;
            dgvHoaDon.Columns["TONGTIEN"].DefaultCellStyle.Format = "C0";
            dgvHoaDon.Columns["TIENDATHANHTOAN"].DefaultCellStyle.Format = "C0";
            dgvHoaDon.Columns["TONGTIEN"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            dgvHoaDon.Columns["TIENDATHANHTOAN"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");

            if (!dgvHoaDon.Columns.Contains("CONGNO"))
            {
                DataGridViewTextBoxColumn congNoColumn = new DataGridViewTextBoxColumn
                {
                    Name = "CONGNO",
                    HeaderText = "Công Nợ",
                    DefaultCellStyle = { Format = "C0", FormatProvider = new CultureInfo("vi-VN") }
                };
                dgvHoaDon.Columns.Add(congNoColumn);
            }

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                decimal tongTien = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                decimal tienDaThanhToan = Convert.ToDecimal(row.Cells["TIENDATHANHTOAN"].Value);
                decimal congNo = tongTien - tienDaThanhToan;

                row.Cells["TIENDATHANHTOAN"].Style.ForeColor = Color.FromArgb(38, 185, 154);

                row.Cells["CONGNO"].Value = congNo.ToString("C0", new CultureInfo("vi-VN"));
                if (congNo > 0)
                {
                    row.Cells["CONGNO"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            cboNT.SelectedIndex = 0;
            cboTrangThaiThanhToan.SelectedIndex = 0;
            dtpThangNam.Value = DateTime.Now;
            txtTraCuuMaPhong.Text = "";
            LoadDataGirdViewHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHD = dgvHoaDon.SelectedRows[0].Cells["MAHD"].Value.ToString();
            string maPT = dgvHoaDon.SelectedRows[0].Cells["MAPT"].Value.ToString();
            decimal tongTien = Convert.ToDecimal(dgvHoaDon.SelectedRows[0].Cells["TONGTIEN"].Value);
            decimal tienDaThanhToan = Convert.ToDecimal(dgvHoaDon.SelectedRows[0].Cells["TIENDATHANHTOAN"].Value);
            decimal congNo = tongTien - tienDaThanhToan;

            if (congNo <= 0)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán hoặc không còn nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowOverlay();
            frmThanhToan frmThanhToan = new frmThanhToan(maHD, maPT, tongTien, tienDaThanhToan, congNo, this);
            frmThanhToan.ShowDialog();
            HideOverlay();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHD = dgvHoaDon.SelectedRows[0].Cells["MAHD"].Value.ToString();
            DateTime ngayLapHoaDon = Convert.ToDateTime(dgvHoaDon.SelectedRows[0].Cells["NGAYLAP"].Value);
            string maPT = "'" + dgvHoaDon.SelectedRows[0].Cells["MAPT"].Value.ToString() + "'";


            crpInHoaDon crpInHoaDon = new crpInHoaDon();
            crpInHoaDon.SetDataSource(hoaDonBUL.LayHoaDonTheoMaHD(maHD));

            crpInHoaDon.SetParameterValue("MaPT", maPT);
            crpInHoaDon.SetParameterValue("NgayLap", ngayLapHoaDon);

            frmInHoaDon frmInHoaDon = new frmInHoaDon();
            frmInHoaDon.crystalReportViewer1.ReportSource = crpInHoaDon;
            frmInHoaDon.crystalReportViewer1.Refresh();

            frmInHoaDon.ShowDialog();


        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SetDatabaseLogon(ReportDocument reportDocument)
        {
            string server = "LAPTOP-GQAMABND";
            string database = "QL_NhaTro";
            string user = "sa";
            string password = "123";

            foreach (Table table in reportDocument.Database.Tables)
            {
                TableLogOnInfo logOnInfo = table.LogOnInfo;
                logOnInfo.ConnectionInfo.ServerName = server;
                logOnInfo.ConnectionInfo.DatabaseName = database;
                logOnInfo.ConnectionInfo.UserID = user;
                logOnInfo.ConnectionInfo.Password = password;
                table.ApplyLogOnInfo(logOnInfo);
            }
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHD = dgvHoaDon.SelectedRows[0].Cells["MAHD"].Value.ToString();
            DateTime ngayLapHoaDon = Convert.ToDateTime(dgvHoaDon.SelectedRows[0].Cells["NGAYLAP"].Value);
            string maPT = "'" + dgvHoaDon.SelectedRows[0].Cells["MAPT"].Value.ToString() + "'";


            crpInHoaDon crpInHoaDon = new crpInHoaDon();
            crpInHoaDon.SetDataSource(hoaDonBUL.LayHoaDonTheoMaHD(maHD));
            SetDatabaseLogon(crpInHoaDon);

            crpInHoaDon.SetParameterValue("MaPT", maPT);
            crpInHoaDon.SetParameterValue("NgayLap", ngayLapHoaDon);

            frmInHoaDon frmInHoaDon = new frmInHoaDon();
            frmInHoaDon.crystalReportViewer1.ReportSource = crpInHoaDon;
            frmInHoaDon.crystalReportViewer1.Refresh();
            //nằm giữ và full màn hình
            frmInHoaDon.WindowState = FormWindowState.Maximized;
            frmInHoaDon.ShowDialog();
        }
    }
}
