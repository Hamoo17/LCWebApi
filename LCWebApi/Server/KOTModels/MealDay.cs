using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class MealDay
    {
        public MealDay()
        {
            Meals = new HashSet<Meal>();
        }

        public int MealDayId { get; set; }
        public string MealDayName { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
