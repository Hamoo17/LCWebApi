using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class InvDetail
    {
        public int DetailId { get; set; }
        public int? DetailHdrId { get; set; }
        public int? DetailItemId { get; set; }
        public decimal? DetailItemPurPrice { get; set; }
        public decimal? DetailItemQty { get; set; }
        public decimal? DetailItemTlLine { get; set; }
        public string DetailItemName2 { get; set; }

        public virtual InvHdr DetailHdr { get; set; }
        public virtual Ingcnt DetailItem { get; set; }
    }
}
