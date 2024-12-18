using BUL;
using DTO;
using Guna.UI2.WinForms;
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
    public partial class btnLuu : Form
    {
        DateTimePicker DateTimePicker = new DateTimePicker();
        Rectangle _Rectangle;
        PhatSinhDTO ps = new PhatSinhDTO();
        PhatSinhBUL phatSinhBUL = new PhatSinhBUL();
        BindingList<PhatSinhDTO> phatSinhBindingList;
        PhongBUL phongBUL = new PhongBUL();
        public btnLuu()
        {
            InitializeComponent();

            dgvPhatSinh.Controls.Add(DateTimePicker);
            DateTimePicker.Visible = false;
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.TextChanged += new EventHandler(DateTimePicker_TextChanged);
            dgvPhatSinh.Columns[3].DefaultCellStyle.Format = "N0";
        }

        private void DateTimePicker_TextChanged(object sender, EventArgs e)
        {
            dgvPhatSinh.CurrentCell.Value = DateTimePicker.Text.ToString();
        }

        public void loadTienPhatSinh()
        {
            var phatSinhList = phatSinhBUL.loadPhatSinh();
            phatSinhBindingList = new BindingList<PhatSinhDTO>(phatSinhList);
            dgvPhatSinh.DataSource = phatSinhBindingList;

            if (dgvPhatSinh.Columns["MAPT"] is DataGridViewComboBoxColumn colMaPT)
            {
                // Đặt DataSource cho cột MAPT
                colMaPT.DataSource = phongBUL.LayTatCaMaPhong();
            }


            foreach (DataGridViewColumn column in dgvPhatSinh.Columns)
            {
                if (column.Name != "MAPHATSINH")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }
        
        private void frmTienPhatSinh_Load(object sender, EventArgs e)
        {
            dgvPhatSinh.AllowUserToAddRows = true;  
            dgvPhatSinh.AllowUserToDeleteRows = true;  
            dgvPhatSinh.ReadOnly = false;  
            dgvPhatSinh.EditMode = DataGridViewEditMode.EditOnEnter; 
            loadTienPhatSinh();
            dgvPhatSinh.DataError += dgvPhatSinh_DataError;
        }

        private void dgvPhatSinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                MessageBox.Show("Định dạng dữ liệu không hợp lệ. Vui lòng kiểm tra ngày tháng và thử lại.",
                                "Lỗi định dạng",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                e.ThrowException = false;
            }
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (DataGridViewRow row in dgvPhatSinh.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu.");
                        return;
                    }
                }

                DateTime ngayThang;
                if (row.Cells["NGAYTHANG"].Value == null || !DateTime.TryParse(row.Cells["NGAYTHANG"].Value.ToString(), out ngayThang))
                {
                    MessageBox.Show("Vui lòng nhập ngày tháng hợp lệ (định dạng: MM/dd/yyyy).");
                    return;
                }

                decimal soTien;
                if (row.Cells["SOTIEN"].Value == null || !decimal.TryParse(row.Cells["SOTIEN"].Value.ToString(), out soTien) || soTien <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ lớn hơn 0.");
                    return;
                }



                var phatSinh = new PhatSinhDTO
                {
                    MaPS = Convert.ToInt32(row.Cells["MAPHATSINH"].Value),
                    MaPT = row.Cells["MAPT"].Value.ToString(),
                    NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                    SoTien = Convert.ToDecimal(row.Cells["SOTIEN"].Value),
                    MoTa = row.Cells["MOTA"].Value.ToString(),
                    LoaiPS = row.Cells["LoaiPS"].Value.ToString()
                };

                if (phatSinh.MaPS == 0)
                {
                    phatSinh.MaPS = phatSinhBUL.PhatSinhMaPhatSinh();
                    phatSinhBUL.themPhatSinh(phatSinh);
                    kt = 0;
                }
                else
                {
                    if (kiemTraMa(phatSinh.MaPS))
                    {
                        phatSinhBUL.suaPhatSinh(phatSinh);
                        kt = 1;
                    }
                    else
                    {
                        MessageBox.Show("Mã phát sinh không tồn tại trong cơ sở dữ liệu.");
                    }
                }
            }

            if (kt == 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sửa thành công");

            loadTienPhatSinh();
        }

        private void dgvPhatSinh_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (e.RowIndex == dgvPhatSinh.NewRowIndex) // Dòng mới đang được thêm
            //{
            //    // Gán mã phát sinh tự động
            //    dgvPhatSinh.Rows[e.RowIndex].Cells["MAPHATSINH"].Value = phatSinhBUL.PhatSinhMaPhatSinh();  // Gọi phương thức lấy mã mới
            //}
        }

        private bool kiemTraMa(int maPS)
        {
            var maPhatSinh = phatSinhBUL.loadPhatSinh().FirstOrDefault(ps => ps.MaPS == maPS);
            return maPhatSinh != null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kt = 0;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvPhatSinh.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPhatSinh.SelectedRows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            {
                                MessageBox.Show("Chưa có dữ liệu để xóa.");
                                return;
                            }
                        }

                        var phatSinh = new PhatSinhDTO
                        {
                            MaPS = Convert.ToInt32(row.Cells["MAPHATSINH"].Value),
                            MaPT = row.Cells["MAPT"].Value.ToString(),
                            NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                            SoTien = Convert.ToDecimal(row.Cells["SOTIEN"].Value),
                            MoTa = row.Cells["MOTA"].Value.ToString(),
                            LoaiPS = row.Cells["LoaiPS"].Value.ToString()
                        };
                        if (phatSinhBUL.xoaPhatSinh(phatSinh))
                        {
                            kt = 1;
                        }
                        else
                        {
                            kt = 0;
                        }
                    }
                    if (kt == 1)
                    {
                        MessageBox.Show("Xóa phát sinh thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa phát sinh thất bại");
                    }
                    loadTienPhatSinh();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
                }
            }
            else
                return;
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (txtTraCuu.Text == "")
            {
                loadTienPhatSinh();
            }
            else
            {
                var phatSinhList = phatSinhBUL.loadPhatSinh().Where(ps => ps.MaPS.ToString().Contains(txtTraCuu.Text) ||
                                                                                     ps.MaPT.Contains(txtTraCuu.Text) ||
                                                                                     ps.NgayThang.ToString().Contains(txtTraCuu.Text) ||
                                                                                     ps.SoTien.ToString().Contains(txtTraCuu.Text) ||
                                                                                     ps.MoTa.Contains(txtTraCuu.Text) ||
                                                                                     ps.LoaiPS.Contains(txtTraCuu.Text)).ToList();
                phatSinhBindingList = new BindingList<PhatSinhDTO>(phatSinhList);
                dgvPhatSinh.DataSource = phatSinhBindingList;
            }
        }

        private void dgvPhatSinh_Scroll(object sender, ScrollEventArgs e)
        {
            DateTimePicker.Visible = false;
        }

        private void dgvPhatSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvPhatSinh.Columns[e.ColumnIndex].Name)
            {
                case "NGAYTHANG":
                    _Rectangle = dgvPhatSinh.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    DateTimePicker.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    DateTimePicker.Location = new Point(_Rectangle.X, _Rectangle.Y);
                    DateTimePicker.Visible = true;
                    break;
                default:
                    DateTimePicker.Visible = false;
                    break;
            }
        }
    }
}
