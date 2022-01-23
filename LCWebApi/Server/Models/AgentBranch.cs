using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class AgentBranch
    {
        public AgentBranch()
        {
            Agents = new HashSet<Agent>();
            Drivers = new HashSet<Driver>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AgentEmirateId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual AgentEmirate AgentEmirate { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
