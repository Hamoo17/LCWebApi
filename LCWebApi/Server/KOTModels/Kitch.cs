using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Kitch
    {
        public int? Cid { get; set; }
        public int? Subscid { get; set; }
        public string Mealname { get; set; }
        public int Mealid { get; set; }
        public string Dayid { get; set; }
        public string Mealunit { get; set; }
    }
}
