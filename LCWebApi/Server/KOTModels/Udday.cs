using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Udday
    {
        public int CustomerId { get; set; }
        public int? Count { get; set; }
        public int? Days { get; set; }
        public int? Actual { get; set; }
        public string Custplan { get; set; }
    }
}
