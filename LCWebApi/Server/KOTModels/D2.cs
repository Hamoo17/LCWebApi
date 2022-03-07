using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class D2
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public string Icode { get; set; }
        public string Iname { get; set; }
        public double? Qty { get; set; }
        public string Rem { get; set; }
        public string Unit { get; set; }
        public string DayTag { get; set; }
        public int? Cal { get; set; }
        public int? Pro { get; set; }
        public int? Fat { get; set; }
        public int? Carb { get; set; }
        public int? Ca { get; set; }
        public int? Sod { get; set; }
    }
}
