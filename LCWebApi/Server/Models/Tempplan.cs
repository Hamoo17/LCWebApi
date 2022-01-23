using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Tempplan
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int MealId { get; set; }
        public string Protein { get; set; }
        public string Carb { get; set; }
        public string MealType { get; set; }
        public int DayNumber { get; set; }
    }
}
