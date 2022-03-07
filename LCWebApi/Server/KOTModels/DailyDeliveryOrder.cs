using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class DailyDeliveryOrder
    {
        public int? Cid { get; set; }
        public string Cname { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string ConName { get; set; }
        public DateTime? Dt { get; set; }
    }
}
