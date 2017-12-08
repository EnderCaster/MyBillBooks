using MyBillBooks.Bean;
using MyBillBooks.Util;
using NHibernate;
using System;
using System.Collections.Generic;

namespace MyBillBooks.Dao
{
    class BillItemDao
    {
        public const int SELECT_TYPE_DAY = 1;
        public const int SELECT_TYPE_MONTH = 2;
        public const int SELECT_TYPE_YEAR = 3;
        public const double budget = 1200;

        public IList<BillItem> Select(DateTime date,int SELECT_TYPE)
        {
            switch (SELECT_TYPE)
            {
                case SELECT_TYPE_DAY:
                    return SelectByDay(date);
                case SELECT_TYPE_MONTH:
                    return SelectByMonth(date);
                case SELECT_TYPE_YEAR:
                    return SelectByYear(date);
                default:
                    return null;
            }
        }

        private IList<BillItem> SelectByYear(DateTime date)
        {
            ISession session = NHibernateUtils.GetCurrentSession();
            string hql = "from BillItem where year(date)=" + date.Year;
            IQuery query = session.CreateQuery(hql);
            return query.List<BillItem>();

        }

        private IList<BillItem> SelectByMonth(DateTime date)
        {
            ISession session = NHibernateUtils.GetCurrentSession();
            string hql = "from BillItem where year(date)=" + date.Year + " and month(date)=" + date.Month;
            IQuery query = session.CreateQuery(hql);
            return query.List<BillItem>();
        }

        private IList<BillItem> SelectByDay(DateTime date)
        {
            ISession session = NHibernateUtils.GetCurrentSession();
            string hql = "from BillItem where date='" + date.ToShortDateString()+"'";
            IQuery query = session.CreateQuery(hql);
            return query.List<BillItem>();
        }       
    }
}
