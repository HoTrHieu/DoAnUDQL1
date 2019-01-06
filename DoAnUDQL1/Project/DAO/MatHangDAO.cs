using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    class MatHangDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static MatHangDAO instance;

        public static MatHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MatHangDAO();
                }
                return instance;
            }
        }

        public void getAl(DataGridView dgv)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var query = db.MATHANGs.Select(i => i).ToList();

                dgv.DataSource = query;
            }
        }

        public MATHANG getById(string id)
        {
            MATHANG item;

            QLDLDataContext db = new QLDLDataContext();
            
            item = db.MATHANGs.Where(i => i.MaMatHang == id).FirstOrDefault();
            

            return item;
        }

        public string CreateCode()
        {
            string MaMH;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                List<string> lstMa = db.MATHANGs.Select(p => p.MaMatHang.Trim()).ToList();
                MaMH = lstMa[0];
                foreach (string temp in lstMa)
                {
                    if (temp.Length > MaMH.Length)
                    {
                        MaMH = temp;
                    }
                    else if (temp.Length == MaMH.Length)
                    {
                        if (String.Compare(temp.Substring(2, temp.Length - 2), MaMH.Substring(2, MaMH.Length - 2)) > 0)
                        {
                            MaMH = temp;
                        }
                    }
                }
                MaMH = MaMH.TrimEnd();
                string x = MaMH.Substring(2);
                string y = (int.Parse(x) + 1).ToString();
                MaMH = "MH" + y;
            }
            return MaMH;
        }

        public void Insert(MATHANG mh)
        {
            using(QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.MATHANGs.InsertOnSubmit(mh);
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void Update(string maMH, MATHANG mh)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    var item = db.MATHANGs.Where(i => i.MaMatHang == maMH).FirstOrDefault();

                    if (item != null)
                    {
                        item.TenMatHang = mh.TenMatHang;
                        item.DonGia = mh.DonGia;
                        item.SoLuongTon = mh.SoLuongTon;

                        db.SubmitChanges();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        //get by ID for datagridview
        public void GetByIDFD(string id,DataGridView data)
        {           
            QLDLDataContext db = new QLDLDataContext();
            data.DataSource = db.MATHANGs.Where(i => i.MaMatHang == id).ToList();            
        }

        public void GetAllID(DataGridView dgv)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var query = (from mh in db.MATHANGs
                            select new { maMH = mh.MaMatHang, tenMH = mh.TenMatHang }).ToList();

                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                //cmb.DataSource = query;

                cmb.HeaderText = "Mã Mặt Hàng";
                cmb.Name = "maMatHang";
                int i = 0;
                foreach (var item in query)
                {
                    cmb.Items.Add(item.maMH);
                }

                dgv.Columns.Insert(1, cmb);

            }
        }

        public List<MATHANG> GetAll()
        {
            List<MATHANG> lstDL = new List<MATHANG>();
            using (QLDLDataContext db = new QLDLDataContext())
            {
                lstDL = db.MATHANGs.Select(p => p).ToList();
            }

            return lstDL;
        }

        public void GetByID(string MaMH, DataGridView data)
        {

            QLDLDataContext db = new QLDLDataContext();

            data.DataSource = db.MATHANGs.Where(p => p.MaMatHang == MaMH).ToList();


        }
    }
}