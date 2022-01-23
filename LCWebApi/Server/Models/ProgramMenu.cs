using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class ProgramMenu
    {
        public ulong Id { get; set; }
        public ulong ProgramId { get; set; }
        public ulong MealId { get; set; }
    }
}
