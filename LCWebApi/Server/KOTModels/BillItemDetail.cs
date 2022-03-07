using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class BillItemDetail
    {
        public BillItemDetail()
        {
            RefundProductDetails = new HashSet<RefundProductDetail>();
        }

        public int Id { get; set; }
        public int? PosItemId { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public int PosBillId { get; set; }
        public string CustomData { get; set; }
        public int MealId { get; set; }

        public virtual BillRecored PosBill { get; set; }
        public virtual Product2 PosItem { get; set; }
        public virtual ICollection<RefundProductDetail> RefundProductDetails { get; set; }
    }
}
