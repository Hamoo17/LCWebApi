using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class SysPlanOption
    {
        public long Id { get; set; }
        public sbyte NumberOfDays { get; set; }
        public decimal Price { get; set; }
        public long SysPlanId { get; set; }
        public string Name { get; set; }
    }
}
