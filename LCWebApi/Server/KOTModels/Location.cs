using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Location
    {
        public Location()
        {
            Customers = new HashSet<Customer>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Del { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
