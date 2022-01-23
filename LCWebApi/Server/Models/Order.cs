using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public int CustomProgramId { get; set; }
        public string MealsCount { get; set; }
        public string SnacksCount { get; set; }
        public string DaysCount { get; set; }
        public DateTime StartDeliveryDay { get; set; }
        public string GrandTotal { get; set; }
        public string Price { get; set; }
        public int CodeId { get; set; }
        public string DeliveryDays { get; set; }
        public int LocationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
