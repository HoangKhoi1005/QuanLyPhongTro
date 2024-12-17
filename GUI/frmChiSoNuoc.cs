using AForge.Imaging.Filters;
using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using Tesseract;

namespace GUI
{
    public partial class frmChiSoNuoc : Form
    {
        ChiSoDienNuocDTO cs = new ChiSoDienNuocDTO();
        BindingList<ChiSoDienNuocDTO> chiSoDienNuocList;
        ChiSoDienNuocBUL chiSoDienNuocBUL = new ChiSoDienNuocBUL();
        private Rectangle cropArea;

        public frmChiSoNuoc()
        {
            InitializeComponent();

            dtpNgayThang.Format = DateTimePickerFormat.Custom;
            dtpNgayThang.CustomFormat = "MM/yyyy";
            //dtpNgayThang.ShowUpDown = true;

            cropArea = new Rectangle(272, 193, 152, 24);

            pbAnh.MouseDown += pbAnh_MouseDown;
            pbAnh.MouseMove += pbAnh_MouseMove;
            pbAnh.MouseUp += pbAnh_MouseUp;
            pbAnh.Paint += pbAnh_Paint;
        }

        private void pbAnh_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = e.Location;
                cropArea = new Rectangle(
                    Math.Min(startPoint.X, currentPoint.X),
                    Math.Min(startPoint.Y, currentPoint.Y),
                    Math.Abs(currentPoint.X - startPoint.X),
                    Math.Abs(currentPoint.Y - startPoint.Y));

                pbAnh.Invalidate();

                label1.Text = $"X: {cropArea.X}, Y: {cropArea.Y}, W: {cropArea.Width}, H: {cropArea.Height}";
            }
        }

        public void loadCSDienNuoc()
        {
            var csList = chiSoDienNuocBUL.loadDienNuoc();
            chiSoDienNuocList = new BindingList<ChiSoDienNuocDTO>(csList);
            dgvChiSo.DataSource = chiSoDienNuocList;
            dgvChiSo.Columns["MACS"].Visible = false;

            foreach (DataGridViewColumn column in dgvChiSo.Columns)
            {
                if (column.Name != "MAPT")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }
        
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string input = txtTraCuu.Text.Trim();
            string maPT = "";
            int ngay = 0;
            int thang = 0;
            int nam = 0;

            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 1) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    else
                    {
                        maPT = parts[0]; 
                    }
                }
                else if (parts.Length == 2) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                }
                else if (parts.Length == 3) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                    if (int.TryParse(parts[2], out int year))
                    {
                        nam = year; 
                    }
                }
            }

            dgvChiSo.DataSource = chiSoDienNuocBUL.TimKiemDienNuoc(maPT, ngay, thang, nam);
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string input = txtTraCuu.Text.Trim();
            string maPT = "";
            int ngay = 0; 
            int thang = 0; 
            int nam = 0;

            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 1) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    else
                    {
                        maPT = parts[0]; 
                    }
                }
                else if (parts.Length == 2) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                }
                else if (parts.Length == 3) 
                {
                    if (int.TryParse(parts[0], out int day))
                    {
                        ngay = day; 
                    }
                    if (int.TryParse(parts[1], out int month))
                    {
                        thang = month; 
                    }
                    if (int.TryParse(parts[2], out int year))
                    {
                        nam = year; 
                    }
                }
            }

            dgvChiSo.DataSource = chiSoDienNuocBUL.TimKiemDienNuoc(maPT, ngay, thang, nam);
        }

        private void frmChiSoNuoc_Load(object sender, EventArgs e)
        {
            dgvChiSo.AllowUserToAddRows = true;
            dgvChiSo.AllowUserToDeleteRows = true;
            dgvChiSo.ReadOnly = false;
            dgvChiSo.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvChiSo.DataError += dgvChiSo_DataError;
            loadCSDienNuoc();

            dgvChiSo.Columns["MAPT"].ReadOnly = true;
            dgvChiSo.Columns["NGAYTHANG"].ReadOnly = true;
            dgvChiSo.Columns["CHISODIENCU"].ReadOnly = true;
            dgvChiSo.Columns["CHISONUOCCU"].ReadOnly = true;
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            bool isValid = true; 

            foreach (DataGridViewRow row in dgvChiSo.Rows)
            {
                if (row.IsNewRow) continue;

                int chiSoDien = row.Cells["CHISODIEN"].Value != DBNull.Value && row.Cells["CHISODIEN"].Value != null
                                ? Convert.ToInt32(row.Cells["CHISODIEN"].Value)
                                : 0;

                int chiSoNuoc = row.Cells["CHISONUOC"].Value != DBNull.Value && row.Cells["CHISONUOC"].Value != null
                                ? Convert.ToInt32(row.Cells["CHISONUOC"].Value)
                                : 0;

                if (row.Cells["CHISODIEN"].Value == DBNull.Value || row.Cells["CHISONUOC"].Value == DBNull.Value)
                {
                    MessageBox.Show("Chỉ số điện và nước không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    taiDuLieu();
                    return;
                }

                var chiSoDN = new ChiSoDienNuocDTO
                {
                    MaCS = Convert.ToInt32(row.Cells["MACS"].Value),
                    MaPT = row.Cells["MAPT"].Value.ToString(),
                    NgayThang = Convert.ToDateTime(row.Cells["NGAYTHANG"].Value),
                    ChiSoDien = chiSoDien,
                    ChiSoNuoc = chiSoNuoc,
                    ChiSoDienCu = row.Cells["CHISODIENCU"].Value != DBNull.Value && row.Cells["CHISODIENCU"].Value != null
                                  ? Convert.ToInt32(row.Cells["CHISODIENCU"].Value)
                                  : 0,
                    ChiSoNuocCu = row.Cells["CHISONUOCCU"].Value != DBNull.Value && row.Cells["CHISONUOCCU"].Value != null
                                  ? Convert.ToInt32(row.Cells["CHISONUOCCU"].Value)
                                  : 0
                };

                if (chiSoDN.ChiSoDien <= chiSoDN.ChiSoDienCu || chiSoDN.ChiSoNuoc <= chiSoDN.ChiSoNuocCu)
                {
                    MessageBox.Show("Chỉ số điện và nước mới phải lớn hơn chỉ số điện và nước cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    taiDuLieu();
                    break;
                }
                else
                {
                    if (chiSoDN.MaCS == 0)
                    {
                        chiSoDN.MaCS = chiSoDienNuocBUL.PhatSinhMaChiSoDN();
                        chiSoDienNuocBUL.themDienNuoc(chiSoDN);
                    }
                    else
                    {
                        chiSoDienNuocBUL.suaDienNuoc(chiSoDN);
                    }
                }
            }

            if (isValid)
            {
                MessageBox.Show("Lưu thành công!");
                taiDuLieu();
            }
        }

        private void dgvChiSo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số vào các ô chỉ số điện và nước!",
                                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.ThrowException = false; 
            }
            else
            {
                e.ThrowException = true; 
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa chỉ số điện nước đã nhập không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvChiSo.SelectedRows.Count > 0)
                {
                    var row = dgvChiSo.SelectedRows[0];
                    string maPhong = row.Cells["MAPT"].Value.ToString();
                    MessageBox.Show(maPhong);

                    bool isUpdated = chiSoDienNuocBUL.CapNhatChiSoVe0(maPhong);

                    if (isUpdated)
                    {
                        MessageBox.Show("Xóa điện nước thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        row.Cells["ChiSoDien"].Value = 0;
                        row.Cells["ChiSoNuoc"].Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Xóa điện nước thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void taiDuLieu()
        {
            DateTime selectedDate = dtpNgayThang.Value; 
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            var danhSachPhong = chiSoDienNuocBUL.loadMaPT();
            var danhSachChiSo = chiSoDienNuocBUL.loadDienNuoc();

            List<ChiSoDienNuocDTO> danhSachHienThi = new List<ChiSoDienNuocDTO>();

            foreach (var maPhong in danhSachPhong)
            {
                var chiSoPhongThangHienTai = danhSachChiSo.FirstOrDefault(cs =>
            cs.MaPT == maPhong &&
            cs.NgayThang.Month == month &&
            cs.NgayThang.Year == year);

                var chiSoPhongThangTruoc = danhSachChiSo.FirstOrDefault(cs =>
                    cs.MaPT == maPhong &&
                    cs.NgayThang.Month == month - 1 &&
                    cs.NgayThang.Year == year);

                var chiSoDN = new ChiSoDienNuocDTO
                {
                    MaCS = chiSoPhongThangHienTai != null ? chiSoPhongThangHienTai.MaCS : 0,
                    MaPT = maPhong,
                    NgayThang = new DateTime(year, month, 1),
                    ChiSoDien = chiSoPhongThangHienTai != null ? chiSoPhongThangHienTai.ChiSoDien : 0,
                    ChiSoNuoc = chiSoPhongThangHienTai != null ? chiSoPhongThangHienTai.ChiSoNuoc : 0,
                    ChiSoDienCu = chiSoPhongThangTruoc != null ? chiSoPhongThangTruoc.ChiSoDien : 0,
                    ChiSoNuocCu = chiSoPhongThangTruoc != null ? chiSoPhongThangTruoc.ChiSoNuoc : 0
                };

                danhSachHienThi.Add(chiSoDN);
            }

            chiSoDienNuocList = new BindingList<ChiSoDienNuocDTO>(danhSachHienThi);
            dgvChiSo.DataSource = chiSoDienNuocList;
        }

        private void dtpNgayThang_ValueChanged(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loadCSDienNuoc();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loadCSDienNuoc();            
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            if(dgvChiSo.SelectedRows.Count > 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    pbAnh.Image = Image.FromFile(fileName);

                    PerformAutomaticAnalysis();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để tải ảnh lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PerformAutomaticAnalysis()
        {
            if (pbAnh.Image == null)
            {
                MessageBox.Show("Chưa tải ảnh lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap originalImg = new Bitmap(pbAnh.Image);

            float scaleX = (float)originalImg.Width / pbAnh.ClientSize.Width;
            float scaleY = (float)originalImg.Height / pbAnh.ClientSize.Height;

            Rectangle adjustedCropArea = new Rectangle(
                (int)(cropArea.X * scaleX),
                (int)(cropArea.Y * scaleY),
                (int)(cropArea.Width * scaleX),
                (int)(cropArea.Height * scaleY)
            );

            Rectangle imageBounds = new Rectangle(0, 0, originalImg.Width, originalImg.Height);
            adjustedCropArea = Rectangle.Intersect(adjustedCropArea, imageBounds);

            if (adjustedCropArea.Width <= 0 || adjustedCropArea.Height <= 0)
            {
                MessageBox.Show("Vùng chọn không hợp lệ hoặc nằm ngoài ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap croppedImg = originalImg.Clone(adjustedCropArea, originalImg.PixelFormat);

            Bitmap processedImg = PreprocessImage(croppedImg);

            string resultText = PerformOCR(processedImg);

            string extractedDigits = ExtractMaxFourDigits(resultText);

            textBox1.Text = extractedDigits;

            if (dgvChiSo.SelectedRows.Count > 0)
            {
                var row = dgvChiSo.SelectedRows[0];
                int validNumber = 0;

                if (!string.IsNullOrWhiteSpace(extractedDigits) && int.TryParse(extractedDigits, out validNumber))
                {
                    row.Cells["CHISODIEN"].Value = validNumber;
                }
                else
                {
                    MessageBox.Show("Không thể trích xuất giá trị hợp lệ từ kết quả OCR.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["CHISODIEN"].Value = validNumber;
                }
            }
        }

        private string ExtractMaxFourDigits(string input)
        {
            var matches = System.Text.RegularExpressions.Regex.Matches(input, @"\d");
            return string.Concat(matches.Cast<System.Text.RegularExpressions.Match>().Select(m => m.Value).Take(4));
        }


        private Bitmap PreprocessImage(Bitmap img)
        {
            Grayscale grayscaleFilter = new Grayscale(0.3, 0.59, 0.11);
            Bitmap grayImg = grayscaleFilter.Apply(img);

            GaussianBlur blurFilter = new GaussianBlur(3.0, 7);
            Bitmap blurredImg = blurFilter.Apply(grayImg);

            BradleyLocalThresholding thresholdFilter = new BradleyLocalThresholding
            {
                PixelBrightnessDifferenceLimit = -0.1f
            };
            Bitmap binaryImg = thresholdFilter.Apply(blurredImg);

            Invert invertFilter = new Invert();
            invertFilter.ApplyInPlace(binaryImg);

            return binaryImg;
        }

        private string PerformOCR(Bitmap img)
        {
            string result = "";
            try
            {
                using (var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
                {
                    ocr.SetVariable("tessedit_char_whitelist", "012345689");

                    using (var page = ocr.Process(img))
                    {
                        result = page.GetText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi OCR: " + ex.Message);
            }
            return result;
        }
        private bool isDragging = false;
        private Point startPoint;
        private void pbAnh_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDragging = true;

                
            }
        }

        private void pbAnh_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pbAnh_Paint(object sender, PaintEventArgs e)
        {
            if (cropArea != Rectangle.Empty && isDragging)
            {
                e.Graphics.DrawRectangle(Pens.Red, cropArea);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformAutomaticAnalysis();
        }

        private void dgvChiSo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dgvChiSo.Columns[e.ColumnIndex].Name;

            if (columnName == "CHISODIEN" || columnName == "CHISONUOC")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int result))
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
