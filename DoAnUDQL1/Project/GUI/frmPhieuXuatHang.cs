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

        int index = 1;
        int TongT = 0;
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

            //
            btnThem.Enabled = false;
            btnInPhieu.Enabled = false;
            // MatHangBUS.Instance.GetAllID(dgvPhieuXuatHang);
            //dgvPhieuXuatHang.Columns[0].HeaderCell.Value = "Tên mặt hàng";
            //dgvPhieuXuatHang.Columns[1].HeaderCell.Value = "Đơn vị tính";
            //dgvPhieuXuatHang.Columns[2].HeaderCell.Value = "Số Lượng";
            //dgvPhieuXuatHang.Columns[3].HeaderCell.Value = "Đơn Giá";
            //dgvPhieuXuatHang.Columns[4].HeaderCell.Value = "Thành Tiền";
           }

        private void cmbDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenDL.Text = DaiLyBUS.Instance.GetByID(cmbDaiLy.Text).TenDaiLy;

        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            //xử lý nút
            btnInPhieu.Enabled = true;
            //xử lý xuất
            string maPXNew = PhieuXuatHangBUS.Instance.CreatCode();
            DateTime ngayLap = dtPK.Value;

            string maDL = cmbDaiLy.SelectedValue.ToString();
            
            if(PhieuXuatHangBUS.Instance.Insert(ngayLap, TongT, maDL))
            {
                for(int i = 0; i < index-1; i++)
                {
                    DataGridViewRow row = dgvPhieuXuatHang.Rows[i];
                    string maMH = row.Cells[1].Value.ToString();
                    int soLuong = int.Parse(row.Cells[4].Value.ToString());
                    int thanhTien = int.Parse(row.Cells[6].Value.ToString());
                    int maDVT = int.Parse(row.Cells[3].Value.ToString());
                    PhieuXuat_MatHangBUS.Instance.Insert(maPXNew, maMH, soLuong, thanhTien, maDVT);
                }
                //             
                MessageBox.Show("Thêm Phiếu Xuất Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                 
            }
            else
            {
                btnInPhieu.Enabled = false;
                MessageBox.Show("Thêm Phiếu Xuất Hàng Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }


            btnLuuPhieu.Enabled = false;
            //MessageBox.Show(maPXNew + "\n" + ngayLap + "\n" + maDL);
        }

        private void cmbMaMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenMatHang.Text = MatHangBUS.Instance.GetByID(cmbMaMatHang.Text).TenMatHang;
        }

        //in phiếu
        Bitmap bmp;
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width + 20, this.Size.Height + 10, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y - 10, 0, 0, this.Size);

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        //xử lý chọn
        private void btnChonMa_Click(object sender, EventArgs e)
        {
            cmbDaiLy.Enabled = false;
            MessageBox.Show("Bạn Đã Chọn Đại Lý Để Lập Phiếu Xuất Hàng", "Thông Báo");
            btnThem.Enabled = true;
            btnChonMa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                //lấy thông tin mat hang
                MATHANG mh = MatHangBUS.Instance.GetByID(cmbMaMatHang.Text);
                //thêm dòng vào datagriedview
                DataGridViewRow row = (DataGridViewRow)dgvPhieuXuatHang.Rows[0].Clone();
                row.Cells[0].Value = index.ToString();
                row.Cells[1].Value = cmbMaMatHang.Text;
                row.Cells[2].Value = lblTenMatHang.Text;
                row.Cells[3].Value = cmbDonViTinh.Text;
                row.Cells[4].Value = txtSoLuong.Text;
                row.Cells[5].Value = mh.DonGia;
                row.Cells[6].Value = (int.Parse(txtSoLuong.Text) * mh.DonGia).ToString();
                dgvPhieuXuatHang.Rows.Add(row);
                TongT += (int.Parse(txtSoLuong.Text) *(int) mh.DonGia);
                index++;
                lblTongTien.Text = TongT.ToString();
            }
            else
            {
                MessageBox.Show("Bạn Phải điền số lượng", "Thông báo");
            }
        }

        //chỉ cho phép nhập số
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {    
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);            
        }
    }
}
