using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class BagEnable
    {
        public int Id { get; set; }
        public long EmaraId { get; set; }
        public bool Enable { get; set; }
        public string BagPrice { get; set; }

        public virtual Emara Emara { get; set; }
    }
}
