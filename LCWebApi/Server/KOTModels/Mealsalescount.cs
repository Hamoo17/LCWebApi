using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Mealsalescount
    {
        public int Mealidre { get; set; }
        public string Mealname { get; set; }
        public int? Countofmeal { get; set; }
        public string Comment { get; set; }
    }
}
