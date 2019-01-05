using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    public class BaoCaoDoanhSoBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static BaoCaoDoanhSoBUS instance;
        public static BaoCaoDoanhSoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaoCaoDoanhSoBUS();
                }
                return instance;
            }
        }
        public BaoCaoDoanhSoBUS() { }

        //viết hàm
        public BAOCAODOANHSO GetByID(string MaDS)
        {
            return BaoCaoDoanhSoDAO.Instance.GetByID(MaDS);
        }
        //Updadte
        public bool Update(string MaDS, BAOCAODOANHSO ds)
        {
            return BaoCaoDoanhSoDAO.Instance.Update(MaDS, ds);
        }
        //tạo mã
        public string CreatCode()
        {
            return BaoCaoDoanhSoDAO.Instance.CreateCode();
        }
        //insert
        public bool Insert(int Thang)
        {
            string Ma = BaoCaoDoanhSoDAO.Instance.CreateCode();
            BAOCAODOANHSO temp = new BAOCAODOANHSO();
            temp.MaBaoCaoDoanhSo = Ma;
            temp.Thang = Thang;
            

            return BaoCaoDoanhSoDAO.Instance.Insert(temp);
        }
    }
}
