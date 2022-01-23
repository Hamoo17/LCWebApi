using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class CustMealNew
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string MealName { get; set; }
        public string MealNameAr { get; set; }
        public string MealDescription { get; set; }
        public string MealDescriptionAr { get; set; }
        public int PlanId { get; set; }
        public string MealUnit { get; set; }
        public string SideUnit { get; set; }
        public string MaxSide { get; set; }
        public string MaxMeal { get; set; }
        public string MealType { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
