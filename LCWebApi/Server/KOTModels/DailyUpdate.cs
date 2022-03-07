using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class DailyUpdate
    {
        public int? Cid { get; set; }
        public string Jobn { get; set; }
        public DateTime? Dstart { get; set; }
    }
}
