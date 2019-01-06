using Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.BUS
{
    class MatHangBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static MatHangBUS instance;
        public static MatHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MatHangBUS();
                }
                return instance;
            }
        }

        public MATHANG GetByID(string MaMH)
        {
            return MatHangDAO.Instance.getById(MaMH);
        }

        public void GetAll(DataGridView dgv)
        {
            MatHangDAO.Instance.getAl(dgv);
        }

        public string CreatCode()
        {
            return MatHangDAO.Instance.CreateCode();
        }

        public void Insert(string TenMatHang, int SoLuongTon, int DonGia)
        {
            string MaMH = MatHangDAO.Instance.CreateCode();
            MATHANG mh = new MATHANG();
            mh.TenMatHang = TenMatHang;
            mh.SoLuongTon = SoLuongTon;
            mh.DonGia = DonGia;

            MatHangDAO.Instance.Insert(mh);
        }

        public void Update(string MaMH, MATHANG mh)
        {
            MatHangDAO.Instance.Update(MaMH, mh);
        }

        //
        public void GetByIDFD(string id, DataGridView data)
        {
            MatHangDAO.Instance.GetByIDFD(id, data);
        }
    }
}
