using MyBillBooks.Bean;
using MyBillBooks.Service;
using System;
using System.Windows.Forms;

namespace MyBillBooks
{
    public partial class ItemInsertForm : Form
    {

        public ItemInsertForm()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            BillItem billItem = new BillItem();
            string remark = "";
            foreach (string line in textBox_Remark.Lines)
            {
                remark += line;
                remark += Environment.NewLine;
            }

            if (checkPricePassed(billItem.ItemPrice))
            {
                billItem.ItemPrice = double.Parse(textBox_ItemPrice.Text);
                billItem.ItemName = textBox_ItemName.Text;
                billItem.Date = InsertDatePicker.Value;
                billItem.Remark = remark;
                BillItemService billItemService = new BillItemService();
                bool check =billItemService.saveNewBill(billItem);
                if (check)
                {
                    MessageBox.Show("录入成功");
                    reset();
                }
            }
            else
            {
                MessageBox.Show("请检查输入");
            }
        }

        private bool checkPricePassed(double itemPrice)
        {
            return double.TryParse(textBox_ItemPrice.Text, out itemPrice);
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            textBox_ItemName.Text = textBox_ItemPrice.Text = textBox_Remark.Text = "";
            textBox_ItemName.Focus();
        }
    }
}
