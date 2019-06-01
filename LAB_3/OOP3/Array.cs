using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Array
    {
        public List<InboxClass> listIn;
        public List<EventClass> listEv;
        public List<ProjCl> listProj;
        public List<SubProj> listSub;
        public Array (List<InboxClass> listIn, List<EventClass> listEv, List<ProjCl> listProj, List<SubProj> listSub)
        {
            this.listIn = listIn;
            this.listEv = listEv;
            this.listProj = listProj;
            this.listSub = listSub;
        }


    }
}
