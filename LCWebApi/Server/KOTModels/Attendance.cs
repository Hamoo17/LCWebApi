using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Attendance
    {
        public int Id { get; set; }
        public bool OnDuty { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public int SalesManId { get; set; }
        public string CustomData { get; set; }

        public virtual SalesMan SalesMan { get; set; }
    }
}
