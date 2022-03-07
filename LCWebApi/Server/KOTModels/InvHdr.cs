using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class InvHdr
    {
        public InvHdr()
        {
            InvDetails = new HashSet<InvDetail>();
        }

        public int HdrId { get; set; }
        public string HdrCode { get; set; }
        public DateTime? HdrDateTime { get; set; }
        public int? HdrSubId { get; set; }
        public int? HdrBrch { get; set; }
        public int? HdrTax { get; set; }
        public decimal? HdrTaxVal { get; set; }
        public int? HdrDisc { get; set; }
        public decimal? HdrTotal { get; set; }
        public decimal? HdrNet { get; set; }
        public int? HdrType { get; set; }
        public bool? PayType { get; set; }

        public virtual Branch HdrBrchNavigation { get; set; }
        public virtual Subblier HdrSub { get; set; }
        public virtual ICollection<InvDetail> InvDetails { get; set; }
    }
}
