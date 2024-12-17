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
    public partial class frmCocGiuPhong : Form
    {
        PhieuDatPhongBUL phieuDatPhongBUL = new PhieuDatPhongBUL();

        public frmCocGiuPhong()
        {
            InitializeComponent();
        }

        private void frmCocGiuPhong_Load(object sender, EventArgs e)
        {
            dgvPhieuDat.DataSource = phieuDatPhongBUL.LayDSPhieuDatDataGirdView();
        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {

            if (dgvPhieuDat.CurrentRow != null)
            {
                string maPhietDat = dgvPhieuDat.CurrentRow.Cells["MAPDP"].Value.ToString();

                Dictionary<string, string> contractDict = phieuDatPhongBUL.GetContractDictionary(maPhietDat);

                string templatePath = @"D:\Nam4KyI\PhatTrienPMUDTM\PhieuDatphong.docx";
                WordExport wordExport = new WordExport(Application.StartupPath + "\\PhieuDatPhong.docx", true);

                wordExport.WriteFields(contractDict);

                MessageBox.Show("Xuất phiếu đặt thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu để xuất.");
            }
        }
    }
}
