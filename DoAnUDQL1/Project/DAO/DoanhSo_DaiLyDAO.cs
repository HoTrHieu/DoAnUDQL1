using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    class DoanhSo_DaiLyDAO
    {
        //khởi tạo đối tượng khi gọi chỉ cần dùng toán tử . mà k cần khởi tạo biến
        private static DoanhSo_DaiLyDAO instance;
        public static DoanhSo_DaiLyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoanhSo_DaiLyDAO();
                }
                return instance;
            }
        }
        private DoanhSo_DaiLyDAO() { }
        // viết các hàm cần thiết
        public DOANHSO_DAILY GetByID(string MaDS, string MaDL)
        {
            DOANHSO_DAILY temp;
            using (QLDLDataContext db = new QLDLDataContext())
            {
                temp = db.DOANHSO_DAILies.Where(p => p.MaBaoCaoDoanhSo == MaDS && p.MaDaiLy == MaDL).FirstOrDefault();
            }
            return temp;
        }
        //update
        public bool Update(string MaDS, string MaDL, DOANHSO_DAILY ds)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                DOANHSO_DAILY temp = db.DOANHSO_DAILies.Where(p => p.MaBaoCaoDoanhSo == MaDS && p.MaDaiLy == MaDL).FirstOrDefault();

                temp.SoPhieuXuat = ds.SoPhieuXuat;
                temp.TongTriGia = ds.TongTriGia;
                temp.TyLe = ds.TyLe;

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        //không phải Create Code


        //insert
        public bool Insert(DOANHSO_DAILY ds)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                try
                {
                    db.DOANHSO_DAILies.InsertOnSubmit(ds);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public void GetAll(DataGridView dgv)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var sql = (from dl in db.DAILies
                           join dsdl in db.DOANHSO_DAILies on dl.MaDaiLy equals dsdl.MaDaiLy
                           join bcds in db.BAOCAODOANHSOs on dsdl.MaBaoCaoDoanhSo equals bcds.MaBaoCaoDoanhSo
                           select new
                           {
                               TenDL = dl.TenDaiLy,
                               soPhieuXuat = dsdl.SoPhieuXuat,
                               tongTriGia = dsdl.TongTriGia,
                               tyLe = dsdl.TyLe
                           }).ToList();

                dgv.DataSource = sql;

                //var sql = db.CONGNO_DAILies.Select(p => p).ToList();
                //dgv.DataSource = sql;

            }
        }

        public void GetByThang(DataGridView dgv, int thang)
        {
            using (QLDLDataContext db = new QLDLDataContext())
            {
                var sql = (from dl in db.DAILies
                           join dsdl in db.DOANHSO_DAILies on dl.MaDaiLy equals dsdl.MaDaiLy
                           join bcds in db.BAOCAODOANHSOs on dsdl.MaBaoCaoDoanhSo equals bcds.MaBaoCaoDoanhSo
                           where bcds.Thang == thang
                           select new
                           {
                               TenDL = dl.TenDaiLy,
                               soPhieuXuat = dsdl.SoPhieuXuat,
                               tongTriGia = dsdl.TongTriGia,
                               tyLe = dsdl.TyLe
                           }).ToList();

                dgv.DataSource = sql;
            }
        }
    }
}
