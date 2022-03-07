using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class CustomersLocation
    {
        public string Branchn { get; set; }
        public int Customerid { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
