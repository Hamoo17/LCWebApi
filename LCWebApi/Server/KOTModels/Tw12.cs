using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Tw12
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string Meals { get; set; }
        public decimal? Price { get; set; }
        public string Mqyty { get; set; }
        public string Totap { get; set; }
        public string Totalv { get; set; }
        public string Totalq { get; set; }
        public string Branch { get; set; }
        public string Salesm { get; set; }
        public string Comment { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
    }
}
