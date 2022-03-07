using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Planpr
    {
        public int Id { get; set; }
        public string Plname { get; set; }
        public int? Plprice { get; set; }
        public decimal? Vat { get; set; }
    }
}
