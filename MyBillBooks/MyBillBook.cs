using MyBillBooks.Util;
using System;
using System.Windows.Forms;

namespace MyBillBooks
{
    public partial class Form_BillBook : Form
    {
        public Form_BillBook()
        {
            InitializeComponent();
            try
            {
                NHibernateUtils.InitSessionFactory();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            NHibernateUtils.ReleaseSessionFactory();
            Application.Exit();
        }

        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            ItemInsertForm iif = new ItemInsertForm();
            iif.Show();
        }

        private void Button_SelectItem_Click(object sender, EventArgs e)
        {
            ItemSelectForm isf = new ItemSelectForm();
            isf.Show();
        }
    }
}
