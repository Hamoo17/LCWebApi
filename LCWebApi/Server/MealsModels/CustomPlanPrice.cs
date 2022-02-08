using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class CustomPlanPrice
    {
        public long Id { get; set; }
        public int PlanId { get; set; }
        public int OneMeal { get; set; }
        public int TwoMeal { get; set; }
        public int ThreeMeal { get; set; }
        public int FourMeal { get; set; }
        public int FiveMeal { get; set; }
        public int SixMeal { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Plan Plan { get; set; }
    }
}
