using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Clncserv
    {
        public int Id { get; set; }
        public string Invn { get; set; }
        public string Servn { get; set; }
        public decimal? Pricwov { get; set; }
        public decimal? Vat { get; set; }
        public int? Disc { get; set; }
        public string Cashir { get; set; }
        public string Dateinv { get; set; }
        public string Custn { get; set; }
        public string Custph { get; set; }
        public string Custemai { get; set; }
        public string Recomn { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }
        public string Comm3 { get; set; }
        public string Comm4 { get; set; }
    }
}
