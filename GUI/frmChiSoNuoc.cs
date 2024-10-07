using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI
{
    public partial class frmChiSoNuoc : Form
    {
        public frmChiSoNuoc()
        {
            InitializeComponent();
        }

        private void frmChiSoNuoc_Load(object sender, EventArgs e)
        {

        }


        private void dgvCSNuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dgvCSNuoc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvCSNuoc.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // viền
                e.PaintBackground(e.CellBounds, true);

                // kích thước
                Rectangle buttonRect = new Rectangle(
                    e.CellBounds.Left + 79, 
                    e.CellBounds.Top + 3,  
                    70, //rộng
                    40 //cao
                );

                Color buttonBackColor = Color.FromArgb(38, 185, 154); 
                Color buttonTextColor = Color.White;   

                // Vẽ hình chữ nhật làm nền của nút
                using (Brush brush = new SolidBrush(buttonBackColor))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                // Vẽ text
                TextRenderer.DrawText(
                    e.Graphics,
                    "Lưu",
                    e.CellStyle.Font,
                    buttonRect,
                    buttonTextColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                // Ngăn DataGridView vẽ lại ô theo kiểu mặc định
                e.Handled = true;
            }
        }
    }
}
