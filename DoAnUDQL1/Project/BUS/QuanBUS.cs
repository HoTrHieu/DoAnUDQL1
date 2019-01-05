using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class QuanBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static QuanBUS instance;
        public static QuanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanBUS();
                }
                return instance;
            }
        }
        public QuanBUS() { }
        //Note: quận k cần insert

        //GetByID
        public QUAN GetByID(string MaQ)
        {
            return QuanDAO.Instance.GetByID(MaQ);
        }
        //Update by ID
        public bool Update(string MaQ,QUAN q)
        {
            return QuanDAO.Instance.Update(MaQ, q);
        }

        public List<QUAN> GetAll()
        {
            return QuanDAO.Instance.GetAll();
        }

    }
}
