using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class CustomerPlan
    {
        public int CustomerPlanId { get; set; }
        public int CustomerId { get; set; }
        public int? SubscriptionId { get; set; }
        public int MealId { get; set; }
        public int DayId { get; set; }
        public int DeliveryTime { get; set; }
        public int MealTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? Isdeleted { get; set; }
        public decimal? Quantity { get; set; }
        public string ExtraFoodTag { get; set; }
        public bool IsDeliverd { get; set; }
        public int? MealDayCount { get; set; }
        public string Mealneame { get; set; }
        public DateTime? Ristricstartd { get; set; }
        public DateTime? Ristricend { get; set; }
        public DateTime? Startdatek { get; set; }
        public DateTime? Endd { get; set; }
        public string Ristrictednote { get; set; }
        public string Branchn { get; set; }
        public string Mealtypename { get; set; }
        public string Custname { get; set; }
        public string Custaddress { get; set; }
        public string Custphone { get; set; }
        public string Custmobile { get; set; }
        public string Custplan { get; set; }
        public int? Delivercust { get; set; }
        public int? Picup { get; set; }
        public string Taken { get; set; }
        public int? Empid { get; set; }
        public string Untillcall { get; set; }
        public string Pickbr { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }
        public string Comm3 { get; set; }
        public string Comm4 { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
