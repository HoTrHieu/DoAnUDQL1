using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class ThamSoDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static ThamSoDAO instance;
        public static ThamSoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThamSoDAO();
                }
                return instance;
            }
        }
        private ThamSoDAO() { }
        
        public THAMSO GetAll()
        {
            THAMSO temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.THAMSOs.Select(p=>p).FirstOrDefault();
            }
            return temp;
        }
        //update
        public bool Update(int id, int soDLToiDa, int soMatHang, int soDVT)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                THAMSO update = db.THAMSOs.Where(p=>p.ID == id).FirstOrDefault();

                update.SoDaiLyToiDaQuan = soDLToiDa;
                update.SoMatHang = soMatHang;
                update.SoDonViTinh = soDVT;
                db.SubmitChanges();

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
