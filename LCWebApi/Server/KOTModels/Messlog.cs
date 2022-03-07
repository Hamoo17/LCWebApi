using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Messlog
    {
        public int Id { get; set; }
        public DateTime Dater { get; set; }
        public string Save1 { get; set; }
        public string City { get; set; }
        public string Comp { get; set; }
        public string Shift { get; set; }
    }
}
