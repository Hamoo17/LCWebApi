using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class GetProcessView
    {
        public int Cid { get; set; }
        public string Mealname { get; set; }
        public string Mealunit { get; set; }
        public string Branch { get; set; }
        public string Prosses1 { get; set; }
        public string Prosses2 { get; set; }
        public string Prosses3 { get; set; }
    }
}
