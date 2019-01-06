using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    public class PhieuXuatHangDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static PhieuXuatHangDAO instance;
        public static PhieuXuatHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuXuatHangDAO();
                }
                return instance;
            }
        }
        private PhieuXuatHangDAO() { }
        // viết các hàm cần thiết
        public PHIEUXUATHANG GetByID(string MaDL)
        {
            PHIEUXUATHANG temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.PHIEUXUATHANGs.Where(p => p.MaPhieuXuat == MaDL).FirstOrDefault();
            }
            return temp;
        }

        public string CreateCode()
        {
            string MaPX;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                List<string> lstMa = db.PHIEUXUATHANGs.Select(p => p.MaPhieuXuat).ToList();
                MaPX = lstMa[0];
                foreach (string temp in lstMa)
                {
                    if (temp.Length > MaPX.Length || string.Compare(temp, MaPX) == 1)
                    {
                        MaPX = temp;
                    }
                }
                MaPX = MaPX.TrimEnd();
                string x = MaPX.Substring(2);
                string y = (int.Parse(x) + 1).ToString();
                MaPX = "PX" + y;
            }
            return MaPX;
        }

        //insert
        public bool Insert(PHIEUXUATHANG px)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.PHIEUXUATHANGs.InsertOnSubmit(px);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        //update
        public bool Update(string maPX, PHIEUXUATHANG px)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                PHIEUXUATHANG temp = db.PHIEUXUATHANGs.Where(p => p.MaPhieuXuat == maPX).FirstOrDefault();
                temp.NgayLapPhieu = px.NgayLapPhieu;
                temp.TongTien = px.TongTien;
                temp.MaDaiLy = px.MaDaiLy;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        //get data for dgv
        public void GetThongTinDGV(DataGridView data)
        {

        }
    }
}
