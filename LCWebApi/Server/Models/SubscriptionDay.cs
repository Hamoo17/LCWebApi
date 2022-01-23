using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class SubscriptionDay
    {
        public ulong Id { get; set; }
        public int Day { get; set; }
        public ulong? MealId { get; set; }
        public long? MealGeneralId { get; set; }
        public ulong? GramsId { get; set; }
        public ulong SubscriptionId { get; set; }
        public string Protein { get; set; }
        public string Carb { get; set; }
    }
}
