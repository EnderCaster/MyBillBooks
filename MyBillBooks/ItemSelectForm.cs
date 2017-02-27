using MyBillBooks.Bean;
using MyBillBooks.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyBillBooks
{
    public partial class ItemSelectForm : Form
    {
        private BillItemService billItemService = new BillItemService();
        public ItemSelectForm()
        {
            InitializeComponent();
            //根据年/月生成报表->打印图片
        }

        private void button_DaySelect_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            IList<BillItem> list = billItemService.getDayBill(SelectDatePicker.Value);
            foreach (BillItem billItem in list)
            {
                textBox_BillOfDay.Text += (billItem.ItemName + "\t" + billItem.ItemPrice + Environment.NewLine);
                sum += billItem.ItemPrice;
            }
            label_sumNumber.Text = sum + " 元";
        }

        private void button_MonthReport_Click(object sender, EventArgs e)
        {
            bool check=billItemService.printMonthReport(SelectDatePicker.Value);
            if (check)
            {
                MessageBox.Show("打印成功");
            }
        }

        private void button_YearReport_Click(object sender, EventArgs e)
        {
            bool check = billItemService.printYearReport(SelectDatePicker.Value);
            if (check)
            {
                MessageBox.Show("打印成功");
            }
        }
    }
}
