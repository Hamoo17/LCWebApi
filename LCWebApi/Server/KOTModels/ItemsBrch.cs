using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class ItemsBrch
    {
        public int ItemBrchId { get; set; }
        public int? BrchId { get; set; }
        public int? ItemId { get; set; }
        public decimal? ItemSalePrice { get; set; }

        public virtual Branch Brch { get; set; }
        public virtual Ingcnt Item { get; set; }
    }
}
