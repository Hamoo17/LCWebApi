using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class MyPrice
    {
        public int Id { get; set; }
        public int Meals { get; set; }
        public decimal Lw { get; set; }
        public decimal Gw { get; set; }
        public decimal Cplw { get; set; }
        public decimal Cpgw { get; set; }
    }
}
