using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class AutoDislike
    {
        public int Id { get; set; }
        public int? CatId { get; set; }
        public string Find { get; set; }
        public int? Fqty { get; set; }
        public string Replace { get; set; }
        public int? Rqty { get; set; }

        public virtual DislikeType Cat { get; set; }
    }
}
