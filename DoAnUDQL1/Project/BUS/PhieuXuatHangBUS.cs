using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class PhieuXuatHangBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static PhieuXuatHangBUS instance;
        public static PhieuXuatHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuXuatHangBUS();
                }
                return instance;
            }
        }
        public PhieuXuatHangBUS() { }
        //viết function
        // dai ly co định nên k cần insert và update
        public PHIEUXUATHANG GetByID(string maPX)
        {
            return PhieuXuatHangDAO.Instance.GetByID(maPX);
        }

        //tạo mã
        public string CreatCode()
        {
            return PhieuXuatHangDAO.Instance.CreateCode();
        }

        //insert
        public bool Insert(DateTime ngayLapPhieu, int tongTien, string maDL)
        {
            string maPX = PhieuXuatHangDAO.Instance.CreateCode();
            PHIEUXUATHANG temp = new PHIEUXUATHANG();
            temp.MaPhieuXuat = maPX;
            temp.NgayLapPhieu = ngayLapPhieu;
            temp.TongTien = tongTien;
            temp.MaDaiLy = maDL;


            return PhieuXuatHangDAO.Instance.Insert(temp);
        }

        //Updadte
        public bool Update(string maPX, PHIEUXUATHANG px)
        {
            return PhieuXuatHangDAO.Instance.Update(maPX, px);
        }
    }
}
