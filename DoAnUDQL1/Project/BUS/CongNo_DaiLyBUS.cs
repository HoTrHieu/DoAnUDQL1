using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;

namespace Project.BUS
{
    class CongNo_DaiLyBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static CongNo_DaiLyBUS instance;
        public static CongNo_DaiLyBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CongNo_DaiLyBUS();
                }
                return instance;
            }
        }
        public CongNo_DaiLyBUS() { }
        // viết các hàm cần thiết
        public CONGNO_DAILY GetByID(string MaCN, string MaDL)
        {
            return CongNo_DaiLyDAO.Instance.GetByID(MaCN,MaDL);
        }
        //Updadte
        public bool Update(string MaCN,string MaDL, CONGNO_DAILY cn)
        {
            return CongNo_DaiLyDAO.Instance.Update(MaCN,MaDL, cn);
        }
        //Mã tự phát sinh       
        //insert
        public bool Insert(string MaCN, string MaDL,int NoDau, int PSinh, int NoCuoi)
        {
            CONGNO_DAILY temp = new CONGNO_DAILY();
            temp.MaBaoCaoCongNo = MaCN;
            temp.MaDaiLy = MaDL;          
            temp.NoDau = NoDau;
            temp.PhatSinh = PSinh;
            temp.NoCuoi = NoCuoi;
           
            return CongNo_DaiLyDAO.Instance.Insert(temp);
        }
    }
}
