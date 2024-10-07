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
    public partial class frmChiSoDien : Form
    {
        public frmChiSoDien()
        {
            InitializeComponent();
        }

        private void dgvCSDien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvCSDien.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Vẽ lại nền và viền của ô
                e.PaintBackground(e.CellBounds, true);

                // Tạo kích thước nhỏ hơn cho nút
                Rectangle buttonRect = new Rectangle(
                    e.CellBounds.Left + 79, // Cách viền trái 10 pixel
                    e.CellBounds.Top + 3,   // Cách viền trên 5 pixel
                    70, // Chiều rộng của nút (trừ đi 20 pixel tổng 2 bên)
                    40 // Chiều cao của nút (trừ đi 10 pixel tổng 2 bên)
                );

                Color buttonBackColor = Color.FromArgb(38, 185, 154); // Màu nền của nút
                Color buttonTextColor = Color.White;   // Màu chữ của nút

                // Vẽ hình chữ nhật làm nền của nút
                using (Brush brush = new SolidBrush(buttonBackColor))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                // Vẽ text của nút với màu tùy chỉnh
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
