using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Invent
    {
        public int Id { get; set; }
        public string Ing { get; set; }
        public decimal? Gm { get; set; }
        public DateTime? Dat { get; set; }
        public string Brnch { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }
    }
}
