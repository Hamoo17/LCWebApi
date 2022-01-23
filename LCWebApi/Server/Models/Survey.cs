using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Survey
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public string Quality { get; set; }
        public string QualityReason { get; set; }
        public string CustomerService { get; set; }
        public string CustomerServiceReason { get; set; }
        public string Delivery { get; set; }
        public string DeliveryReason { get; set; }
        public string Clinic { get; set; }
        public string ClinicReason { get; set; }
        public string ReachTargets { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
