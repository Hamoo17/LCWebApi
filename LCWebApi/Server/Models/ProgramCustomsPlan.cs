using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class ProgramCustomsPlan
    {
        public ProgramCustomsPlan()
        {
            CustomMenus = new HashSet<CustomMenu>();
            CustomPlanPrices = new HashSet<CustomPlanPrice>();
            ProgramCustomsDetails = new HashSet<ProgramCustomsDetail>();
        }

        public long Id { get; set; }
        public string Plan { get; set; }
        public int? MaxCarb { get; set; }
        public int? MaxProtein { get; set; }
        public ulong CustomProgramId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ProgramCustom CustomProgram { get; set; }
        public virtual ICollection<CustomMenu> CustomMenus { get; set; }
        public virtual ICollection<CustomPlanPrice> CustomPlanPrices { get; set; }
        public virtual ICollection<ProgramCustomsDetail> ProgramCustomsDetails { get; set; }
    }
}
