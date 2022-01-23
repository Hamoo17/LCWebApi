using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Term
    {
        public long Id { get; set; }
        public string Header { get; set; }
        public string HeaderAr { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public string Mob { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
