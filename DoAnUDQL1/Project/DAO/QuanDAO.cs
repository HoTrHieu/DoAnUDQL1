using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BUS;

namespace Project.DAO
{
    public class QuanDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static QuanDAO instance;
        public static QuanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanDAO();
                }
                return instance;
            }
        }
        private QuanDAO() { }

        //lấy dữ liệu từ CSDL
        public QUAN GetByID(string MaQ)
        {
            QUAN temp;
            using(QLDLDataContext db =new QLDLDataContext())
            {
                temp = db.QUANs.First(p => p.MaQuan == MaQ);
            }
            return temp;
        }

        //update by ID
        public bool Update(string MaQ,QUAN q)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                QUAN temp = db.QUANs.Where(p => p.MaQuan == MaQ).SingleOrDefault();
                temp.TenQuan = q.TenQuan;
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

        public List<QUAN> GetAll()
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var query = db.QUANs.Select(q => q).ToList();
                return query;
            }
        }
    }
}
