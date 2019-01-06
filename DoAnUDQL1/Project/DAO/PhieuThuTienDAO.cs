using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class PhieuThuTienDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static PhieuThuTienDAO instance;
        public static PhieuThuTienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuThuTienDAO();
                }
                return instance;
            }
        }
        private PhieuThuTienDAO() { }
        // viết các hàm cần thiết
        public PHIEUTHUTIEN GetByID(string MaDL)
        {
            PHIEUTHUTIEN temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.PHIEUTHUTIENs.Where(p => p.MaPhieuThu == MaDL).FirstOrDefault();
            }
            return temp;
        }

        public string CreateCode()
        {
            string MaPT;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                List<string> lstMa = db.PHIEUTHUTIENs.Select(p => p.MaPhieuThu).ToList();
                if (lstMa.Count == 0)
                {
                    return "PT1";
                }
                MaPT = lstMa[0];
                foreach (string temp in lstMa)
                {
                    if (temp.Length > MaPT.Length || string.Compare(temp, MaPT) == 1)
                    {
                        MaPT = temp;
                    }
                }
                MaPT = MaPT.TrimEnd();
                string x = MaPT.Substring(2);
                string y = (int.Parse(x) + 1).ToString();
                MaPT = "PT" + y;
            }
            return MaPT;
        }

        //insert
        public bool Insert(PHIEUTHUTIEN dl)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.PHIEUTHUTIENs.InsertOnSubmit(dl);
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
        public bool Update(string maPT, PHIEUTHUTIEN ptt)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                PHIEUTHUTIEN temp = db.PHIEUTHUTIENs.Where(p => p.MaPhieuThu == maPT).FirstOrDefault();
                temp.NgayThuTien = ptt.NgayThuTien;
                temp.SoTienThu = ptt.SoTienThu;
                temp.MaDaiLy = ptt.MaDaiLy;
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
    }
}
