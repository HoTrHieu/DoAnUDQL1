using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    public class DonViTinhDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static DonViTinhDAO instance;
        public static DonViTinhDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DonViTinhDAO();
                }
                return instance;
            }
        }

        public void GetAll(DataGridView dgv)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                
            }

        }
        public DONVITINH GetByID(string MaDL)
        {
            DONVITINH temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                
            }
            return temp;
        }

    }
}
