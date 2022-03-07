using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class AppUser
    {
        public AppUser()
        {
            BillRecoreds = new HashSet<BillRecored>();
            Expenses = new HashSet<Expense>();
            RefundDetails = new HashSet<RefundDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Roles { get; set; }
        public string Password { get; set; }
        public string CustomData { get; set; }
        public int Location { get; set; }

        public virtual ICollection<BillRecored> BillRecoreds { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<RefundDetail> RefundDetails { get; set; }
    }
}
