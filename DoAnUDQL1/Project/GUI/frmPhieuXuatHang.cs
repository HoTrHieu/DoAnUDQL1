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
    public partial class frmPhieuXuatHang : Form
    {
        public frmPhieuXuatHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhieuXuatHang_Load(object sender, EventArgs e)
        {
            cmbDaiLy.DataSource= DaiLyBUS.Instance.GetAll().Select(p => p.MaDaiLy).ToList();
            dtPK.Format = DateTimePickerFormat.Custom;
            dtPK.CustomFormat = "dd-MM-yyyy";
            dtPK.Value = DateTime.Today;

        }

        private void cmbDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenDL.Text = DaiLyBUS.Instance.GetByID(cmbDaiLy.Text).TenDaiLy;

        }
    }
}
