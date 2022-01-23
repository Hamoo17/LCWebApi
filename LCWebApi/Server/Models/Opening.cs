using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Opening
    {
        public long Id { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
    }
}
