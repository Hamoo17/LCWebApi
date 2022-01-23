using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Migration
    {
        public uint Id { get; set; }
        public string Migration1 { get; set; }
        public int Batch { get; set; }
    }
}
