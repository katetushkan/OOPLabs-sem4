using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OOP2
{
    [Serializable]
    class ProjCl : InboxClass
    {
        public int quantityOfAdds;
        public TaskCL AdditTask;

        public ProjCl (string nameItem, int quantityOfAdds, TaskCL AdditTask) : base (nameItem)
        {
            this.quantityOfAdds = quantityOfAdds;
            this.AdditTask = AdditTask;
        }
    }
}
