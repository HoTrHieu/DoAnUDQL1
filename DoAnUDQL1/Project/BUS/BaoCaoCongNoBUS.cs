using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class BaoCaoCongNoBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static BaoCaoCongNoBUS instance;
        public static BaoCaoCongNoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaoCaoCongNoBUS();
                }
                return instance;
            }
        }
        public BaoCaoCongNoBUS() { }
        // viết các hàm cần thiết
        public BAOCAOCONGNO GetByID(string MaCN)
        {
            return BaoCaoCongNoDAO.Instance.GetByID(MaCN);
        }
        //Updadte
        public bool Update(string MaCN, BAOCAOCONGNO cn)
        {
            return BaoCaoCongNoDAO.Instance.Update(MaCN, cn);
        }
        //tạo mã
        public string CreatCode()
        {
            return BaoCaoCongNoDAO.Instance.CreateCode();
        }
        //insert
        public bool Insert(int Thang)
        {
            string Ma = BaoCaoCongNoDAO.Instance.CreateCode();
            BAOCAOCONGNO temp = new BAOCAOCONGNO();
            temp.MaBaoCaoCongNo = Ma;
            temp.Thang = Thang;

            return BaoCaoCongNoDAO.Instance.Insert(temp);
        }

        //
        public List<string> GetMaBaoCaoCongNoByThang(int Thang)
        {
            return BaoCaoCongNoDAO.Instance.GetMaBaoCaoCongNoByThang(Thang);
        }
    }
}
