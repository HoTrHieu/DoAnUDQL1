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
    }
}
