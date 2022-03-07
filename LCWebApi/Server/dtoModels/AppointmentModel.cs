using System;

namespace LCWebApi.Server.dtoModels
{
    public class AppointmentModel
    {
        public DateTime Date{ get; set; }
        public int PeopleCount { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Emirate { get; set; }
        public int SubscriptionId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedON { get; set; }
        public int iNV_State { get; set; }
        public string Inv_ref { get; set; }
        public string GiftCode { get; set; }

    }
}
