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
            dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThang(dtpThangNam.Value);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cboNT.SelectedValue.ToString() == "All")
            {
                LoadDataGirdViewHoaDon();
            }
            else
            {
                dgvHoaDon.DataSource = hoaDonBUL.LayDanhSachHoaDonTheoThangVaNT(dtpThangNam.Value, cboNT.SelectedValue.ToString());

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

                    row.Cells["CONGNO"].Value = congNo.ToString("C0", new CultureInfo("vi-VN"));
                }

            }
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            cboNT.SelectedIndex = 0;
            dtpThangNam.Value = DateTime.Now;
            LoadDataGirdViewHoaDon();
        }
    }
}
