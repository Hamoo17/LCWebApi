using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class CustomerKot
    {
        public long Id { get; set; }
        public string ClientCid { get; set; }
        public string ClientName { get; set; }
        public string ClientMobile { get; set; }
        public string ClientPhone { get; set; }
        public string ClientPlan { get; set; }
        public string ClientAddress { get; set; }
        public string Branch { get; set; }
        public string Driver { get; set; }
        public string Status { get; set; }
        public string RemainingDays { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
