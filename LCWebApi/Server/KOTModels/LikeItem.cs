using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class LikeItem
    {
        public LikeItem()
        {
            DislikeChanges = new HashSet<DislikeChange>();
        }

        public int Id { get; set; }
        public string LikeName { get; set; }
        public int? Qtty { get; set; }
        public int? Unit { get; set; }

        public virtual MealsDetail IdNavigation { get; set; }
        public virtual ICollection<DislikeChange> DislikeChanges { get; set; }
    }
}
