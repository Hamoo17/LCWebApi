using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerPlans = new HashSet<CustomerPlan>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerAddress4 { get; set; }
        public int? CustomerCity { get; set; }
        public string Customerdelviryname { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerEmail { get; set; }
        public int? SubscriptionId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CustomerDob { get; set; }
        public string CustomerGender { get; set; }
        public int? Isdeleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CustomerDeliveryAddress1 { get; set; }
        public string CustomerDeliveryAddress2 { get; set; }
        public int? CustomerLocationMain { get; set; }
        public int? CustomerLocationTransfer { get; set; }
        public int? SubscriptionTypeId { get; set; }
        public int? CustomerStartDay { get; set; }
        public int? DeliveryTimeId { get; set; }
        public int? PickUpCustomer { get; set; }
        public int? DeliveryCustomer { get; set; }
        public int? NoOfDays { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? NumberOfRemainingFoods { get; set; }
        public decimal? Discount { get; set; }
        public string Dislike { get; set; }
        public string Comments { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }
        public string Comment6 { get; set; }
        public string Comment7 { get; set; }
        public string Comment8 { get; set; }
        public string Comment9 { get; set; }
        public string Comment10 { get; set; }
        public string Comment11 { get; set; }
        public string Comment12 { get; set; }
        public DateTime? Comment13 { get; set; }
        public string Comment14 { get; set; }

        public virtual Location CustomerLocationMainNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<CustomerPlan> CustomerPlans { get; set; }
    }
}
