using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void btnThemDaiLy_Click(object sender, EventArgs e)
        {
            frmTiepNhanDaiLy themDaiLy = new frmTiepNhanDaiLy();
            themDaiLy.ShowDialog();
        }

        private void btnPhieuThuTien_Click(object sender, EventArgs e)
        {
            frmPhieuThuTien phieuThuTien = new frmPhieuThuTien();
            phieuThuTien.ShowDialog();
        }

        private void btnPhieuXuatHang_Click(object sender, EventArgs e)
        {
            frmPhieuXuatHang phieuXuatHang = new frmPhieuXuatHang();
            phieuXuatHang.ShowDialog();
        }

        private void btnThongKeMatHang_Click(object sender, EventArgs e)
        {
            frmThongKeMatHang thongKeMatHang = new frmThongKeMatHang();
            thongKeMatHang.ShowDialog();
        }

        private void btnBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            frmThongTinBaoCaoCongNoDaiLy baoCaoCongNoDaiLy = new frmThongTinBaoCaoCongNoDaiLy();
            baoCaoCongNoDaiLy.ShowDialog();
        }

        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            frmThongTinBaoCaoDoanhSo baoCaoDoanhSo = new frmThongTinBaoCaoDoanhSo();
            baoCaoDoanhSo.ShowDialog();
        }

        private void btnCapNhatThamSo_Click(object sender, EventArgs e)
        {
            frmCapNhatThamSo capNhatThamSo = new frmCapNhatThamSo();
            capNhatThamSo.ShowDialog();
        }

        private void btnDSDL_Click(object sender, EventArgs e)
        {
            frmDanhSachDaiLy dsdl = new frmDanhSachDaiLy();
            dsdl.ShowDialog();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
