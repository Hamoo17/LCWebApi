using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class CustomPlanDetail
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int MaxMeal { get; set; }
        public int MaxSnack { get; set; }
        public string Shotcutname { get; set; }
        public int MaxDays { get; set; }
        public int MinDays { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Plan Plan { get; set; }
    }
}
