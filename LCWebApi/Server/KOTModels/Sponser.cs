using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Sponser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discount { get; set; }
        public string Discam { get; set; }
        public string Counter { get; set; }
        public string Branch { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
    }
}
