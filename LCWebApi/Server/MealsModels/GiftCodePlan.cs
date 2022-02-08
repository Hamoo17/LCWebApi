using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class GiftCodePlan
    {
        public int Id { get; set; }
        public int GiftCodeProgramId { get; set; }
        public int PlanId { get; set; }
    }
}
