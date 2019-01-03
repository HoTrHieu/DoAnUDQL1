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
            BaoCaoCongNoBUS x = new BaoCaoCongNoBUS();
            string ma = x.CreatCode();
            MessageBox.Show(ma);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
