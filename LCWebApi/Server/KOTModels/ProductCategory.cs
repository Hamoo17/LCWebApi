using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Product2s = new HashSet<Product2>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string CustomData { get; set; }

        public virtual ICollection<Product2> Product2s { get; set; }
    }
}
