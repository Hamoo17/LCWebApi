using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime ExpenseTime { get; set; }
        public int Ammount { get; set; }
        public int? AppUserId { get; set; }
        public string CustomData { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
