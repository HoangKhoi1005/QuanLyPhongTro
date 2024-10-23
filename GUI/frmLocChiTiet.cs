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
    public partial class frmLocChiTiet : MetroFramework.Forms.MetroForm
    {
        TaiSanBUL taiSanBUL = new TaiSanBUL();
        private frmPhong frmPhong;
        string maNT;

        public frmLocChiTiet(frmPhong frmPhong, string maNT, List<string> dsTenTaiSan)
        {
            InitializeComponent();
            this.frmPhong = frmPhong;
            this.maNT = maNT;
            this.dsTenTaiSan = dsTenTaiSan;
        }

        private void frmLocChiTiet_Load(object sender, EventArgs e)
        {
            int y = 20;
            int x = 20;
            int dem = 0;
            foreach (string tents in taiSanBUL.LayDSTenTaiSan())
            {
                CheckBox ckb = new CheckBox();
                ckb.Text = tents;
                ckb.AutoSize = true;
                ckb.Height = 20;
                ckb.Width = 130;
                ckb.Location = new Point(x, y);
                x += ckb.Width + 20;
                grpDSLoc.Controls.Add(ckb);
                dem++;

                if (dsTenTaiSan.Contains(tents))
                {
                    ckb.Checked = true;
                }

                if (dem == 5)
                {
                    y += 30;
                    x = 20;
                    dem = 0;
                }
            }
        }

        List<string> dsTenTaiSan = new List<string>();

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dsTenTaiSan.Clear();
            foreach (CheckBox ckb in grpDSLoc.Controls)
            {
                if (ckb.Checked)
                {
                    dsTenTaiSan.Add(ckb.Text);
                }
            }

            
            frmPhong.dsTenTaiSan = dsTenTaiSan;
            this.Close();
        }
    }
}
