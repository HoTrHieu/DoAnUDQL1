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
            //MessageBox.Show(ma);

           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTiepNhanDaiLy_Load(object sender, EventArgs e)
        {
            cmbQuan.DataSource = QuanBUS.Instance.GetAll();
            cmbQuan.DisplayMember = "TenQuan";
            cmbQuan.ValueMember = "MaQuan";

            cmbLoaiDaiLy.DataSource = LoaiDaiLyBUS.Instance.GetAll();
            cmbLoaiDaiLy.DisplayMember = "TenLoaiDaiLy";
            cmbLoaiDaiLy.ValueMember = "MaLoaiDaiLy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string maDL = DaiLyBUS.Instance.CreatCode();
            string tenDL = txtTenDaiLy.Text;
            string dienThoai = txtDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            string tmp = dtpNgayTiepNhan.Value.ToString();
            DateTime ngayTiepNhan = DateTime.Parse(tmp);

            string email = txtEmail.Text;
            int tienNo = 0;
            int maLoaiDaiLy = (int)cmbLoaiDaiLy.SelectedValue;
            string maQuan = cmbQuan.SelectedValue.ToString();

            int soDaiLyDaCo = DaiLyBUS.Instance.demSoDaiLyTrongQuan(maQuan);
            int soDaiLyChoPhep = int.Parse(ThamSoBUS.Instance.GetAll().SoDaiLyToiDaQuan.ToString());

            if (tenDL != "" || dienThoai != "" || diaChi != "")
            {
                if(soDaiLyDaCo >= soDaiLyChoPhep)
                {
                    MessageBox.Show("Quận " + maQuan.TrimEnd() + " đã đủ " + soDaiLyChoPhep + " đại lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (DaiLyBUS.Instance.Insert(tenDL, dienThoai, diaChi, DateTime.Now, email, tienNo, maLoaiDaiLy, maQuan))
                    {
                        MessageBox.Show("Tiếp nhận đại lý thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tiếp nhận đại lý không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //MessageBox.Show("MaDL : " + maDL + "\nTen DL : " + tenDL + "\nDien thoai : " + dienThoai +
            //    "\nDia chi : " + diaChi + "\nNgay tiep nhan : " + ngayTiepNhan + "\nEmail : " + email +
            //    "\nTien no : " + tienNo + "\nMa Loai Dai Ly : " + maLoaiDaiLy + "\nMa Quan : " + maQuan);


        }
    }
}
