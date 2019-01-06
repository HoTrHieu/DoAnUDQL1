using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    class CongNo_DaiLyDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static CongNo_DaiLyDAO instance;
        public static CongNo_DaiLyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CongNo_DaiLyDAO();
                }
                return instance;
            }
        }
        private CongNo_DaiLyDAO() { }
        // viết các hàm cần thiết
        public CONGNO_DAILY GetByID(string MaCN, string MaDL)
        {
            CONGNO_DAILY temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.CONGNO_DAILies.Where(p => p.MaBaoCaoCongNo == MaCN && p.MaDaiLy == MaDL).FirstOrDefault();
            }
            return temp;
        }
        //update
        public bool Update(string MaCN, string MaDL, CONGNO_DAILY cn)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                CONGNO_DAILY temp = db.CONGNO_DAILies.Where(p => p.MaBaoCaoCongNo == MaCN && p.MaDaiLy == MaDL).FirstOrDefault();

                temp.NoDau = cn.NoDau;
                temp.PhatSinh = cn.PhatSinh;
                temp.NoCuoi = cn.NoCuoi;

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
        //không cần Create Code

        //insert
        public bool Insert(CONGNO_DAILY cn)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.CONGNO_DAILies.InsertOnSubmit(cn);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        //getAllByMaCN
        public void GetAllByMaCongNo(string MaCN, DataGridView data)
        {
            QLDLDataContext db = new QLDLDataContext();
            db.DeferredLoadingEnabled = false;
            data.DataSource = from u in db.CONGNO_DAILies
                              where u.MaBaoCaoCongNo == MaCN
                              select new
                              {
                                  MaDL = u.MaDaiLy,
                                  NoD = u.NoDau,
                                  PhatS = u.PhatSinh,
                                  NoC = u.NoCuoi
                              };
            //temp = db.CONGNO_DAILies.Where(p => p.MaBaoCaoCongNo == MaCN).ToList();         
        }
    }
}
