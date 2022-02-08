using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class SubscriptionDay
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Updated { get; set; }
        public int SubscriptionId { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public int LocationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
