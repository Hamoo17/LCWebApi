using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Meal
    {
        public Meal()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderMealId1Navigations = new HashSet<Order>();
            OrderMealId2Navigations = new HashSet<Order>();
            OrderMealId3Navigations = new HashSet<Order>();
            OrderMealId4Navigations = new HashSet<Order>();
            OrderMealId5Navigations = new HashSet<Order>();
            OrderMealId6Navigations = new HashSet<Order>();
            OrderMealId7Navigations = new HashSet<Order>();
        }

        public int MealId { get; set; }
        public string MealName { get; set; }
        public int? UnitTypeId { get; set; }
        public decimal? Calories { get; set; }
        public decimal? Protiens { get; set; }
        public decimal? Fats { get; set; }
        public decimal? Carb { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? Isdeleted { get; set; }
        public int ProductCategoryId { get; set; }
        public int MealTypeId { get; set; }
        public int DayId { get; set; }
        public decimal Price { get; set; }
        public string Mealtypename { get; set; }
        public decimal? Kilj { get; set; }
        public decimal? Fiber { get; set; }
        public decimal? Suger { get; set; }
        public decimal? Sfat { get; set; }
        public decimal? Cholest { get; set; }
        public decimal? Sod { get; set; }
        public decimal? Potas { get; set; }

        public virtual MealDay Day { get; set; }
        public virtual UnitType UnitType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Order> OrderMealId1Navigations { get; set; }
        public virtual ICollection<Order> OrderMealId2Navigations { get; set; }
        public virtual ICollection<Order> OrderMealId3Navigations { get; set; }
        public virtual ICollection<Order> OrderMealId4Navigations { get; set; }
        public virtual ICollection<Order> OrderMealId5Navigations { get; set; }
        public virtual ICollection<Order> OrderMealId6Navigations { get; set; }
        public virtual ICollection<Order> OrderMealId7Navigations { get; set; }
    }
}
