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
    public partial class frmDichVu : Form
    {
        DichVuDTO dv = new DichVuDTO();
        BindingList<DichVuDTO> dichVuList;
        private DichVuBUL dichVuBUL = new DichVuBUL();
        public frmDichVu()
        {
            InitializeComponent();
        }
        
        public void loadDichVu()
        {
            var dvList = dichVuBUL.loadDichVu();
            dichVuList = new BindingList<DichVuDTO>(dvList);
            dgvDichVu.DataSource = dichVuList;
            dgvDichVu.Columns["DAXOA"].Visible = false;

            foreach (DataGridViewColumn column in dgvDichVu.Columns)
            {
                if (column.Name != "MADV")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
            
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dgvDichVu.AllowUserToAddRows = true;
            dgvDichVu.AllowUserToDeleteRows = true;
            dgvDichVu.ReadOnly = false;
            dgvDichVu.EditMode = DataGridViewEditMode.EditOnEnter;
            loadDichVu();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = dichVuBUL.TimKiemDichVu(txtTraCuu.Text);
            dgvDichVu.Columns["DAXOA"].Visible = false;
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string tenDichVu = txtTraCuu.Text.Trim();

            if (string.IsNullOrEmpty(tenDichVu))
            {
                dgvDichVu.DataSource = dichVuBUL.loadDichVu(); 
            }
            else
            {
                dgvDichVu.DataSource = dichVuBUL.TimKiemDichVu(tenDichVu); 
            }
            dgvDichVu.Columns["DAXOA"].Visible = false;
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                if (row.IsNewRow) continue;

                //if (row.Cells["TENDV"].Value == null || string.IsNullOrWhiteSpace(row.Cells["TENDV"].Value.ToString()) ||
                //    row.Cells["DONGIA"].Value == null)
                //{
                //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên dịch vụ và Đơn giá.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                if (!decimal.TryParse(row.Cells["DONGIA"].Value?.ToString(), out decimal donGia))
                {
                    MessageBox.Show("Đơn giá bắt buộc phải là số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                var dichvu = new DichVuDTO
                {
                    MaDV = row.Cells["MADV"].Value?.ToString() ?? "",
                    TenDV = row.Cells["TENDV"].Value?.ToString() ?? "Dịch vụ 1", 
                    MoTa = row.Cells["MOTA"].Value?.ToString() ?? "Dịch vụ 1",
                    DonGia = row.Cells["DONGIA"].Value != null ? Convert.ToDecimal(row.Cells["DONGIA"].Value) : 0,  // Gán giá trị 0 nếu null
                    DaXoa = row.Cells["DAXOA"].Value != null && Convert.ToBoolean(row.Cells["DAXOA"].Value) // Gán false nếu null
                };

                if (dichvu.MaDV == "")
                {
                    dichvu.MaDV = dichVuBUL.PhatSinhMaDichVu();
                    dichVuBUL.themDichVu(dichvu);
                    kt = 0;
                }
                else
                {
                    if (kiemTraMa(dichvu.MaDV))
                    {
                        dichVuBUL.suaDichVu(dichvu);
                        kt = 1;
                    }
                    else
                    {
                        MessageBox.Show("Mã chỉ số điện nước không tồn tại trong cơ sở dữ liệu.");
                    }
                }
            }

            if (kt == 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sửa thành công");

            loadDichVu();
        }

        private bool kiemTraMa(string maDV)
        {
            var maDichVu = dichVuBUL.loadDichVu().FirstOrDefault(dn => dn.MaDV == maDV);
            return maDichVu != null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kt = 0;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (dgvDichVu.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDichVu.SelectedRows)
                    {
                        if (row.IsNewRow) continue;

                        var dichvu = new DichVuDTO
                        {
                            MaDV = row.Cells["MADV"].Value.ToString(),  // Mã dịch vụ
                            TenDV = row.Cells["TENDV"].Value.ToString(),  // Tên dịch vụ
                            MoTa = row.Cells["MOTA"].Value.ToString(),  // Mô tả dịch vụ
                            DonGia = Convert.ToDecimal(row.Cells["DONGIA"].Value),  // Đơn giá
                            DaXoa = Convert.ToBoolean(row.Cells["DAXOA"].Value)
                        };
                        if (dichVuBUL.xoaDichVu(dichvu))
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
                        MessageBox.Show("Xóa dịch vụ thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại");
                    }
                    loadDichVu();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
                }
            }
            else
                return;
        }
    }
}
