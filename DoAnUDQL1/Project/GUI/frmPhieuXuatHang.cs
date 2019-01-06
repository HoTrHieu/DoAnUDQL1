using System;
using System.Collections;
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
            dgvPhieuXuatHang.DefaultCellStyle.ForeColor = Color.Black;
            cmbDaiLy.DataSource = DaiLyBUS.Instance.GetAll().Select(p => p.MaDaiLy).ToList();
            dtPK.Format = DateTimePickerFormat.Custom;
            dtPK.CustomFormat = "dd-MM-yyyy";
            dtPK.Value = DateTime.Today;

            cmbMaMatHang.DataSource = MatHangBUS.Instance.GetAll().Select(p => p.MaMatHang).ToList();

            cmbDonViTinh.DataSource = DonViTinhBUS.Instance.GetAll().Select(p => p.MaDonViTinh).ToList();

           // MatHangBUS.Instance.GetAllID(dgvPhieuXuatHang);
        }

        private void cmbDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenDL.Text = DaiLyBUS.Instance.GetByID(cmbDaiLy.Text).TenDaiLy;

        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            string maPXNew = PhieuXuatHangBUS.Instance.CreatCode();
            DateTime ngayLap = dtPK.Value;

            string maDL = cmbDaiLy.SelectedValue.ToString();
            string maMH = cmbMaMatHang.SelectedValue.ToString();
            int maDVT = int.Parse(cmbDonViTinh.SelectedValue.ToString());
            int soLuong = int.Parse(txtSoLuong.Text);
            int donGia = int.Parse(MatHangBUS.Instance.GetByID(maMH).DonGia.ToString());
            int thanhTien = soLuong * donGia;

            if(PhieuXuatHangBUS.Instance.Insert(ngayLap, 0, maDL))
            {
                if(PhieuXuat_MatHangBUS.Instance.Insert(maPXNew,maMH, soLuong, thanhTien, maDVT)){
                    MessageBox.Show("Thêm Phiếu Xuất Hàng Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm Phiếu Xuất Hàng Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
            }
            else
            {
                MessageBox.Show("Thêm Phiếu Xuất Hàng Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }



            //MessageBox.Show(maPXNew + "\n" + ngayLap + "\n" + maDL);
        }

        private void cmbMaMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenMatHang.Text = MatHangBUS.Instance.GetByID(cmbMaMatHang.Text).TenMatHang;
        }
    }
}
