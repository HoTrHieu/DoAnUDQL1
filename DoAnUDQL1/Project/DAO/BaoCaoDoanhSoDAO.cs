using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    class BaoCaoDoanhSoDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static BaoCaoDoanhSoDAO instance;
        public static BaoCaoDoanhSoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaoCaoDoanhSoDAO();
                }
                return instance;
            }
        }
        private BaoCaoDoanhSoDAO() { }
        // viết các hàm cần thiết
        public BAOCAODOANHSO GetByID(string MaDS)
        {
            BAOCAODOANHSO temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.BAOCAODOANHSOs.Where(p => p.MaBaoCaoDoanhSo == MaDS).FirstOrDefault();
            }
            return temp;
        }
        //update
        public bool Update(string MaDS, BAOCAODOANHSO ds)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                BAOCAODOANHSO temp = db.BAOCAODOANHSOs.Where(p => p.MaBaoCaoDoanhSo == MaDS).FirstOrDefault();
                temp.Thang = ds.Thang;
                
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
        //Create Code
        public string CreateCode()
        {
            //select max(t.MaDangKy) as N'MaDangKy' from THONGTINDANGKY t where LEN(t.MaDangKy)" +
            //    ">= all(select len(x.MaDangKy) from THONGTINDANGKY x)"

            string Ma;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                List<string> lstMa = db.BAOCAODOANHSOs.Select(p => p.MaBaoCaoDoanhSo).ToList();
                Ma = lstMa[0];
                foreach (string temp in lstMa)
                {
                    if (temp.Length > Ma.Length || string.Compare(temp, Ma) == 1)
                    {
                        Ma = temp;
                    }
                }
                Ma = Ma.TrimEnd();
                string x = Ma.Substring(4);
                string y = (int.Parse(x) + 1).ToString();
                Ma = "BCDS" + y;
            }
            return Ma;
        }

        //insert
        public bool Insert(BAOCAODOANHSO ds)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.BAOCAODOANHSOs.InsertOnSubmit(ds);
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
