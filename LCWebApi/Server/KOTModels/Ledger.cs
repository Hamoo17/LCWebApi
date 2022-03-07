using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Ledger
    {
        public int Id { get; set; }
        public int? Cid { get; set; }
        public string Cname { get; set; }
        public string Jobn { get; set; }
        public DateTime? Dstart { get; set; }
        public DateTime? Dend { get; set; }
        public string Comment { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
    }
}
