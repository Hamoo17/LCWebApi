using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class MealDetail
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Carb { get; set; }
        public double Fat { get; set; }
        public string Kilj { get; set; }
    }
}
