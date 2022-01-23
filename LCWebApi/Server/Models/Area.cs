using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Area
    {
        public ulong Id { get; set; }
        public ulong EmirateId { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
