using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class DayMealNew
    {
        public long Id { get; set; }
        public ulong DayId { get; set; }
        public long MealNewId { get; set; }
        public long SysProgramId { get; set; }
    }
}
