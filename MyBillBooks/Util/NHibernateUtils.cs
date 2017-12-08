using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml;


namespace MyBillBooks.Util
{
    class NHibernateUtils
    {
        static private Configuration config = new Configuration();
        static private ISessionFactory sessionFactory = null;
        static ThreadLocal<ISession> threadLocal = new ThreadLocal<ISession>();
        static public void InitSessionFactory()
        {
            config.Configure();
            IDictionary<string, string> property = new Dictionary<string, string>();
            XmlDocument connectionData = new XmlDocument();
            connectionData.Load("Data\\UserInfomation.xml");
            string connString = "server="+ connectionData.DocumentElement["host"].InnerText  + ";Port=" + connectionData.DocumentElement["port"].InnerText + ";database=" + connectionData.DocumentElement["database"].InnerText + ";User ID=" + connectionData.DocumentElement["username"].InnerText + ";Password=" + connectionData.DocumentElement["password"].InnerText + ";Charset=utf8";
            Console.Write(connString);
            property.Add("connection.connection_string", connString);
            config.AddProperties(property);
            try
            {
                sessionFactory = config.BuildSessionFactory();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
            catch (Exception e)
            {
                Log.exceptionLog(e);
                sessionFactory = null;
            }
        }
        
        static public ISession GetCurrentSession()
        {
            if (sessionFactory == null)
            {
                InitSessionFactory();
            }
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
        static public void ReleaseSessionFactory()
        {
            if(sessionFactory!=null && !sessionFactory.IsClosed)
            {
                sessionFactory.Close();
                sessionFactory.Dispose();
            }
        }

        
    }
}
