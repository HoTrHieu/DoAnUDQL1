using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAO;

namespace Project.BUS
{
    class DoanhSo_DaiLyBUS
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static DoanhSo_DaiLyBUS instance;
        public static DoanhSo_DaiLyBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoanhSo_DaiLyBUS();
                }
                return instance;
            }
        }
        public DoanhSo_DaiLyBUS() { }

        //viết hàm
        public DOANHSO_DAILY GetByID(string MaDS, string MaDL)
        {
            return DoanhSo_DaiLyDAO.Instance.GetByID(MaDS, MaDL);
        }
        //Updadte
        public bool Update(string MaDS, string MaDL, DOANHSO_DAILY ds)
        {
            return DoanhSo_DaiLyDAO.Instance.Update(MaDS, MaDL, ds);
        }
        //không cần tạo mã

        //insert
        public bool Insert(string MaDS, string MaDL, int SoPhieuX, int TongTG, int TyLe)
        {
            DOANHSO_DAILY temp = new DOANHSO_DAILY();
            temp.MaBaoCaoDoanhSo = MaDS;
            temp.MaDaiLy = MaDL;

            temp.SoPhieuXuat = SoPhieuX;
            temp.TongTriGia = TongTG;
            temp.TyLe = TyLe;

            return DoanhSo_DaiLyDAO.Instance.Insert(temp);
        }

        public void GetAll(DataGridView dgv)
        {

            DoanhSo_DaiLyDAO.Instance.GetAll(dgv);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void GetByThang(DataGridView dgv, int thang)
        {
            DoanhSo_DaiLyDAO.Instance.GetByThang(dgv, thang);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
