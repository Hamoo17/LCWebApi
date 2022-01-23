using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class MealCategory
    {
        public long Id { get; set; }
        public string Level { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
