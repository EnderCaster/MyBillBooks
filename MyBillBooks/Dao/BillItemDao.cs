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

        public IList<BillItem> select(DateTime date,int SELECT_TYPE)
        {
            switch (SELECT_TYPE)
            {
                case SELECT_TYPE_DAY:
                    return selectByDay(date);
                case SELECT_TYPE_MONTH:
                    return selectByMonth(date);
                case SELECT_TYPE_YEAR:
                    return selectByYear(date);
                default:
                    return null;
            }
        }

        private IList<BillItem> selectByYear(DateTime date)
        {
            ISession session = NHibernateUtils.getCurrentSession();
            string hql = "from BillItem where year(date)=" + date.Year;
            IQuery query = session.CreateQuery(hql);
            return query.List<BillItem>();

        }

        private IList<BillItem> selectByMonth(DateTime date)
        {
            ISession session = NHibernateUtils.getCurrentSession();
            string hql = "from BillItem where year(date)=" + date.Year + " and month(date)=" + date.Month;
            IQuery query = session.CreateQuery(hql);
            return query.List<BillItem>();
        }

        private IList<BillItem> selectByDay(DateTime date)
        {
            ISession session = NHibernateUtils.getCurrentSession();
            string hql = "from BillItem where date='" + date.ToShortDateString()+"'";
            IQuery query = session.CreateQuery(hql);
            return query.List<BillItem>();
        }
    }
}
