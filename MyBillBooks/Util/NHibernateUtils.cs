using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace MyBillBooks.Util
{
    class NHibernateUtils
    {
        
        //I use a class to store database information, but leave it out of git, to protect private
        static string connString = "server=" + UserDATA.DATABASE_ADDRESS + ";database=" + UserDATA.DATABASE_NAME + ";User ID=" + UserDATA.DATABASE_USER + ";Password=" + UserDATA.DATABASE_PASSWORD+";Charset=utf8";
        static private Configuration config = new Configuration();
        static private ISessionFactory sessionFactory = null;
        static ThreadLocal<ISession> threadLocal = new ThreadLocal<ISession>();
        static NHibernateUtils() {
            initSessionary();
        }
        static private void initSessionary()
        {
            config.Configure();
            IDictionary<string, string> property = new Dictionary<string, string>();
            property.Add("connection.connection_string", connString);
            config.AddProperties(property);
            sessionFactory = config.BuildSessionFactory();
        }
        
        static public ISession getCurrentSession()
        {
            ISession session = threadLocal.Value;
            if (session==null)
            {
                session = sessionFactory.OpenSession();
                Console.WriteLine("Test1");

                threadLocal.Value = session;
            }
            return session;
        }

        
    }
}
