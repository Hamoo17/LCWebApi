using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class UnitType
    {
        public UnitType()
        {
            Meals = new HashSet<Meal>();
        }

        public int UnitTypeId { get; set; }
        public string UnitTypeName { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
