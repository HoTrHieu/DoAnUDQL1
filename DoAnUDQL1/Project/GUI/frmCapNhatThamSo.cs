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

namespace Project.GUI
{
    public partial class frmCapNhatThamSo : Form
    {
        public frmCapNhatThamSo()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatThamSo_Load(object sender, EventArgs e)
        {
            txtSoDaiLy.Text = ThamSoBUS.Instance.GetAll().SoDaiLyToiDaQuan.ToString();
            txtSoDonViTinh.Text = ThamSoBUS.Instance.GetAll().SoDonViTinh.ToString();
            txtSoMatHang.Text = ThamSoBUS.Instance.GetAll().SoMatHang.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ThamSoBUS.Instance.GetAll().ID.ToString());
                if (ThamSoBUS.Instance.Update(id,int.Parse(txtSoDaiLy.Text), int.Parse(txtSoMatHang.Text), int.Parse(txtSoDonViTinh.Text)))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
