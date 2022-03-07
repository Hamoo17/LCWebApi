using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Kitcre
    {
        public int Id { get; set; }
        public int Mealid { get; set; }
        public string Mealname { get; set; }
        public int? Countmeal { get; set; }
    }
}
