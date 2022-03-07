using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class SubscriptionDetail
    {
        public int SubscriptionDetailId { get; set; }
        public int SubscriptionId { get; set; }
        public int MealId { get; set; }
        public int MealTypeId { get; set; }
        public int DayId { get; set; }
        public decimal Quantity { get; set; }
        public string ExtraFoodTag { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? IsDeleted { get; set; }
    }
}
