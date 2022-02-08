using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class PlanOption
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public string NoDays { get; set; }
        public string ShortcutName { get; set; }
        public string Price { get; set; }

        public virtual Plan Plan { get; set; }
    }
}
