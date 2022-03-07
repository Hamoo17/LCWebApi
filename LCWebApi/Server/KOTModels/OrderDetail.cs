using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int MealId { get; set; }
        public int DayId { get; set; }
        public string ExtraFoodTag { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public long? Isdeleted { get; set; }
        public int MealTypeId { get; set; }
        public int NoofDays { get; set; }
        public bool Delivered { get; set; }

        public virtual Meal Meal { get; set; }
        public virtual Order Order { get; set; }
    }
}
