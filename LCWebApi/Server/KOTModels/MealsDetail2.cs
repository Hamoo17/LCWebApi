using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class MealsDetail2
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Gm { get; set; }
        public double? Cal { get; set; }
        public double? Pro { get; set; }
        public double? Carb { get; set; }
        public double? Fat { get; set; }
    }
}
