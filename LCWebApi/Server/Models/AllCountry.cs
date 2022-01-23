using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class AllCountry
    {
        public int Id { get; set; }
        public string Sortname { get; set; }
        public string Name { get; set; }
        public string PhoneCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
