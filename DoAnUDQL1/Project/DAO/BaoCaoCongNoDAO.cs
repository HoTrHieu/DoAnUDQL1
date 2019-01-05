using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class BaoCaoCongNoDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static BaoCaoCongNoDAO instance;
        public static BaoCaoCongNoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaoCaoCongNoDAO();
                }
                return instance;
            }
        }
        private BaoCaoCongNoDAO() { }
        // viết các hàm cần thiết
        public BAOCAOCONGNO GetByID(string MaCN)
        {
            BAOCAOCONGNO temp;
            using(QLDLDataContext db =new QLDLDataContext())
            {
                temp = db.BAOCAOCONGNOs.Where(p => p.MaBaoCaoCongNo == MaCN).FirstOrDefault();
            }
            return temp;
        }
        //update
        public bool Update(string MaCN,BAOCAOCONGNO cn)
        {
            using(QLDLDataContext db=new QLDLDataContext())
            {
                BAOCAOCONGNO temp = db.BAOCAOCONGNOs.Where(p => p.MaBaoCaoCongNo == MaCN).FirstOrDefault();
                temp.Thang = cn.Thang;
                
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
            using(QLDLDataContext db=new QLDLDataContext())
            {
                List<string> lstMa = db.BAOCAOCONGNOs.Select(p => p.MaBaoCaoCongNo).ToList();
                Ma = lstMa[0];
                foreach(string temp in lstMa)
                {
                    if(temp.Length>Ma.Length || string.Compare(temp,Ma)==1)
                    {
                        Ma = temp;
                    }
                }
                Ma = Ma.TrimEnd();
                string x = Ma.Substring(4);
                string y = (int.Parse(x) + 1).ToString();
                Ma = "BCCN" + y;
            }
            return Ma;
        }

        //insert
        public bool Insert(BAOCAOCONGNO cn)
        {
            using(QLDLDataContext db=new QLDLDataContext())
            {
                try
                {
                    db.BAOCAOCONGNOs.InsertOnSubmit(cn);
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
