using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class GiftCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Flag { get; set; }
        public string Type { get; set; }
        public int Percentage { get; set; }
        public int NoOfUse { get; set; }
        public string AvailableForPlans { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
