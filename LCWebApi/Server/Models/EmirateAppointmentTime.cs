using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class EmirateAppointmentTime
    {
        public int Id { get; set; }
        public int EmirateAppointmentId { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
    }
}
