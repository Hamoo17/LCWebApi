using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class MealsDetail
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Gm { get; set; }
        public double? Cal { get; set; }
        public double? Pro { get; set; }
        public double? Carb { get; set; }
        public double? Fat { get; set; }
        public double? Kilj { get; set; }
        public double? Fiber { get; set; }
        public double? Suger { get; set; }
        public double? Sfat { get; set; }
        public double? Cholest { get; set; }
        public double? Sod { get; set; }
        public double? Potas { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public string Cat { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }

        public virtual LikeItem LikeItem { get; set; }
    }
}
