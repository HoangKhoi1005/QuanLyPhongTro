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
        }

        public void LoadData()
        {
            dgvHopDong.DataSource = hopDongBUL.LayDSHopDongDataGirdView();
        }
    }
}
