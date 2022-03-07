using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class TempMealsDetail
    {
        public string Item { get; set; }
        public string Gm { get; set; }
        public double? Cal { get; set; }
        public double? Kilj { get; set; }
        public double? Fat { get; set; }
        public double? Sod { get; set; }
        public double? Carb { get; set; }
        public double? Pro { get; set; }
    }
}
