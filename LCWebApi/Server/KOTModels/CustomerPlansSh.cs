using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class CustomerPlansSh
    {
        public int CustomerPlanId { get; set; }
        public string CustomerId { get; set; }
        public string SubscriptionId { get; set; }
        public string MealId { get; set; }
        public string DayId { get; set; }
        public string DeliveryTime { get; set; }
        public string MealTypeId { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Isdeleted { get; set; }
        public string Quantity { get; set; }
        public string ExtraFoodTag { get; set; }
        public string IsDeliverd { get; set; }
        public string MealDayCount { get; set; }
        public string Mealneame { get; set; }
        public string Ristricstartd { get; set; }
        public string Ristricend { get; set; }
        public string Startdatek { get; set; }
        public string Endd { get; set; }
        public string Ristrictednote { get; set; }
        public string Branchn { get; set; }
        public string Mealtypename { get; set; }
        public string Custname { get; set; }
        public string Custaddress { get; set; }
        public string Custphone { get; set; }
        public string Custmobile { get; set; }
        public string Custplan { get; set; }
        public string Delivercust { get; set; }
        public string Picup { get; set; }
        public string Taken { get; set; }
        public string Empid { get; set; }
    }
}
