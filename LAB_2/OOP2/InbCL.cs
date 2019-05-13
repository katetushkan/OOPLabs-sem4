using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class InboxClass
    {
        public string nameItem;

        public InboxClass(string nameItem)
        {
            this.nameItem = nameItem;
        }

        public string infoNameItem ()
        {
            return nameItem;
        }

    }
}
