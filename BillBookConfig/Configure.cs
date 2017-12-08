using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BillBookConfig
{
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
            XmlDocument connectionData = new XmlDocument();
            if (File.Exists("Data\\UserInfomation.xml"))
            {
                connectionData.Load("Data\\UserInfomation.xml");
                hostTB.Text = connectionData.DocumentElement["host"].InnerText;
                usernameTB.Text = connectionData.DocumentElement["username"].InnerText;
                passwordTB.Text = connectionData.DocumentElement["password"].InnerText;
                portTB.Text = connectionData.DocumentElement["port"].InnerText;
                databaseTB.Text = connectionData.DocumentElement["database"].InnerText;
            }
            else
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                connectionData.LoadXml("<connection>  <host > localhost </host>  <port> 3306 </port>  <username> root </username>  <password> nothing </password>  <database> billBook </database></connection>");
                connectionData.Save("Data\\UserInfomation.xml");
            }
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            XmlDocument connectionData = new XmlDocument();
            connectionData.Load("Data\\UserInfomation.xml");
            connectionData.DocumentElement["host"].InnerText = hostTB.Text;
            connectionData.DocumentElement["username"].InnerText = usernameTB.Text;
            connectionData.DocumentElement["password"].InnerText = passwordTB.Text;
            connectionData.DocumentElement["port"].InnerText = portTB.Text;
            connectionData.DocumentElement["database"].InnerText = databaseTB.Text;
            connectionData.Save("Data\\UserInfomation.xml");
            Application.Exit();
        }
    }
}
