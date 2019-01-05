using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class LoaiDaiLyBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static LoaiDaiLyBUS instance;
        public static LoaiDaiLyBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiDaiLyBUS();
                }
                return instance;
            }
        }
        public LoaiDaiLyBUS() { }
        //viết function
        // loai dai ly co định nên k cần insert và update
        public LOAIDAILY  GetByID(int MaL)
        {
            return LoaiDaiLyDAO.Instance.GetByID(MaL);
        }

        public List<LOAIDAILY> GetAll()
        {
            return LoaiDaiLyDAO.Instance.GetAll();
        }

    }
}
