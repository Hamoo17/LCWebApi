using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Expiration
    {
        public int CustomerId { get; set; }
        public DateTime? LastInvoice { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? LastDay { get; set; }
        public int? DateDiff { get; set; }
    }
}
