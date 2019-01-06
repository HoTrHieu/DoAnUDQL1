using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    public class PhieuXuat_MatHangDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static PhieuXuat_MatHangDAO instance;
        public static PhieuXuat_MatHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuXuat_MatHangDAO();
                }
                return instance;
            }
        }
        private PhieuXuat_MatHangDAO() { }
        // viết các hàm cần thiết
        public PHIEUXUAT_MATHANG GetByID(string maMH, string maPX)
        {
            PHIEUXUAT_MATHANG temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.PHIEUXUAT_MATHANGs.Where(p => p.MaPhieuXuat == maPX && p.MaMatHang == maMH).FirstOrDefault();
            }
            return temp;
        }

        //insert
        public bool Insert(string maPX, string maMH, int soLuong, int thanhTien, int maDVT)
        {
            PHIEUXUAT_MATHANG px = new PHIEUXUAT_MATHANG();
            px.MaPhieuXuat = maPX;
            px.MaMatHang = maMH;
            px.SoLuong = soLuong;
            px.ThanhTien = thanhTien;
            px.MaDonViTinh = maDVT;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.PHIEUXUAT_MATHANGs.InsertOnSubmit(px);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
