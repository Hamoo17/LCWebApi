using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Location
    {
        public ulong Id { get; set; }
        public long EmirateId { get; set; }
        public string AreaId { get; set; }
        public string PropertyNumber { get; set; }
        public string Landmark { get; set; }
    }
}
