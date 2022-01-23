using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class AreasNew
    {
        public long Id { get; set; }
        public long EmaraId { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public virtual Emara Emara { get; set; }
    }
}
