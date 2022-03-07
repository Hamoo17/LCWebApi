using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Ingrfr
    {
        public int Id { get; set; }
        public string Ingname { get; set; }
        public double? Gmpc { get; set; }
        public double? Recip { get; set; }
        public string Runit { get; set; }
        public string Norp { get; set; }
        public string Nameprch { get; set; }
        public string Munit { get; set; }
        public string Insunit { get; set; }
        public double? Amountins { get; set; }
        public string Smunit { get; set; }
        public double? Gmunit { get; set; }
        public double? Finamnt { get; set; }
        public double? Insper { get; set; }
        public double? Fgminam { get; set; }
        public double? Tpricewovat { get; set; }
        public double? Gmpwvat { get; set; }
        public double? Kpwvat { get; set; }
        public string Suppn { get; set; }
        public string Instore { get; set; }
    }
}
