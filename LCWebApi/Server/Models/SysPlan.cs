using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class SysPlan
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public sbyte NumberOfMeals { get; set; }
        public long SysProgramId { get; set; }
    }
}
