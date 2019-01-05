using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class PhieuThuTienBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static PhieuThuTienBUS instance;
        public static PhieuThuTienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuThuTienBUS();
                }
                return instance;
            }
        }
        public PhieuThuTienBUS() { }
        //viết function
        // dai ly co định nên k cần insert và update
        public PHIEUTHUTIEN GetByID(string maPT)
        {
            return PhieuThuTienDAO.Instance.GetByID(maPT);
        }

        //tạo mã
        public string CreatCode()
        {
            return PhieuThuTienDAO.Instance.CreateCode();
        }

        //insert
        public bool Insert(DateTime ngayThuTien, int soTienThu, string maDL)
        {
            string maPTT = PhieuThuTienDAO.Instance.CreateCode();
            PHIEUTHUTIEN temp = new PHIEUTHUTIEN();
            temp.MaPhieuThu = maPTT;
            temp.NgayThuTien = ngayThuTien;
            temp.SoTienThu = soTienThu;
            temp.MaDaiLy = maDL;


            return PhieuThuTienDAO.Instance.Insert(temp);
        }

        //Updadte
        public bool Update(string maPTT, PHIEUTHUTIEN ptt)
        {
            return PhieuThuTienDAO.Instance.Update(maPTT, ptt);
        }
    }
}
