using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class TaskCL : EventClass
    {
        public string delegateName;
        public TaskCL (string nameItem, string dateItem, string timeItem, string delegateName) : base(nameItem , dateItem, timeItem)
        {
            this.delegateName = delegateName;
        }


    }
}
