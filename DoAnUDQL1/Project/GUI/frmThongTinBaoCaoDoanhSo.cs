using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BUS;
using Project.DAO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project.GUI
{
    public partial class frmThongTinBaoCaoDoanhSo : Form
    {
        public frmThongTinBaoCaoDoanhSo()
        {
            InitializeComponent();
            dgvDoanhSo.Columns.Add("STT", "STT");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinBaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i.ToString());
            }
            cmbThang.SelectedIndex = 0;
            dgvDoanhSo.DefaultCellStyle.ForeColor = Color.Black;

            dgvDoanhSo.Columns[1].HeaderCell.Value = "Tên Đại Lý";
            dgvDoanhSo.Columns[2].HeaderCell.Value = "Số Phiếu Xuất";
            dgvDoanhSo.Columns[3].HeaderCell.Value = "Tổng Trị Giá";
            dgvDoanhSo.Columns[4].HeaderCell.Value = "Tỷ Lệ";

        }

        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            DoanhSo_DaiLyBUS.Instance.GetAll(dgvDoanhSo);
        }

        private void cmbThang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int thang = cmbThang.SelectedIndex + 1;
            //dgvDoanhSo.Rows.Clear();
            DoanhSo_DaiLyBUS.Instance.GetByThang(dgvDoanhSo, thang);
            if (dgvDoanhSo.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin Báo cáo doanh số trong tháng " + thang, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInDoanhSo_Click_1(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "BaoCaoDoanhSo";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvDoanhSo.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDoanhSo.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvDoanhSo.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvDoanhSo.Rows[i].Cells[j].Value.ToString();
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
                    MessageBox.Show("Xuất Thông Tin Báo Cáo Doanh Số Thành Công");
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
