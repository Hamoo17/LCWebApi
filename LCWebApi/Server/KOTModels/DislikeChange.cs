using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class DislikeChange
    {
        public int Id { get; set; }
        public int DislikeType { get; set; }
        public int MealId { get; set; }
        public int DisLikeId { get; set; }
        public int? Dqtty { get; set; }
        public int LikeId { get; set; }
        public int? Lqtty { get; set; }

        public virtual DisLikeItem DisLike { get; set; }
        public virtual DislikeType DislikeTypeNavigation { get; set; }
        public virtual LikeItem Like { get; set; }
    }
}
