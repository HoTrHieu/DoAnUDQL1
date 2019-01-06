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

        public List<DONVITINH> GetAll()
        {
            List<DONVITINH> lstDL = new List<DONVITINH>();
            using (QLDLDataContext db = new QLDLDataContext())
            {
                lstDL = db.DONVITINHs.Select(p => p).ToList();
            }

            return lstDL;
        }

        public void GetByID(int MaDVT, DataGridView data)
        {

            QLDLDataContext db = new QLDLDataContext();

            data.DataSource = db.DONVITINHs.Where(p => p.MaDonViTinh == MaDVT).ToList();


        }

    }
}
