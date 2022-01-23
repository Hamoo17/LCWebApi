using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class SpecialCutomNews
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public int? CalorieNumber { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int? Age { get; set; }
        public string DailyActivity { get; set; }
        public string PracticeSport { get; set; }
        public int? PractiseInWeek { get; set; }
        public int? HourInExercise { get; set; }
        public string TypeOfSport { get; set; }
        public string HaveAnyInfections { get; set; }
        public int? MealsYouPreferCount { get; set; }
        public int? SnacksYouPreferCount { get; set; }
        public string AreYouAllergicToSomeMeals { get; set; }
        public string FavProgram { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
