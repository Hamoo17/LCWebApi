using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class AgentEmirate
    {
        public AgentEmirate()
        {
            AgentBranches = new HashSet<AgentBranch>();
        }

        public int Id { get; set; }
        public string Program { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<AgentBranch> AgentBranches { get; set; }
    }
}
