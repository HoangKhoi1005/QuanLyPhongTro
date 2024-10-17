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
    }
}
