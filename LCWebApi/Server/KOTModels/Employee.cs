using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Employee
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public int? ShiftId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? Isdeleted { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
