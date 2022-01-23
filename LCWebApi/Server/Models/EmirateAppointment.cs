using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class EmirateAppointment
    {
        public int Id { get; set; }
        public int EmaraId { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public int MaxPeople { get; set; }
    }
}
