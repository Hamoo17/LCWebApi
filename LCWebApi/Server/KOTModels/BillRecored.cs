using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class BillRecored
    {
        public BillRecored()
        {
            BillItemDetails = new HashSet<BillItemDetail>();
            RefundDetails = new HashSet<RefundDetail>();
        }

        public int Id { get; set; }
        public DateTime BillCreatedDate { get; set; }
        public decimal AmountPaid { get; set; }
        public bool BillCanceled { get; set; }
        public bool BillPayed { get; set; }
        public int PaymentMethod { get; set; }
        public string CardId { get; set; }
        public int? AppUserId { get; set; }
        public int? SalesManId { get; set; }
        public string CustomData { get; set; }
        public decimal? Totaldisc { get; set; }
        public string Planname { get; set; }
        public string Delivery { get; set; }
        public string Branch { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<BillItemDetail> BillItemDetails { get; set; }
        public virtual ICollection<RefundDetail> RefundDetails { get; set; }
    }
}
