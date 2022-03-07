using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Pitemlist
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Unit { get; set; }
        public double? Perpcs { get; set; }
        public double? Per100gm { get; set; }
        public double? Per150gm { get; set; }
        public double? Per200gm { get; set; }
        public double? Per250gm { get; set; }
        public double? Per300gm { get; set; }
        public string F10 { get; set; }
        public string F11 { get; set; }
        public string F12 { get; set; }
        public string F13 { get; set; }
        public string F14 { get; set; }
    }
}
