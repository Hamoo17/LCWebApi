using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Calory
    {
        public ulong Id { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Calories { get; set; }
        public string Unit { get; set; }
        public ulong? MealId { get; set; }
    }
}
