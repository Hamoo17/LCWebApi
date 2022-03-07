using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Kitchall
    {
        public int Cid { get; set; }
        public decimal? Mealname { get; set; }
        public string Mealunit { get; set; }
        public string Branch { get; set; }
    }
}
