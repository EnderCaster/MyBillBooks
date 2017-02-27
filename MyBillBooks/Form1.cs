using System;
using System.Windows.Forms;

namespace MyBillBooks
{
    public partial class Form_MayBeAFakeForm : Form
    {
        public Form_MayBeAFakeForm()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            ItemInsertForm iif = new ItemInsertForm();
            iif.Show();
        }

        private void button_SelectItem_Click(object sender, EventArgs e)
        {
            ItemSelectForm isf = new ItemSelectForm();
            isf.Show();
        }
    }
}
