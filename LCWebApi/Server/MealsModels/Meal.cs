using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class Meal
    {
        public Meal()
        {
            Sides = new HashSet<Side>();
        }

        public int Id { get; set; }
        public int ProgramId { get; set; }
        public int PlanId { get; set; }
        public int CategoryMealId { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public string Type { get; set; }
        public string MealUnit { get; set; }
        public string SideUnit { get; set; }
        public string MaxMeal { get; set; }
        public string MaxSide { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Side> Sides { get; set; }
    }
}
