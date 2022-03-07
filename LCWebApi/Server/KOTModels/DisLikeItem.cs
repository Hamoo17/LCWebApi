using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class DisLikeItem
    {
        public DisLikeItem()
        {
            DislikeChanges = new HashSet<DislikeChange>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Qtty { get; set; }
        public int? Unit { get; set; }

        public virtual ICollection<DislikeChange> DislikeChanges { get; set; }
    }
}
