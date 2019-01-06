using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }

        private TaiKhoanDAO() { }
        /////////////
        public TAIKHOAN GetByID(string tenTK)
        {
            TAIKHOAN temp;
            QLDLDataContext db = new QLDLDataContext();
            temp = db.TAIKHOANs.Where(p => p.TenTaiKhoan == tenTK).FirstOrDefault();
            return temp;
        }
    }
}
