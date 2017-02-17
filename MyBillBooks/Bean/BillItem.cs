using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBillBooks.Bean
{
    class BillItem
    {
        private int id;
        private DateTime date;
        private string itemName;
        private double itemPrice;
        private string remark;

        public virtual int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }        

        public virtual DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public virtual string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public virtual double ItemPrice
        {
            get
            {
                return itemPrice;
            }

            set
            {
                itemPrice = value;
            }
        }

        public virtual string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }
    }
}
