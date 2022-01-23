using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Emara
    {
        public Emara()
        {
            AreasNews = new HashSet<AreasNew>();
            BagEnables = new HashSet<BagEnable>();
        }

        public long Id { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
        public string InbodyPrice { get; set; }

        public virtual ICollection<AreasNew> AreasNews { get; set; }
        public virtual ICollection<BagEnable> BagEnables { get; set; }
    }
}
