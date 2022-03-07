using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? OrderTotal { get; set; }
        public int? DeliveryTimeId { get; set; }
        public long? IsDeleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string OrderNumber { get; set; }
        public int? MealId1 { get; set; }
        public int? MealId2 { get; set; }
        public int? MealId3 { get; set; }
        public int? MealId4 { get; set; }
        public int? MealId5 { get; set; }
        public int? MealId6 { get; set; }
        public int? MealId7 { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Meal MealId1Navigation { get; set; }
        public virtual Meal MealId2Navigation { get; set; }
        public virtual Meal MealId3Navigation { get; set; }
        public virtual Meal MealId4Navigation { get; set; }
        public virtual Meal MealId5Navigation { get; set; }
        public virtual Meal MealId6Navigation { get; set; }
        public virtual Meal MealId7Navigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
