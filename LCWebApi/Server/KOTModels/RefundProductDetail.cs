using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class RefundProductDetail
    {
        public int Id { get; set; }
        public int RefundInfoId { get; set; }
        public int BillItemInfoId { get; set; }
        public int Quantity { get; set; }
        public string CustomData { get; set; }

        public virtual BillItemDetail BillItemInfo { get; set; }
        public virtual RefundDetail RefundInfo { get; set; }
    }
}
