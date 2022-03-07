using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Paytre
    {
        public decimal Totalsale { get; set; }
        public decimal? Casht { get; set; }
        public decimal? Cardt { get; set; }
        public decimal? Careget { get; set; }
        public decimal? Talabt { get; set; }
        public decimal? Zamatt { get; set; }
        public decimal? Onlinet { get; set; }
        public decimal? Excht { get; set; }
        public decimal? Expenst { get; set; }
        public decimal? Picupt { get; set; }
        public decimal? Delvt { get; set; }
        public decimal? Netp { get; set; }
        public string Comment { get; set; }
    }
}
