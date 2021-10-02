using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KTNam_Nu()
        {
            int demnam = 0, demnu = -1;
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                if (dgvDSSV.Rows[i].Cells[2].Value?.ToString() == "Nam")
                {
                    demnam++;
                }
                else
                {
                    demnu++;
                }
            }
            txtNam.Text = demnam.ToString();
            txtNu.Text = demnu.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNu.Checked = true;
            cbbChuyenNganh.SelectedIndex = 1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                if (dgvDSSV.Rows[i].Cells[0].Value?.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvDSSV.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvDSSV.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvDSSV.Rows[selectedRow].Cells[2].Value = rdoNu.Checked ? "Nữ " : "Nam";
            dgvDSSV.Rows[selectedRow].Cells[3].Value =
                     float.Parse(txtDTB.Text).ToString();
            dgvDSSV.Rows[selectedRow].Cells[4].Value = cbbChuyenNganh.Text;
        }


        private void btnThem_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");

                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if(selectedRow == -1)
                {
                    selectedRow = dgvDSSV.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }

                KTNam_Nu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Yes / No", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvDSSV.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    } 
                }
                KTNam_Nu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSSV.CurrentRow.Selected = true;

                    txtMSSV.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgvMa"].FormattedValue.ToString();
                    txtHoTen.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgvTen"].FormattedValue.ToString();
                    txtDTB.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgvDTB"].FormattedValue.ToString();

                    if (dgvDSSV.Rows[e.RowIndex].Cells["dgvGioiTinh"].FormattedValue.ToString() == "Nữ")
                    {
                        rdoNu.Checked = true;
                    }
                    if (dgvDSSV.Rows[e.RowIndex].Cells["dgvGioiTinh"].FormattedValue.ToString() == "Nam")
                    {
                        rdoNam.Checked = true;
                    }

                    cbbChuyenNganh.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgvChuyenNganh"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
