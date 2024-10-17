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
    public partial class frmDichVu : Form
    {
        private DichVuBUL dichVuBUL = new DichVuBUL();
        public frmDichVu()
        {
            InitializeComponent();
        }
        
        public void loadDichVu()
        {

        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = dichVuBUL.loadDichVu();
        }
    }
}
