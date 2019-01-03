using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class LoaiDaiLyDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static LoaiDaiLyDAO instance;
        public static LoaiDaiLyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiDaiLyDAO();
                }
                return instance;
            }
        }
        private LoaiDaiLyDAO() { }
        // viết các hàm cần thiết
        public LOAIDAILY GetByID(int MaL)
        {
            LOAIDAILY temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.LOAIDAILies.Where(p => p.MaLoaiDaiLy == MaL).FirstOrDefault();
            }
            return temp;
        }
    }
}
