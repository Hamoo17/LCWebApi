using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Explan2
    {
        public int? Id { get; set; }
        public string Expln { get; set; }
        public int? Price { get; set; }
        public decimal? Vat { get; set; }
    }
}
