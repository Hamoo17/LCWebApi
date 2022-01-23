using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Emirate { get; set; }
        public string Area { get; set; }
        public string Address1 { get; set; }
        public string Floor { get; set; }
        public string LandMark { get; set; }
        public string FlatNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
