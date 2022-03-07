using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Branch
    {
        public Branch()
        {
            InvHdrs = new HashSet<InvHdr>();
            ItemsBrches = new HashSet<ItemsBrch>();
        }

        public int BrchId { get; set; }
        public string BrchName { get; set; }
        public decimal? PurVPrice { get; set; }

        public virtual ICollection<InvHdr> InvHdrs { get; set; }
        public virtual ICollection<ItemsBrch> ItemsBrches { get; set; }
    }
}
