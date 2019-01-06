using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAO;

namespace Project.BUS
{
    public class DaiLyBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static DaiLyBUS instance;
        public static DaiLyBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DaiLyBUS();
                }
                return instance;
            }
        }
        public DaiLyBUS() { }
        //viết function
        // dai ly co định nên k cần insert và update
        public DAILY GetByID(string MaDL)
        {
            return DaiLyDAO.Instance.GetByID(MaDL);
        }

        public void GetAll(DataGridView dgv)
        {
            DaiLyDAO.Instance.GetAll(dgv);
        }

        //tạo mã
        public string CreatCode()
        {
            return DaiLyDAO.Instance.CreateCode();
        }

        //insert
        public bool Insert(string tenDaiLy, string sdt, string diaChi, DateTime ngayTiepNhan, string email, int tienNo, int maLDL, string maQuan)
        {
            string maDL = DaiLyDAO.Instance.CreateCode();
            DAILY temp = new DAILY();
            temp.MaDaiLy = maDL;
            temp.TenDaiLy = tenDaiLy;
            temp.DienThoai = sdt;
            temp.DiaChi = diaChi;
            temp.NgayTiepNhan = ngayTiepNhan;
            temp.Email = email;
            temp.TienNo = tienNo;
            temp.MaLoaiDaiLy = maLDL;
            temp.MaQuan = maQuan;

            return DaiLyDAO.Instance.Insert(temp);
        }

        //Updadte
        public bool Update(string MaDL, DAILY dl)
        {
            return DaiLyDAO.Instance.Update(MaDL, dl);
        }

        public int demSoDaiLyTrongQuan(string maQuan)
        {
            return DaiLyDAO.Instance.demSoDaiLyTrongQuan(maQuan);
        }

        public bool Delete(string maDL)
        {
            return DaiLyDAO.Instance.Delete(maDL);
        }

        //get allDaily
        public List<DAILY> GetAll()
        {
            return DaiLyDAO.Instance.GetAll();
        }


        public void GetByID(string MaDL, DataGridView data)
        {
            DaiLyDAO.Instance.GetByID(MaDL, data);
        }

    }
}
