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
    public partial class frmDatPhong : MetroFramework.Forms.MetroForm
    {
        private PhongDTO phong;
        private KhachTroDTO khachTro;

        public frmDatPhong(PhongDTO phong, KhachTroDTO khachTro)
        {
            InitializeComponent();
            this.phong = phong;
            this.khachTro = khachTro;
        }
    }
}
