using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class Side
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Meal Meal { get; set; }
    }
}
