using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    public class PhieuXuat_MatHangBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static PhieuXuat_MatHangBUS instance;
        public static PhieuXuat_MatHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuXuat_MatHangBUS();
                }
                return instance;
            }
        }
        private PhieuXuat_MatHangBUS() { }
        // viết các hàm cần thiết
        public PHIEUXUAT_MATHANG GetByID(string maMH, string maPX)
        {
            PHIEUXUAT_MATHANG temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.PHIEUXUAT_MATHANGs.Where((p => p.MaMatHang == maMH && p.MaPhieuXuat == maPX )).FirstOrDefault();
            }
            return temp;
        }


        //insert
        public bool Insert(string maPX, string maMH, int soLuong, int thanhTien, int maDVT)
        {
            return PhieuXuat_MatHangDAO.Instance.Insert( maPX,  maMH,  soLuong,  thanhTien,  maDVT);
        }

        ////update
        //public bool Update(string maPX, string maMH, PHIEUXUAT_MATHANG px)
        //{
        //    using (QLDLDataContext db = new QLDLDataContext())
        //    {
        //        PHIEUXUAT_MATHANG temp = db.PHIEUXUAT_MATHANGs.Where(p => p.MaPhieuXuat == maPX && p.MaMatHang == maMH).FirstOrDefault();
        //        temp.S = px.NgayLapPhieu;
        //        temp.TongTien = px.TongTien;
        //        temp.MaDaiLy = px.MaDaiLy;
        //        try
        //        {
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }
        //}

        ////get data for dgv
        //public void GetThongTinDGV(DataGridView data)
        //{

        //}
    }
}
