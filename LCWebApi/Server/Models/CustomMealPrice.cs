using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class CustomMealPrice
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public int OneMeal { get; set; }
        public int TwoMeal { get; set; }
        public int ThreeMeal { get; set; }
        public int FourMeal { get; set; }
        public int FiveMeal { get; set; }
        public int SixMeal { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
