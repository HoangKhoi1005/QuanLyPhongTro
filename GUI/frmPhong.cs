using BUL;
using DTO;
using Syncfusion.XlsIO;
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
    public partial class frmPhong : Form
    {
        NhaTroBUL nhaTroBUL = new NhaTroBUL();
        PhongBUL phongBUL = new PhongBUL();
        TrangThaiPhongBUL trangThaiPhongBUL = new TrangThaiPhongBUL();
        private NhaTroDTO nhaTroDangChon;

        public frmPhong()
        {
            InitializeComponent();
            LoadNhaTro();
            LoadTrangThai();
            LoadCboGia();

            dtpNgayChonPhong.ValueChanged -= dtpNgayChonPhong_ValueChanged;

            dtpNgayChonPhong.Value = DateTime.Now;

            dtpNgayChonPhong.ValueChanged += dtpNgayChonPhong_ValueChanged;

            lblSoPhongTrong.Text = lblSoPhongTrong.Text + " " + phongBUL.DemSoPhongTrongTheoNha(nhaTroDangChon.MaNT).ToString();
            lblSoPhongDaThue.Text = lblSoPhongDaThue.Text + " " + phongBUL.DemSoPhongDaThueTheoNha(nhaTroDangChon.MaNT).ToString();
            lblSoPhongDaDat.Text = lblSoPhongDaDat.Text + " " + phongBUL.DemSoPhongDaDatTheoNha(nhaTroDangChon.MaNT).ToString();
        }
        internal List<string> dsTenTaiSan = new List<string>();

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

        public void LoadNhaTro()
        {
            panelDSNha.Controls.Clear();

            List<NhaTroDTO> lstNhaTro = nhaTroBUL.LayDanhSachNhaTro();

            int buttonWidth = 155;
            int buttonHeight = 54;
            int buttonSpacing = 10;
            int xPosition = 0;
            bool isFirstButton = true;

            foreach (var nhaTro in lstNhaTro)
            {
                Guna.UI2.WinForms.Guna2Button btnNhaTro = new Guna.UI2.WinForms.Guna2Button();
                btnNhaTro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                btnNhaTro.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnNhaTro.CheckedState.FillColor = System.Drawing.Color.White;
                btnNhaTro.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
                btnNhaTro.FillColor = System.Drawing.Color.White;
                btnNhaTro.Font = new System.Drawing.Font("Segoe UI", 9F);
                btnNhaTro.ForeColor = System.Drawing.Color.Black;
                btnNhaTro.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btnNhaTro.HoverState.FillColor = System.Drawing.Color.White;
                btnNhaTro.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                btnNhaTro.Location = new System.Drawing.Point(xPosition, 0);
                btnNhaTro.Text = nhaTro.TenNT;
                btnNhaTro.Tag = nhaTro;

                if (isFirstButton)
                {
                    btnNhaTro.Checked = true;
                    string diaChi = nhaTroBUL.LayDiaChiNTTheoMaNT(nhaTro.MaNT);
                    groupMain.Text = "Danh sách phòng trọ tại " + diaChi;
                    nhaTroDangChon = (NhaTroDTO)btnNhaTro.Tag;
                    LoadPhongByNhaTro(nhaTro.MaNT);
                    isFirstButton = false;
                }

                panelDSNha.Controls.Add(btnNhaTro);
                btnNhaTro.Click += BtnNhaTro_Click;

                xPosition += buttonWidth + buttonSpacing;
            }
        }

        private void BtnNhaTro_Click(object sender, EventArgs e)

        {
            Guna.UI2.WinForms.Guna2Button btnNhaTro = (Guna.UI2.WinForms.Guna2Button)sender;
            nhaTroDangChon = (NhaTroDTO)btnNhaTro.Tag;
            string maNT = nhaTroDangChon.MaNT;
            string diaChi = nhaTroBUL.LayDiaChiNTTheoMaNT(maNT);
            groupMain.Text = "Danh sách phòng trọ tại " + diaChi;
            LoadPhongByNhaTro(maNT);

            lblSoPhongTrong.Text = "Còn trống" + " " + phongBUL.DemSoPhongTrongTheoNha(nhaTroDangChon.MaNT).ToString();
            lblSoPhongDaThue.Text = "| Đã cho thuê" + " " + phongBUL.DemSoPhongDaThueTheoNha(nhaTroDangChon.MaNT).ToString();
            lblSoPhongDaDat.Text = "| Đã đặt" + " " + phongBUL.DemSoPhongDaDatTheoNha(nhaTroDangChon.MaNT).ToString();
        }
    

        public void LoadPhongByNhaTro(string MaNT)
        {
            

            List<PhongDTO> lstPhong = phongBUL.LayPhongTheoNhaTro(MaNT);

            groupDSPhong1.Controls.Clear();
            int ucXPosition = 19;
            int ucYPosition = 19;
            int kt = 0;

            foreach (var phong in lstPhong)
            {
                UCPhong uCPhong = new UCPhong();
                if (kt == 6)
                {
                    ucXPosition = 19;
                    ucYPosition += 19 + uCPhong.Width;
                    kt = 0;
                }
                
                uCPhong.LoadPhongTro(phong);
                uCPhong.Left = ucXPosition;
                uCPhong.Top = ucYPosition;
                uCPhong.Tag = phong;
                uCPhong.ThemKhachTroClick += UCPhong_ThemKhachTroClick;
                uCPhong.SuaPhongClick += UCPhong_SuaPhongClick;
                uCPhong.UcClick += UCPhong_SuaPhongClick;
                uCPhong.XoaPhongClick += UCPhong_XoaPhongClick;
                uCPhong.DoiPhongClick += UCPhong_DoiPhongClick;
                uCPhong.HuyDatPhongClick += UCPhong_HuyDatPhongClick;
                uCPhong.BaoTraPhongClick += UCPhong_BaoTraPhongClick;
                uCPhong.TraPhongClick += UCPhong_TraPhongClick;
                uCPhong.HuyBaoTraPhongClick += UCPhong_HuyBaoTraPhongClick;
                uCPhong.InPhieuTraPhongClick += UCPhong_InPhieuTraPhongClick;

                ucXPosition += uCPhong.Width +19;
                kt++;
                groupDSPhong1.Controls.Add(uCPhong);

                if (kt > 100)  // Giới hạn số lượng UCPhong để tránh vượt quá giới hạn
                {
                    break;
                }
            }
        }

        private void UCPhong_InPhieuTraPhongClick(object sender, EventArgs e)
        {
            //UCPhong uCPhong = (UCPhong)sender;
            //PhongDTO phong = (PhongDTO)uCPhong.Tag;

            //string maPhong = phong.MaPT;

            //Dictionary<string, string> contractDict = phongBUL.GetContractDictionary(maPhong);
            //WordExport wordExport = new WordExport(Application.StartupPath + "\\PhieuTraPhong.docx", true);

            //wordExport.WriteFields(contractDict);

            //MessageBox.Show("Xuất phiếu đặt thành công!");
        }

        private void UCPhong_HuyBaoTraPhongClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;
            BaoTraPhongBUL baoTraPhongBUL = new BaoTraPhongBUL();
            //Hỏi xác nhận hủy báo trả phòng
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy báo trả phòng này không?", "Xác nhận hủy báo trả phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baoTraPhongBUL.HuyBaoTraPhong(phong.MaPT))
                {
                    MessageBox.Show("Hủy báo trả phòng thành công");
                    phongBUL.CapNhatTrangThaiPhong(phong.MaPT, "TT02");
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
                else
                {
                    MessageBox.Show("Hủy báo trả phòng thất bại");
                }
            }
        }

        private void UCPhong_BaoTraPhongClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;

            ShowOverlay();
            frmBaoTraPhong frmBaoTraPhong = new frmBaoTraPhong(phong, this);
            frmBaoTraPhong.FormClosed += (s, args) =>
            {
                if (frmBaoTraPhong.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmBaoTraPhong.ShowDialog();
            HideOverlay();
        }

        private void UCPhong_HuyDatPhongClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;

            ShowOverlay();
            frmHuyDatPhong frmHuyDatPhong = new frmHuyDatPhong(phong, this);
            frmHuyDatPhong.FormClosed += (s, args) =>
            {
                if (frmHuyDatPhong.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmHuyDatPhong.ShowDialog();
            HideOverlay();
        }

        private void UCPhong_DoiPhongClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;

            ShowOverlay();
            frmDoiPhong frmDoiPhong = new frmDoiPhong(phong, this);
            frmDoiPhong.FormClosed += (s, args) =>
            {
                if (frmDoiPhong.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmDoiPhong.ShowDialog();
            HideOverlay();
        }

        private void UCPhong_XoaPhongClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;

            ShowOverlay();
            frmXoaPhong frmXoaPhong = new frmXoaPhong(phong, this);
            frmXoaPhong.FormClosed += (s, args) =>
            {
                if (frmXoaPhong.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmXoaPhong.ShowDialog();
            HideOverlay();
        }

        private void UCPhong_SuaPhongClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;

            ShowOverlay();
            frmSuaPhong frmSuaPhong = new frmSuaPhong(phong, this);
            frmSuaPhong.FormClosed += (s, args) =>
            {
                if (frmSuaPhong.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmSuaPhong.ShowDialog();
            HideOverlay();
        }

        private void UCPhong_ThemKhachTroClick(object sender, EventArgs e)
        {
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;

            ShowOverlay();
            frmThemKhachTro frmThemKhachTro = new frmThemKhachTro(phong);
            
            frmThemKhachTro.FormClosed += (s, args) =>
            {
                if (frmThemKhachTro.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmThemKhachTro.ShowDialog();
            HideOverlay();
        }

        private void btnThemNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemNhaTro frmThemNhaTro = new frmThemNhaTro();
            frmThemNhaTro.FormClosed += (s, args) =>
            {
                if (frmThemNhaTro.kiemTraThanhCong)
                {
                    LoadNhaTro();
                }
            };
            frmThemNhaTro.ShowDialog();
            HideOverlay();
        }

        private void btnXoaNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmXoaNT frmXoaNT = new frmXoaNT(nhaTroDangChon);
            frmXoaNT.FormClosed += (s, args) =>
            {
                if (frmXoaNT.kiemTraThanhCong)
                {
                    LoadNhaTro();
                }
            };
            frmXoaNT.ShowDialog();
            HideOverlay();
        }

        private void btnSuaNT_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmSuaNT frmSuaNT = new frmSuaNT(nhaTroDangChon);
            frmSuaNT.FormClosed += (s, args) =>
            {
                if (frmSuaNT.kiemTraThanhCong)
                {
                    LoadNhaTro();
                }
            };
            frmSuaNT.ShowDialog();
            HideOverlay();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int soLuongNguoiO;
            bool isSoLuongValid = int.TryParse(txtTraCuuSoLuongNguoi.Text, out soLuongNguoiO);

            string maPhong = txtMaPhong.Text;
            string tenKhachTro = txtTenKhachTro.Text;

            if (string.IsNullOrEmpty(maPhong) && string.IsNullOrEmpty(tenKhachTro) && !isSoLuongValid)
            {
                LoadPhongByNhaTro(nhaTroDangChon.MaNT);
            }
            else
            {
                List<PhongDTO> lstPhong = phongBUL.TimKiemPhongTheoMaPhong(maPhong, tenKhachTro, nhaTroDangChon.MaNT, isSoLuongValid ? soLuongNguoiO : -1);

                groupDSPhong1.Controls.Clear();
                int ucXPosition = 19;
                int ucYPosition = 19;
                int kt = 0;

                foreach (var phong in lstPhong)
                {
                    UCPhong uCPhong = new UCPhong();
                    if (kt == 6)
                    {
                        ucXPosition = 19;
                        ucYPosition += 19 + uCPhong.Width;
                        kt = 0;
                    }

                    uCPhong.LoadPhongTro(phong);
                    uCPhong.Left = ucXPosition;
                    uCPhong.Top = ucYPosition;
                    uCPhong.Tag = phong;
                    uCPhong.ThemKhachTroClick += UCPhong_ThemKhachTroClick;
                    uCPhong.SuaPhongClick += UCPhong_SuaPhongClick;
                    uCPhong.UcClick += UCPhong_SuaPhongClick;
                    uCPhong.XoaPhongClick += UCPhong_XoaPhongClick;
                    uCPhong.DoiPhongClick += UCPhong_DoiPhongClick;
                    uCPhong.HuyDatPhongClick += UCPhong_HuyDatPhongClick;
                    uCPhong.BaoTraPhongClick += UCPhong_BaoTraPhongClick;
                    uCPhong.TraPhongClick += UCPhong_TraPhongClick;
                    uCPhong.InPhieuTraPhongClick += UCPhong_InPhieuTraPhongClick;

                    ucXPosition += uCPhong.Width + 19;
                    kt++;
                    groupDSPhong1.Controls.Add(uCPhong);
                }
            }
        }

        public void LoadTrangThai()
        {
            var tatCaTrangThai = trangThaiPhongBUL.LayTatCaTrangThaiPhong();

            List<TrangThaiPhongDTO> danhSachTrangThai = new List<TrangThaiPhongDTO>
            {
                new TrangThaiPhongDTO { MaTT = "all", TenTrangThai = "Tất cả trạng thái" }
            };
            danhSachTrangThai.AddRange(tatCaTrangThai);

            cboTrangThai.DataSource = danhSachTrangThai;
            cboTrangThai.DisplayMember = "TENTRANGTHAI";
            cboTrangThai.ValueMember = "MATT";


            cboTrangThai.SelectedIndex = 0;
        }

        //Lọc phòng theo trạng thái
        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.SelectedIndex == 0)
            {
                LoadPhongByNhaTro(nhaTroDangChon.MaNT);
            }
            else
            {
                string maTT = cboTrangThai.SelectedValue.ToString();
                List<PhongDTO> lstPhong = phongBUL.LayPhongTheoTrangThai(maTT, nhaTroDangChon.MaNT);

                groupDSPhong1.Controls.Clear();
                int ucXPosition = 19;
                int ucYPosition = 19;
                int kt = 0;

                foreach (var phong in lstPhong)
                {
                    UCPhong uCPhong = new UCPhong();
                    if (kt == 6)
                    {
                        ucXPosition = 19;
                        ucYPosition += 19 + uCPhong.Width;
                        kt = 0;
                    }

                    uCPhong.LoadPhongTro(phong);
                    uCPhong.Left = ucXPosition;
                    uCPhong.Top = ucYPosition;
                    uCPhong.Tag = phong;
                    uCPhong.ThemKhachTroClick += UCPhong_ThemKhachTroClick;
                    uCPhong.SuaPhongClick += UCPhong_SuaPhongClick;
                    uCPhong.UcClick += UCPhong_SuaPhongClick;
                    uCPhong.XoaPhongClick += UCPhong_XoaPhongClick;
                    uCPhong.DoiPhongClick += UCPhong_DoiPhongClick;
                    uCPhong.HuyDatPhongClick += UCPhong_HuyDatPhongClick;
                    uCPhong.BaoTraPhongClick += UCPhong_BaoTraPhongClick;
                    uCPhong.TraPhongClick += UCPhong_TraPhongClick;
                    uCPhong.InPhieuTraPhongClick += UCPhong_InPhieuTraPhongClick;

                    ucXPosition += uCPhong.Width + 19;
                    kt++;
                    groupDSPhong1.Controls.Add(uCPhong);
                }
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmThemPhong frmThemPhong = new frmThemPhong(nhaTroDangChon);
            frmThemPhong.FormClosed += (s, args) =>
            {
                if (frmThemPhong.kiemTraThanhCong)
                {
                    LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                }
            };
            frmThemPhong.ShowDialog();
            HideOverlay();
        }

        private void btnLocChiTiet_Click(object sender, EventArgs e)
        {
            ShowOverlay();
            frmLocChiTiet frmLocChiTiet = new frmLocChiTiet(this, nhaTroDangChon.MaNT, dsTenTaiSan);
            frmLocChiTiet.ShowDialog();
            PhongBUL phongBUL = new PhongBUL();
            List<PhongDTO> dsPhong = phongBUL.LocPhongTheoTaiSan(dsTenTaiSan, nhaTroDangChon.MaNT);

            groupDSPhong1.Controls.Clear();
            int ucXPosition = 19;
            int ucYPosition = 19;
            int kt = 0;

            foreach (var phong in dsPhong)
            {
                UCPhong uCPhong = new UCPhong();
                if (kt == 6)
                {
                    ucXPosition = 19;
                    ucYPosition += 19 + uCPhong.Width;
                    kt = 0;
                }

                uCPhong.LoadPhongTro(phong);
                uCPhong.Left = ucXPosition;
                uCPhong.Top = ucYPosition;
                uCPhong.Tag = phong;
                uCPhong.ThemKhachTroClick += UCPhong_ThemKhachTroClick;
                uCPhong.SuaPhongClick += UCPhong_SuaPhongClick;
                uCPhong.UcClick += UCPhong_SuaPhongClick;
                uCPhong.XoaPhongClick += UCPhong_XoaPhongClick;
                uCPhong.DoiPhongClick += UCPhong_DoiPhongClick;
                uCPhong.HuyDatPhongClick += UCPhong_HuyDatPhongClick;
                uCPhong.BaoTraPhongClick += UCPhong_BaoTraPhongClick;
                uCPhong.TraPhongClick += UCPhong_TraPhongClick;
                uCPhong.InPhieuTraPhongClick += UCPhong_InPhieuTraPhongClick;

                ucXPosition += uCPhong.Width + 19;
                kt++;
                groupDSPhong1.Controls.Add(uCPhong);

            }
            HideOverlay();
        }

        private void cboGia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboGia.SelectedIndex == 0)
            {
                LoadPhongByNhaTro(nhaTroDangChon.MaNT);
            }
            else
            {
                string gia = cboGia.SelectedItem.ToString();
                gia = gia.Replace(".", "");
                List<PhongDTO> lstPhong = phongBUL.LocPhongTheoGia(gia, nhaTroDangChon.MaNT);

                groupDSPhong1.Controls.Clear();
                int ucXPosition = 19;
                int ucYPosition = 19;
                int kt = 0;

                foreach (var phong in lstPhong)
                {
                    UCPhong uCPhong = new UCPhong();
                    if (kt == 6)
                    {
                        ucXPosition = 19;
                        ucYPosition += 19 + uCPhong.Width;
                        kt = 0;
                    }

                    uCPhong.LoadPhongTro(phong);
                    uCPhong.Left = ucXPosition;
                    uCPhong.Top = ucYPosition;
                    uCPhong.Tag = phong;
                    uCPhong.ThemKhachTroClick += UCPhong_ThemKhachTroClick;
                    uCPhong.SuaPhongClick += UCPhong_SuaPhongClick;
                    uCPhong.UcClick += UCPhong_SuaPhongClick;
                    uCPhong.XoaPhongClick += UCPhong_XoaPhongClick;
                    uCPhong.DoiPhongClick += UCPhong_DoiPhongClick;
                    uCPhong.HuyDatPhongClick += UCPhong_HuyDatPhongClick;
                    uCPhong.BaoTraPhongClick += UCPhong_BaoTraPhongClick;
                    uCPhong.TraPhongClick += UCPhong_TraPhongClick;
                    uCPhong.InPhieuTraPhongClick += UCPhong_InPhieuTraPhongClick;

                    ucXPosition += uCPhong.Width + 19;
                    kt++;
                    groupDSPhong1.Controls.Add(uCPhong);
                }
            }
        }

        public void LoadCboGia()
        {
            cboGia.Items.Add("Tất cả giá phòng");
            cboGia.Items.Add("1.000.000");
            cboGia.Items.Add("1.500.000");
            cboGia.Items.Add("2.000.000");
            cboGia.Items.Add("2.500.000");
            cboGia.Items.Add("3.000.000");
            cboGia.Items.Add("3.500.000");
            cboGia.Items.Add("4.000.000");
            cboGia.Items.Add("4.500.000");
            cboGia.Items.Add("5.000.000");
            cboGia.Items.Add("5.500.000");
            cboGia.SelectedIndex = 0;
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenKhachTro.Text = "";
            txtTraCuuSoLuongNguoi.Text = "";
            cboGia.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            dtpNgayChonPhong.Value = DateTime.Now;
            LoadPhongByNhaTro(nhaTroDangChon.MaNT);
        }

        private DateTime? KtDateTime = null;

        private void dtpNgayChonPhong_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayChon = dtpNgayChonPhong.Value;

            if (KtDateTime.HasValue && KtDateTime.Value == ngayChon)
            {
                return;
            }

            KtDateTime = ngayChon;

            List<PhongDTO> lstPhong = phongBUL.LocPhongTrongTheoNgay(ngayChon, nhaTroDangChon.MaNT);

            groupDSPhong1.Controls.Clear();
            int ucXPosition = 19;
            int ucYPosition = 19;
            int kt = 0;

            foreach (var phong in lstPhong)
            {
                UCPhong uCPhong = new UCPhong();
                if (kt == 6)
                {
                    ucXPosition = 19;
                    ucYPosition += 19 + uCPhong.Width;
                    kt = 0;
                }

                uCPhong.LoadPhongTro(phong);
                uCPhong.Left = ucXPosition;
                uCPhong.Top = ucYPosition;
                uCPhong.Tag = phong;
                uCPhong.ThemKhachTroClick += UCPhong_ThemKhachTroClick;
                uCPhong.SuaPhongClick += UCPhong_SuaPhongClick;
                uCPhong.UcClick += UCPhong_SuaPhongClick;
                uCPhong.XoaPhongClick += UCPhong_XoaPhongClick;
                uCPhong.DoiPhongClick += UCPhong_DoiPhongClick;
                uCPhong.HuyDatPhongClick += UCPhong_HuyDatPhongClick;
                uCPhong.BaoTraPhongClick += UCPhong_BaoTraPhongClick;
                uCPhong.TraPhongClick += UCPhong_TraPhongClick;
                uCPhong.InPhieuTraPhongClick += UCPhong_InPhieuTraPhongClick;

                ucXPosition += uCPhong.Width + 19;
                kt++;
                groupDSPhong1.Controls.Add(uCPhong);
            }
        }

        

        private void UCPhong_TraPhongClick(object sender, EventArgs e)
        {
            
            UCPhong uCPhong = (UCPhong)sender;
            PhongDTO phong = (PhongDTO)uCPhong.Tag;
            HopDongBUL hopDongBUL = new HopDongBUL();
            if (phongBUL.KiemTraPhongDaCoHoaDonTrongThang(phong.MaPT,DateTime.Now))
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn trả phòng này không?", "Xác nhận trả phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HopDongDTO hopDong = hopDongBUL.LayHopDongTheoMaPhong(phong.MaPT);
                    hopDong.TrangThaiHopDong = false;
                    if (hopDongBUL.CapNhatHopDong(hopDong))
                    {
                        if (phongBUL.CapNhatTrangThaiPhong(phong.MaPT, "TT01"))
                        {
                            MessageBox.Show("Trả phòng thành công");
                            LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                        }
                        else
                        {
                            MessageBox.Show("Trả phòng thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trả phòng thất bại");
                    }
                }


            }
            else
            {
                //MessageBox.Show("Phòng chưa có hóa đơn trong tháng, vui lòng nhập hóa đơn trước khi trả phòng");
                // hỏi xác nhận tính tiền trước khi trả phòng
                if (MessageBox.Show("Phòng chưa có hóa đơn trong tháng, bạn có muốn tính tiền trước khi trả phòng không?", "Xác nhận tính tiền", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HoaDonBUL hoaDonBUL = new HoaDonBUL();

                    if (!hoaDonBUL.KiemTraChiSoDienNuoc(DateTime.Now, phong.MaPT))
                    {
                        MessageBox.Show($"Phòng chưa nhập chỉ số điện nước cho tháng {DateTime.Now:MM/yyyy}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SuDungDichVuBUL suDungDichVuBUL = new SuDungDichVuBUL();
                    suDungDichVuBUL.CapNhatNgayKetThucSuDungDichVuTheoMaPhong(phong.MaPT);

                    HoaDonDTO hoaDonDTO = new HoaDonDTO();
                    hoaDonDTO.NgayLap = DateTime.Now;
                    hoaDonDTO.NgayThanhToan = DateTime.Now;
                    hoaDonDTO.MaHD = hoaDonBUL.PhatSinhMaHoaDon();
                    hoaDonDTO.MaPT = phong.MaPT;
                    hoaDonDTO.TongTien = hoaDonBUL.TinhTienHoaDonKhiTraPhong(DateTime.Now, phong.MaPT);
                    hoaDonDTO.TienDaThanhToan = 0;
                    hoaDonDTO.MaQL = "QL001";
                    hoaDonDTO.DaXoa = false;
                    hoaDonBUL.ThemHoaDon(hoaDonDTO);

                    HopDongDTO hopDong = hopDongBUL.LayHopDongTheoMaPhong(phong.MaPT);
                    hopDong.TrangThaiHopDong = false;
                    if (hopDongBUL.CapNhatHopDong(hopDong))
                    {
                        if (phongBUL.CapNhatTrangThaiPhong(phong.MaPT, "TT01"))
                        {
                            MessageBox.Show("Trả phòng thành công");
                            LoadPhongByNhaTro(nhaTroDangChon.MaNT);
                        }
                        else
                        {
                            MessageBox.Show("Trả phòng thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trả phòng thất bại");
                    }
                }
            }

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhaTro = nhaTroDangChon.MaNT;
                List<PhongDTO> danhSachPhong = phongBUL.LayPhongTheoNhaTro(maNhaTro);

                if (danhSachPhong == null || danhSachPhong.Count == 0)
                {
                    MessageBox.Show("Không có phòng nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string fileName = string.Empty;
                ExportDanhSachPhong(danhSachPhong, ref fileName);

                if (!string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDanhSachPhong(List<PhongDTO> danhSachPhong, ref string fileName)
        {
            try
            {
                Dictionary<string, string> replacer = new Dictionary<string, string>();

                string ngay = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
                replacer.Add("%NgayThangNam", ngay);
                replacer.Add("%NhaTro", nhaTroDangChon.TenNT);
                replacer.Add("%TenNV", "Trần Hoàng Khôi");
                

                byte[] arrByte = File.ReadAllBytes("DanhSachPhong.xlsx").ToArray();
                MemoryStream stream = new MemoryStream(arrByte);

                ExcelEngine engine = new ExcelEngine();
                IWorkbook workbook = engine.Excel.Workbooks.Open(stream);
                IWorksheet worksheet = workbook.Worksheets[0];
                ITemplateMarkersProcessor markerProcessor = worksheet.CreateTemplateMarkersProcessor();

                if (replacer != null && replacer.Count > 0)
                {
                    foreach (KeyValuePair<string, string> repl in replacer)
                    {
                        Replace(worksheet, repl.Key, repl.Value);
                    }
                }

                List<object> phongData = new List<object>();
                int stt = 1;

                foreach (var phong in danhSachPhong)
                {
                    phongData.Add(new
                    {
                        STT = stt++,
                        MaPhong = phong.MaPT,
                        TenPhong = phong.TenPhong,
                        DonGia = String.Format("{0:0,0 VNĐ}", phong.DonGia),
                        DienTich = $"{phong.ChieuDai * phong.ChieuRong:0.0} m²",
                        SoLuongNguoiToiDa = phong.SoLuongNguoiTD,
                        TrangThai = trangThaiPhongBUL.LayTenTrangThaiTheoMa(phong.MaTT),
                        MoTa = phong.MoTa
                    });
                }

                // Ánh xạ danh sách phòng vào file Excel
                markerProcessor.AddVariable("DanhSachPhong", phongData);
                markerProcessor.ApplyMarkers();

                // Lưu file tạm
                string tempPath = Path.GetTempFileName() + ".xlsx";
                workbook.SaveAs(tempPath);
                fileName = tempPath;

                workbook.Close();
                engine.Dispose();

                // Mở file nếu cần
                if (File.Exists(fileName) && MessageBox.Show("Bạn có muốn mở file không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(fileName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất danh sách phòng: " + ex.Message);
            }
        }

        private void Replace(IWorksheet wordSheet, string placeholder, string value)
        {
            wordSheet.Replace(placeholder, value, ExcelFindOptions.MatchCase);
        }

    }
}
