using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class AgentBranchDetail
    {
        public int Id { get; set; }
        public int AgentBranchId { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string LandLine { get; set; }
        public string Mobile { get; set; }
        public string HeadChefName { get; set; }
        public string HeadChefPhone { get; set; }
        public string HeadChefWhatsapp { get; set; }
        public string ManagerName { get; set; }
        public string ManagerMobile { get; set; }
        public string ManagerWhatsapp { get; set; }
        public string BankName { get; set; }
        public string BankNumber { get; set; }
        public string BankIban { get; set; }
    }
}
