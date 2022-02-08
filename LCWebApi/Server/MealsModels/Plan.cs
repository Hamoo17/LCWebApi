using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class Plan
    {
        public Plan()
        {
            CustomPlanDetails = new HashSet<CustomPlanDetail>();
            CustomPlanPrices = new HashSet<CustomPlanPrice>();
            PlanOptions = new HashSet<PlanOption>();
        }

        public int Id { get; set; }
        public int ProgramId { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string NoMeals { get; set; }

        public virtual Program Program { get; set; }
        public virtual ICollection<CustomPlanDetail> CustomPlanDetails { get; set; }
        public virtual ICollection<CustomPlanPrice> CustomPlanPrices { get; set; }
        public virtual ICollection<PlanOption> PlanOptions { get; set; }
    }
}
