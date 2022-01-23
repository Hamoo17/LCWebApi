using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class BranchCashier
    {
        public int Id { get; set; }
        public int BranchDetailId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Whatsapp { get; set; }
    }
}
