using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class MaxPlan
    {
        public int CustomerId { get; set; }
        public int? CountDays { get; set; }
        public string Custphone { get; set; }
        public string Branchn { get; set; }
        public int? SubscriptionId { get; set; }
        public string Payment { get; set; }
    }
}
