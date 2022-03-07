using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Subblier
    {
        public Subblier()
        {
            Ingcnts = new HashSet<Ingcnt>();
            InvHdrs = new HashSet<InvHdr>();
        }

        public int SubId { get; set; }
        public string SubName { get; set; }
        public string SubPhone { get; set; }
        public string SubAddress { get; set; }

        public virtual ICollection<Ingcnt> Ingcnts { get; set; }
        public virtual ICollection<InvHdr> InvHdrs { get; set; }
    }
}
