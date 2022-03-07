using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class DislikeType
    {
        public DislikeType()
        {
            AutoDislikes = new HashSet<AutoDislike>();
            DislikeChanges = new HashSet<DislikeChange>();
        }

        public int Id { get; set; }
        public string AutoDislikeName { get; set; }

        public virtual ICollection<AutoDislike> AutoDislikes { get; set; }
        public virtual ICollection<DislikeChange> DislikeChanges { get; set; }
    }
}
