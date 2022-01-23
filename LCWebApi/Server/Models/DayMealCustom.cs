using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class DayMealCustom
    {
        public ulong Id { get; set; }
        public ulong DayId { get; set; }
        public ulong MealCustomId { get; set; }

        public virtual Day Day { get; set; }
        public virtual CustomMenu MealCustom { get; set; }
    }
}
