using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class CustomersExpiration
    {
        public int CustomerId { get; set; }
        public DateTime? Last { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
