using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BUS;
using Project.DAO;

namespace Project.GUI
{
    public partial class frmThongTinBaoCaoCongNoDaiLy : Form
    {
        public frmThongTinBaoCaoCongNoDaiLy()
        {
            InitializeComponent();
        }

        private void frmThongTinBaoCaoCongNoDaiLy_Load(object sender, EventArgs e)
        {
            int[] iMangT = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cmbThang.DataSource = iMangT;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbThang_SelectedValueChanged(object sender, EventArgs e)
        {
            //lấy mã công nợ theo tháng from BaoCaoCongNo
            int Th = int.Parse(cmbThang.Text);


            cmbMaBaoCao.DataSource = BaoCaoCongNoBUS.Instance.GetMaBaoCaoCongNoByThang(Th);
            string MaCN = cmbMaBaoCao.Text;
            //liệt kê các đại lý tương ứng
            CongNo_DaiLyBUS.Instance.GetAllByMaCongNo(MaCN, dgvCongNo);
        }

        private void btnInCongNo_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "BaoCaoCongNo";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvCongNo.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvCongNo.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvCongNo.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvCongNo.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Xuất Thông Tin Báo Cáo Công Nợ Thành Công");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }
    }
}
