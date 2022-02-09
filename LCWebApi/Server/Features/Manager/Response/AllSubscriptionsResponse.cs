using System;
using static LCWebApi.Shared.EnumsCls;

namespace LCWebApi.Server.Features.Manager.Response
{
    public class AllSubscriptionsResponse
    {
        public int Id { get; set; }
        public string InvoiceNum { get; set; }
        public string SubFrom { get; set; }
        public string  FullName { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }
        public string AgentName { get; set; }
        public int? Discount { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime DeliveryStartingDay { get; set; }
        public string Mode { get; set; }
        public string PlanName { get; set; }
        public string Area { get; set; }
        public string Emarite { get; set; }



    }
}
