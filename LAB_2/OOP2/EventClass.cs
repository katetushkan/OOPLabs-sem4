using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class EventClass : InboxClass
    {
        public string dateItem;
        public string timeItem;
        public  EventClass (string nameItem, string dateItem, string timeItem ) : base (nameItem)
        {
            this.dateItem = dateItem;
            this.timeItem = timeItem;
        }

        public string SetDateItem (string date) 
        {
            dateItem = date;
            return dateItem;
        }

    }
}
