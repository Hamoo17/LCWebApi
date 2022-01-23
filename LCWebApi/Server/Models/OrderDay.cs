using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class OrderDay
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public int MealId { get; set; }
        public string MaxMain { get; set; }
        public string MaxSide { get; set; }
        public string MainUnit { get; set; }
        public string SideUnit { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
