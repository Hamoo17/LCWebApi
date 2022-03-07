using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Sslog
    {
        public int Id { get; set; }
        public string Actions { get; set; }
        public string SelectedDates { get; set; }
        public string Result { get; set; }
        public string TotalPrint { get; set; }
        public string CreatedDate { get; set; }
    }
}
