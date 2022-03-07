using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class WeeklySalesSupscriptionReport
    {
        public int CustomerId { get; set; }
        public string Custname { get; set; }
        public string Custphone { get; set; }
        public string Branchn { get; set; }
        public string Mealtypename { get; set; }
        public string Custplan { get; set; }
        public int? SubscriptionId { get; set; }
    }
}
