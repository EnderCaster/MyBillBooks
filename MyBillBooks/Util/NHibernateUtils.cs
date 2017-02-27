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
        
        //我用UserDATA这个类储存数据库相关的信息，为了保证隐私，没有上传至git，此处请注意修改
        static string connString = "server=" + UserDATA.DATABASE_ADDRESS + ";database=" + UserDATA.DATABASE_NAME + ";User ID=" + UserDATA.DATABASE_USER + ";Password=" + UserDATA.DATABASE_PASSWORD+";Charset=utf8";
        static private Configuration config = new Configuration();
        static private ISessionFactory sessionFactory = null;
        static ThreadLocal<ISession> threadLocal = new ThreadLocal<ISession>();
        static NHibernateUtils() {
            initSessionFactory();
        }
        static private void initSessionFactory()
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
            if (session==null || !session.IsOpen)
            {
                if (session != null)
                {
                    session.Close();
                }
                session = sessionFactory.OpenSession();
                threadLocal.Value = session;
            }
            return session;
        }

        
    }
}
