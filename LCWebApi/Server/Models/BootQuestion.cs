using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class BootQuestion
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Parent { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public string QuestionAr { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
