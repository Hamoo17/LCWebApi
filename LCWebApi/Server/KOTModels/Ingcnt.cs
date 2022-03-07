using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Ingcnt
    {
        public Ingcnt()
        {
            InvDetails = new HashSet<InvDetail>();
            ItemsBrches = new HashSet<ItemsBrch>();
        }

        public int Id { get; set; }
        public string Item { get; set; }
        public string Ext { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public string Ext3 { get; set; }
        public string Ext4 { get; set; }
        public string Ext5 { get; set; }
        public string Ext6 { get; set; }
        public string Ext7 { get; set; }
        public decimal? PurPrice { get; set; }
        public int? ItemSubId { get; set; }
        public decimal? Qty { get; set; }
        public string ItemName2 { get; set; }

        public virtual Subblier ItemSub { get; set; }
        public virtual ICollection<InvDetail> InvDetails { get; set; }
        public virtual ICollection<ItemsBrch> ItemsBrches { get; set; }
    }
}
