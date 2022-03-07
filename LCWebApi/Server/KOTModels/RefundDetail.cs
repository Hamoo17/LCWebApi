using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class RefundDetail
    {
        public RefundDetail()
        {
            RefundProductDetails = new HashSet<RefundProductDetail>();
        }

        public int Id { get; set; }
        public DateTime RefundDate { get; set; }
        public int? Cid { get; set; }
        public string Refundmeth { get; set; }
        public int? BillIrerfrnc { get; set; }
        public int? AppUserId { get; set; }
        public string CustomData { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual BillRecored BillIrerfrncNavigation { get; set; }
        public virtual ICollection<RefundProductDetail> RefundProductDetails { get; set; }
    }
}
