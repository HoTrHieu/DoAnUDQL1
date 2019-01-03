using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAO;
using Project.BUS;

namespace Project.GUI
{
    public partial class frmTiepNhanDaiLy : Form
    {
        public frmTiepNhanDaiLy()
        {
            InitializeComponent();
            QuanBUS a = new QuanBUS();
            QUAN x = a.GetByID("Q1");
            MessageBox.Show(x.MaQuan);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
