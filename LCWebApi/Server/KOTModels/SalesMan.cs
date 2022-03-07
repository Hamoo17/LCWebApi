using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class SalesMan
    {
        public SalesMan()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Cnicnumber { get; set; }
        public bool Salaried { get; set; }
        public int Salary { get; set; }
        public bool Commisioned { get; set; }
        public bool InPercent { get; set; }
        public int Commision { get; set; }
        public string CustomData { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
