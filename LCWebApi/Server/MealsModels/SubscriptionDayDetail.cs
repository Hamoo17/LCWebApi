using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class SubscriptionDayDetail
    {
        public int Id { get; set; }
        public int SubscriptionDayId { get; set; }
        public int MealId { get; set; }
        public string MealName { get; set; }
        public string SnackName { get; set; }
        public string MealUnit { get; set; }
        public string SideUnit { get; set; }
        public string MaxMain { get; set; }
        public string MaxSide { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
