using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Agent
    {
        public ulong Id { get; set; }
        public int? BranchId { get; set; }
        public int? Role { get; set; }
        public long? AgentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual AgentBranch Branch { get; set; }
    }
}
