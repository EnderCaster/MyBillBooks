using MyBillBooks.Bean;
using MyBillBooks.Util;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBillBooks
{
    class ClassForTestcs
    {
        public ClassForTestcs()
        {
            testFunc();
        }
        private void testFunc()
        {
            ISession session = NHibernateUtils.getCurrentSession();
            ITransaction ts = session.BeginTransaction();            
            BillItem billItem = new BillItem();
            billItem.Date = DateTime.Now;
            billItem.Id = 748;
            billItem.ItemName = "TestOBJ1";
            billItem.ItemPrice = 3.5;
            billItem.Remark = "null";
            session.Save(billItem);
            ts.Commit();
            if (ts != null)
            {
                ts.Dispose();
            }
            if (session != null && session.IsOpen)
            {
                session.Close();
                session.Dispose();
            }
        }
    }
}
