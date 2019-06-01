using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OOP2
{
    [Serializable]
    class TaskCL : EventClass
    {
        public string delegateName;
        public TaskCL (string nameItem, string dateItem, string timeItem, string delegateName) : base(nameItem , dateItem, timeItem)
        {
            this.delegateName = delegateName;
        }


    }
}
