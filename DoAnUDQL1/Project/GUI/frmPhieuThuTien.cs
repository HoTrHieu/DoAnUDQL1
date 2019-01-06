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
    public partial class frmPhieuThuTien : Form
    {
        public frmPhieuThuTien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            //lấy cmbox mã đại lý
            cmbMaDL.DataSource = DaiLyBUS.Instance.GetAll().Select(p => p.MaDaiLy).ToList();
            //set ngay thu tien là hiện tai
            dTPK.Format = DateTimePickerFormat.Custom;
            dTPK.CustomFormat = "dd-MM-yyyy";
            dTPK.Value = DateTime.Today;


        }
        private void cmbMaDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lấy đại lý theo ID
            DAILY dl = DaiLyBUS.Instance.GetByID(cmbMaDL.Text);
            //gán các giá trị
            lbTenDaiLy.Text = dl.TenDaiLy;
            lblMail.Text = dl.MaDaiLy;
            lbSoDienThoai.Text = dl.DienThoai;
            lblDiaChi.Text = dl.DiaChi;


        }

        private void btnLuuPT_Click(object sender, EventArgs e)
        {
            //lưu phiếu thu xuống csdl
            int tien = int.Parse(txtTien.Text);            
            if(PhieuThuTienBUS.Instance.Insert(dTPK.Value, tien, cmbMaDL.Text))
            {
                MessageBox.Show("Đã Lưu Thông Tin thu tiền", "Thông Báo");
                btnLuuPT.Enabled = false;
                //cho phép in phiếu thu
                btnInPhieu.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không thể lưu thông tin thu tiền, kiểm tra lại", "Thông Báo");
            }
            
        }

        //chỉ cho phép nhập số
        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
