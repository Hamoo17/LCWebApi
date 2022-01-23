using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class ProgramCustomsDetail
    {
        public long Id { get; set; }
        public long PlanId { get; set; }
        public string NumberMeals { get; set; }
        public string NumberSnacks { get; set; }
        public int? StartDay { get; set; }
        public string NumberDays { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ProgramCustomsPlan Plan { get; set; }
    }
}
