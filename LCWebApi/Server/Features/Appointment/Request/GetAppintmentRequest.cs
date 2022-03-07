using System;

namespace LCWebApi.Server.Features.Appointment.Request
{
    public class GetAppintmentRequest
    {
        public DateTime Date { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime To { get; set; }
        public string PhoneNumber { get; set; }
        public string EamirateName { get; set; }
        public int Inv_State { get; set; }
        public string Inv_Ref { get; set; }
        public string GiftCode { get; set; }

    }
}
