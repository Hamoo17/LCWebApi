using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Day
    {
        public Day()
        {
            DayMealCustoms = new HashSet<DayMealCustom>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DayMealCustom> DayMealCustoms { get; set; }
    }
}
