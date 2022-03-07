using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Suppli
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Iteminpurch { get; set; }
        public string Munit { get; set; }
        public string Subunit { get; set; }
        public int? Qty { get; set; }
        public int? Unit { get; set; }
        public decimal? Sunit { get; set; }
        public decimal? Totalunit { get; set; }
        public decimal? Tprice { get; set; }
        public decimal? Gmprice { get; set; }
        public string Supplires { get; set; }
        public int? Ext { get; set; }
        public int? Ext1 { get; set; }
        public string Ext2 { get; set; }
    }
}
