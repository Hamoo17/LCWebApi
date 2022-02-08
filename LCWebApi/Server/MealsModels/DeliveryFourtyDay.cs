using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class DeliveryFourtyDay
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public int DayId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
