using System;
using System.Collections.Generic;
using static LCWebApi.Shared.EnumsCls;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public int Deleted { get; set; }
        public string Status { get; set; }
        public string SubFrom { get; set; }
        public string OrderId { get; set; }
        public int? UserId { get; set; }
        public int? ProgramId { get; set; }
        public int? PlanId { get; set; }
        public string Custom { get; set; }
        public int? OptionId { get; set; }
        public int? LocationId { get; set; }
        public int? CodeId { get; set; }
        public decimal Price { get; set; }
        public string Vat { get; set; }
        public string Bag { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime DeliveryStartingDay { get; set; }
        public string DaysOfWeek { get; set; }
        public string Dislike { get; set; }
        public string DisLikeUser { get; set; }
        public string Note { get; set; }
        public string OrderNotes { get; set; }
        public string SubscriptionsNote { get; set; }
        public string FullPlanName { get; set; }
        public string InvoiceNo { get; set; }
        public string MastercardSessionId { get; set; }
        public string MastercardSessionVersion { get; set; }
        public string MastercardSuccessIndicator { get; set; }
        public string MastercardResultSessionVersion { get; set; }
        public string MastercardResultIndicator { get; set; }
        public InvoiceMode Mode { get; set; }
        public string Branch { get; set; }
        public int? AgentId { get; set; }
        public string UpdatedText { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
