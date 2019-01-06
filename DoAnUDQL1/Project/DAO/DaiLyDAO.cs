using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    public class DaiLyDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static DaiLyDAO instance;
        public static DaiLyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DaiLyDAO();
                }
                return instance;
            }
        }
        private DaiLyDAO() { }
        // viết các hàm cần thiết
        public DAILY GetByID(string MaDL)
        {
            DAILY temp;
            QLDLDataContext db = new QLDLDataContext();
            
                temp = db.DAILies.Where(p => p.MaDaiLy == MaDL).FirstOrDefault();
            
            return temp;
        }

        public void GetAll(DataGridView dgv )
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var sql = (from dl in db.DAILies
                           join q in db.QUANs on dl.MaQuan equals q.MaQuan
                           join ldt in db.LOAIDAILies on dl.MaLoaiDaiLy equals ldt.MaLoaiDaiLy
                           select new
                           {
                               MaDL = dl.MaDaiLy,
                               TenDL = dl.TenDaiLy,
                               DThoai = dl.DienThoai,
                               DChi = dl.DiaChi,
                               NTNhan = dl.NgayTiepNhan,
                               Eml = dl.Email,
                               STNo = dl.TienNo,
                               MaLDL = ldt.MaLoaiDaiLy,
                               MaQ = q.MaQuan
                           }).ToList();

                dgv.DataSource = sql;
            }
            
        }

        public string CreateCode()
        {
            string MaDL;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                List<string> lstMa = db.DAILies.Select(p => p.MaDaiLy.Trim()).ToList();
                MaDL = lstMa[0];
                foreach (string temp in lstMa)
                {
                    if(temp.Length > MaDL.Length)
                    {
                        MaDL = temp;
                    }
                    else if(temp.Length == MaDL.Length)
                    {
                        if(String.Compare(temp.Substring(2, temp.Length - 2), MaDL.Substring(2, MaDL.Length - 2)) > 0)
                        {
                            MaDL = temp;
                        }
                    }
                }
                MaDL = MaDL.TrimEnd();
                string x = MaDL.Substring(2);
                string y = (int.Parse(x) + 1).ToString();
                MaDL = "DL" + y;
            }
            return MaDL;
        }

        //insert
        public bool Insert(DAILY dl)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.DAILies.InsertOnSubmit(dl);
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
        public bool Update(string maDL, DAILY dl)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                DAILY temp = db.DAILies.Where(p => p.MaDaiLy == maDL).FirstOrDefault();
                temp.TenDaiLy = dl.TenDaiLy;
                temp.DienThoai = dl.DienThoai;
                temp.DiaChi = dl.DiaChi;
                temp.NgayTiepNhan = dl.NgayTiepNhan;
                temp.Email = dl.Email;
                temp.TienNo = dl.TienNo;
                temp.MaLoaiDaiLy = dl.MaLoaiDaiLy;
                temp.MaQuan = dl.MaQuan;
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

        public bool Delete(string maDL)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var query = db.DAILies.Single(dl => dl.MaDaiLy == maDL);
                try
                {
                    db.DAILies.DeleteOnSubmit(query);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public int demSoDaiLyTrongQuan(string maQuan)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                //var soLuong = from dl in db.DAILies
                //              where dl.MaQuan == maQuan
                //              group dl by dl.MaQuan into grouping
                //              select new
                //              {
                //                  count = grouping.Count()
                //            };
                //foreach (var temp in soLuong)
                //{
                //    result = temp.count;
                //}

                int count = (from x in db.DAILies where x.MaQuan == maQuan select x).Count();  // count: 2
                return count;
            }
            
        }


        //get alldaily
        public List<DAILY> GetAll()
        {
            List<DAILY> lstDL = new List<DAILY>();
            using(QLDLDataContext db=new QLDLDataContext())
            {
                lstDL = db.DAILies.Select(p => p).ToList();
            }

            return lstDL;
        }


        public void GetByID(string MaDL,DataGridView data)
        {
            
            QLDLDataContext db = new QLDLDataContext();

            data.DataSource = db.DAILies.Where(p => p.MaDaiLy == MaDL).ToList();

            
        }
    }
}
