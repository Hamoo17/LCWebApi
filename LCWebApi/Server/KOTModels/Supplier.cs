using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Supplier
    {
        public Supplier()
        {
            Product2s = new HashSet<Product2>();
            ProductTransactions = new HashSet<ProductTransaction>();
        }

        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string CustomData { get; set; }

        public virtual ICollection<Product2> Product2s { get; set; }
        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }
    }
}
