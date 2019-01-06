using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BUS;
using Project.DAO;

namespace Project.GUI
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        private TaiKhoanBUS() { }
        //getTK
        public TAIKHOAN GetByID(string tenTK)
        {
            return TaiKhoanDAO.Instance.GetByID(tenTK);
        }

        

    }
}
