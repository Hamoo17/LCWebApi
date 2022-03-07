using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class ProductTransaction
    {
        public ProductTransaction()
        {
            ProductTransactionDetails = new HashSet<ProductTransactionDetail>();
        }

        public int Id { get; set; }
        public DateTime TransactionTime { get; set; }
        public string CustomData { get; set; }
        public int? SupplierVendorId { get; set; }

        public virtual Supplier SupplierVendor { get; set; }
        public virtual ICollection<ProductTransactionDetail> ProductTransactionDetails { get; set; }
    }
}
