using MyBillBooks.Bean;
using MyBillBooks.Dao;
using MyBillBooks.Util;
using NHibernate;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MyBillBooks.Service
{
    class BillItemService
    {
        static private BillItemDao billItemDao = new BillItemDao();
        public bool printMonthReport(DateTime date)
        {
            IList<BillItem> myBill = billItemDao.select(date, BillItemDao.SELECT_TYPE_MONTH);
            if (myBill == null)
            {
                return false;
            }
            else
            {
                //打印报表
                printReportToExcel(System.Windows.Forms.Application.StartupPath + date.Year + "年" + date.Month + "月报表.xlsx", myBill);
                return true;
            }
        }
        public bool printYearReport(DateTime date)
        {
            IList<BillItem> myBill = billItemDao.select(date, BillItemDao.SELECT_TYPE_YEAR);
            if (myBill == null)
            {
                return false;
            }
            else
            {
                //打印报表
                printReportToExcel(System.Windows.Forms.Application.StartupPath + date.Year + "年报表.xlsx", myBill);
                return true;
            }
        }
        public IList<BillItem> getDayBill(DateTime date)
        {
            return billItemDao.select(date, BillItemDao.SELECT_TYPE_DAY);
        }
        public bool saveNewBill(BillItem billItem)
        {
            try
            {
                ISession session = NHibernateUtils.getCurrentSession();
                ITransaction transaction = session.BeginTransaction();
                transaction.Begin();
                session.Save(billItem);
                transaction.Commit();
                return true;

            }
            catch (Exception e)
            {
                Random rand = new Random();
                byte[] errByte = System.Text.Encoding.UTF8.GetBytes(e.ToString());
                FileStream log = File.Create(DateTime.Now.ToLongDateString() + rand.Next().ToString() + ".log");
                log.Write(errByte, 0, errByte.Length);
                log.Flush();
                MessageBox.Show("Log file:" + log.Name);
                log.Close();
                return false;
            }
        }
        private void printReportToExcel(string filename, IList<BillItem> myBill)
        {
            Excel.Application reportApp = new Excel.Application();
            Excel.Workbooks reportBooks = reportApp.Workbooks;
            Excel.Workbook reportBook = reportBooks.Add(System.Reflection.Missing.Value);
            Excel.Sheets reportSheets = reportBook.Worksheets;
            Excel.Worksheet reportSheet = (Excel.Worksheet)reportSheets.Item[1];
            int rows = 2;//从第二行开始
            reportSheet.Cells[1, 1] = "日期";
            reportSheet.Cells[1, 2] = "消费项目";
            reportSheet.Cells[1, 3] = "价格（元）";
            reportSheet.Cells[1, 4] = "备注";
            while (rows - 1 <= myBill.Count)
            {
                reportSheet.Cells[rows, 1] = myBill[rows - 2].Date;
                reportSheet.Cells[rows, 2] = myBill[rows - 2].ItemName;
                reportSheet.Cells[rows, 3] = myBill[rows - 2].ItemPrice;
                reportSheet.Cells[rows, 4] = myBill[rows - 2].Remark;
                rows++;
            }
            reportSheet.Cells[rows, 2] = "合计：";
            reportSheet.Cells[rows, 3] = "=sum(C2:C" + (rows - 1) + ")";
            reportSheet.Rows.AutoFit();
            reportSheet.Columns.AutoFit();
            reportBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookDefault, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            reportBook.Close(true, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            reportApp.Quit();
            releaseObject(reportSheet);
            releaseObject(reportBook);
            releaseObject(reportApp);
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
