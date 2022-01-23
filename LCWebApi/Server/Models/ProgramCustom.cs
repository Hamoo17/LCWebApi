using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class ProgramCustom
    {
        public ProgramCustom()
        {
            ProgramCustomsPlans = new HashSet<ProgramCustomsPlan>();
        }

        public ulong Id { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
        public string EnDescription { get; set; }
        public string ArDescription { get; set; }
        public string Img { get; set; }
        public string Icon { get; set; }
        public string OrderBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<ProgramCustomsPlan> ProgramCustomsPlans { get; set; }
    }
}
