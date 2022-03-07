using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Clincp
    {
        public int Id { get; set; }
        public string Servn { get; set; }
        public decimal? Price { get; set; }
        public int? Vat { get; set; }
        public int? Disc { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }
        public string Comm3 { get; set; }
    }
}
