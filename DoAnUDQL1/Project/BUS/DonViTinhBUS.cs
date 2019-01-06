using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAO;

namespace Project.BUS
{
    public class DonViTinhBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static DonViTinhBUS instance;
        public static DonViTinhBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DonViTinhBUS();
                }
                return instance;
            }
        }

        public List<DONVITINH> GetAll()
        {
            return DonViTinhDAO.Instance.GetAll();
        }

        public void GetByID(int MaDVT, DataGridView data)
        {
            DonViTinhDAO.Instance.GetByID(MaDVT, data);
        }
    }
}
