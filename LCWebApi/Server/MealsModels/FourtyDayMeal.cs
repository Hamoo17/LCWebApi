using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class FourtyDayMeal
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int MealId { get; set; }
    }
}
