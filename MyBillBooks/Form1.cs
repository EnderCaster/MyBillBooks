using NHibernate.Cfg;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        
    }
}
