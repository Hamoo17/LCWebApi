using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class PlanOption
    {
        public ulong Id { get; set; }
        public sbyte NumberOfDays { get; set; }
        public decimal Price { get; set; }
        public ulong PlanId { get; set; }
        public string Name { get; set; }
    }
}
