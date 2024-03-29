﻿using System;
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
    public partial class frmThongKeMatHang : Form
    {
        public frmThongKeMatHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeMatHang_Load(object sender, EventArgs e)
        {
            //đưa danh sách mặt hàng vào frm
            MatHangBUS.Instance.GetAll(dgvMatHang);
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ThongKeMatHang";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvMatHang.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvMatHang.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvMatHang.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvMatHang.Rows[i].Cells[j].Value.ToString();
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
                    MessageBox.Show("Xuất Thông Tin Mặt Hàng Thành Công");
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            MaMH = MaMH.TrimEnd();

            if (MaMH != "")
            {
                MATHANG temp = MatHangBUS.Instance.GetByID(MaMH);
                if (temp != null)
                {
                    MatHangBUS.Instance.GetByIDFD(MaMH, dgvMatHang);
                }
                else
                {
                    dgvMatHang.DataSource = null;
                    MessageBox.Show("Không Tìm Thấy Mặt Hàng", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Phải Điền Mã Mặt Hàng", "Thông Báo");
            }

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = null;
            MatHangBUS.Instance.GetAll(dgvMatHang);
        }
    }
}
