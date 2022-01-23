using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Plan
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public sbyte NumberOfMeals { get; set; }
        public ulong ProgramId { get; set; }
    }
}
