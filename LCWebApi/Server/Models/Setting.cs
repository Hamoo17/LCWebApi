using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public float? SnacksPrice { get; set; }
        public string BagPrice { get; set; }
        public string Vat { get; set; }
        public string DemoModalText { get; set; }
    }
}
