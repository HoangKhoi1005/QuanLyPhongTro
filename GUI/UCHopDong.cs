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
    public partial class UCHopDong : UserControl
    {
        private PhongDTO phong;
        private HopDongBUL HopDongBUL = new HopDongBUL();
        private HopDongDTO hopDong;
        private ChiSoDienNuocBUL ChiSoDienNuocBUL = new ChiSoDienNuocBUL();

        public UCHopDong(PhongDTO phong)
        {
            InitializeComponent();
            this.phong = phong;
            hopDong = HopDongBUL.LayHopDongTheoMaPhong(phong.MaPT);

            txtMaHopDong.Text = HopDongBUL.TimMaHopDongTheoMaPhong(phong.MaPT);
            txtMaPT.Text = phong.MaPT;
            txtTenNL.Text = hopDong.MaQL;
            txtTenKT.Text = hopDong.MaKT;
            dtpNgayDenHan.Value = hopDong.NgayHetHan;
            dtpNgayLap.Value = hopDong.NgayLap;
            txtTienCoc.Text = string.Format("{0:#,##0}", hopDong.TienCoc);
            txtMoTa.Text = hopDong.MoTa;

            txtChiSoDien.Text = ChiSoDienNuocBUL.LayChiSoDienNuocTheoMaPhong(phong.MaPT,hopDong.NgayLap).ChiSoDien.ToString();
            txtChiSoNuoc.Text = ChiSoDienNuocBUL.LayChiSoDienNuocTheoMaPhong(phong.MaPT, hopDong.NgayLap).ChiSoNuoc.ToString();
        }

        private void btnLuuHopDong_Click(object sender, EventArgs e)
        {
            if(txtTienCoc.Text == "")
            {
                MessageBox.Show("Tiền cọc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtTienCoc.Text == "0")
            {
                MessageBox.Show("Tiền cọc phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtTienCoc.Text.All(char.IsLetter))
            {
                MessageBox.Show("Tiền cọc phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            hopDong.NgayHetHan = dtpNgayDenHan.Value;
            hopDong.NgayLap = dtpNgayLap.Value;
            hopDong.TienCoc = decimal.Parse(txtTienCoc.Text);
            hopDong.MoTa = txtMoTa.Text;

            if (HopDongBUL.CapNhatHopDong(hopDong))
            {
                MessageBox.Show("Cập nhật hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
