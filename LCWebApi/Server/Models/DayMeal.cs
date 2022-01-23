using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class DayMeal
    {
        public ulong Id { get; set; }
        public ulong DayId { get; set; }
        public ulong MealId { get; set; }
    }
}
