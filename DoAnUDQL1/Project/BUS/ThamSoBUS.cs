using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class ThamSoBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static ThamSoBUS instance;
        public static ThamSoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThamSoBUS();
                }
                return instance;
            }
        }
        public ThamSoBUS() { }
        // viết các hàm cần thiết
        //Updadte
        public THAMSO GetAll()
        {
            return ThamSoDAO.Instance.GetAll();
        }
        public bool Update(int id, int soDLToiDa, int soMatHang, int soDVT)
        {
            return ThamSoDAO.Instance.Update(id, soDLToiDa, soMatHang, soDVT);
        }
    }
}
