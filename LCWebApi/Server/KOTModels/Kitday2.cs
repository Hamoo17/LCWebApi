using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Kitday2
    {
        public int Id { get; set; }
        public DateTime? Datek { get; set; }
        public DateTime? Dateke { get; set; }
        public string Dname { get; set; }
        public string Daycn { get; set; }
        public int? Did { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }
    }
}
