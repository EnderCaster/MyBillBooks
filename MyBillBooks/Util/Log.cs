using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBillBooks.Util
{
    class Log
    {
        public static void exceptionLog(Exception e)
        {
            Random rand = new Random();
            byte[] errByte = Encoding.UTF8.GetBytes(e.ToString());
            FileStream log = File.Create(DateTime.Now.ToLongDateString() + rand.Next().ToString() + ".log");
            log.Write(errByte, 0, errByte.Length);
            log.Flush();
            MessageBox.Show("Log file:" + log.Name);
            log.Close();
        }
    }
}
