using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BUS;
using Project.DAO;

namespace Project
{
    public partial class frmDanhSachDaiLy : Form
    {
        public frmDanhSachDaiLy()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDanhSachDaiLy_Load(object sender, EventArgs e)
        {
            dgvDSDL.DefaultCellStyle.ForeColor = Color.Black;

            DaiLyBUS.Instance.GetAll(dgvDSDL);
            dgvDSDL.Columns[0].HeaderCell.Value = "Mã ĐL";
            dgvDSDL.Columns[1].HeaderCell.Value = "Tên đại lý";
            dgvDSDL.Columns[2].HeaderCell.Value = "Điện thoại";
            dgvDSDL.Columns[3].HeaderCell.Value = "Địa chỉ";
            dgvDSDL.Columns[4].HeaderCell.Value = "Ngày tiếp nhận";
            dgvDSDL.Columns[5].HeaderCell.Value = "Email";
            dgvDSDL.Columns[6].HeaderCell.Value = "Tiền nợ";
            dgvDSDL.Columns[7].HeaderCell.Value = "Mã Loại ĐL";
            dgvDSDL.Columns[8].HeaderCell.Value = "Mã Quận";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowindex = dgvDSDL.CurrentRow.Index;

            string maDL = dgvDSDL.Rows[rowindex].Cells[0].Value.ToString();

            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá không.", "Question???", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DaiLyBUS.Instance.Delete(maDL))
                    {
                        MessageBox.Show("Xoá đại lý thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDSDL.DataSource = null;
                        DaiLyBUS.Instance.GetAll(dgvDSDL);
                        dgvDSDL.Columns[0].HeaderCell.Value = "Mã ĐL";
                        dgvDSDL.Columns[1].HeaderCell.Value = "Tên đại lý";
                        dgvDSDL.Columns[2].HeaderCell.Value = "Điện thoại";
                        dgvDSDL.Columns[3].HeaderCell.Value = "Địa chỉ";
                        dgvDSDL.Columns[4].HeaderCell.Value = "Ngày tiếp nhận";
                        dgvDSDL.Columns[5].HeaderCell.Value = "Email";
                        dgvDSDL.Columns[6].HeaderCell.Value = "Tiền nợ";
                        dgvDSDL.Columns[7].HeaderCell.Value = "Mã Loại ĐL";
                        dgvDSDL.Columns[8].HeaderCell.Value = "Mã Quận";
                    }
                    else
                    {
                        MessageBox.Show("Xoá đại lý không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaDL.Text != "")
            {
                string MaDL = txtMaDL.Text;
                MaDL = MaDL.TrimEnd();
                DAILY temp = DaiLyBUS.Instance.GetByID(MaDL);
                if (temp != null)
                {
                    dgvDSDL.DataSource = null;
                    DaiLyBUS.Instance.GetByID(MaDL, dgvDSDL);
                    dgvDSDL.Columns[0].HeaderCell.Value = "Mã ĐL";
                    dgvDSDL.Columns[1].HeaderCell.Value = "Tên đại lý";
                    dgvDSDL.Columns[2].HeaderCell.Value = "Điện thoại";
                    dgvDSDL.Columns[3].HeaderCell.Value = "Địa chỉ";
                    dgvDSDL.Columns[4].HeaderCell.Value = "Ngày tiếp nhận";
                    dgvDSDL.Columns[5].HeaderCell.Value = "Email";
                    dgvDSDL.Columns[6].HeaderCell.Value = "Tiền nợ";
                    dgvDSDL.Columns[7].HeaderCell.Value = "Mã Loại ĐL";
                    dgvDSDL.Columns[8].HeaderCell.Value = "Mã Quận";
                }
                else
                {
                    dgvDSDL.DataSource = null;
                    MessageBox.Show("Không Tìm Thấy Đại lý!", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Phải Nhập Mã Đại Lý Tìm Kiếm!", "Thông Báo");
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvDSDL.DataSource = null;
            DaiLyBUS.Instance.GetAll(dgvDSDL);
            dgvDSDL.Columns[0].HeaderCell.Value = "Mã ĐL";
            dgvDSDL.Columns[1].HeaderCell.Value = "Tên đại lý";
            dgvDSDL.Columns[2].HeaderCell.Value = "Điện thoại";
            dgvDSDL.Columns[3].HeaderCell.Value = "Địa chỉ";
            dgvDSDL.Columns[4].HeaderCell.Value = "Ngày tiếp nhận";
            dgvDSDL.Columns[5].HeaderCell.Value = "Email";
            dgvDSDL.Columns[6].HeaderCell.Value = "Tiền nợ";
            dgvDSDL.Columns[7].HeaderCell.Value = "Mã Loại ĐL";
            dgvDSDL.Columns[8].HeaderCell.Value = "Mã Quận";
        }
    }
}
