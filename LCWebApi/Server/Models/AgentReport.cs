using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class AgentReport
    {
        public int Id { get; set; }
        public ulong UserId { get; set; }
        public string Branch { get; set; }
        public string ClientMobile { get; set; }
        public string ClientCid { get; set; }
        public string ClientName { get; set; }
        public string OrderDetail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
