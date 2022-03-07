using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Product2
    {
        public Product2()
        {
            BillItemDetails = new HashSet<BillItemDetail>();
            ProductTransactionDetails = new HashSet<ProductTransactionDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Discount { get; set; }
        public bool DiscountInPercent { get; set; }
        public byte[] ImageContent { get; set; }
        public int VendorId { get; set; }
        public int TotalItemsPurchased { get; set; }
        public int TotalItemsSold { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool DontMonitorStock { get; set; }
        public int? UnitTypeId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? DayId { get; set; }
        public decimal? Calories { get; set; }
        public decimal? Protiens { get; set; }
        public decimal? Fats { get; set; }
        public decimal? Carb { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual Supplier Vendor { get; set; }
        public virtual ICollection<BillItemDetail> BillItemDetails { get; set; }
        public virtual ICollection<ProductTransactionDetail> ProductTransactionDetails { get; set; }
    }
}
