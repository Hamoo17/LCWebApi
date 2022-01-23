using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class DeliveryDay
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
