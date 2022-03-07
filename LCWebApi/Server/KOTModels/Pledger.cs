using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Pledger
    {
        public int Id { get; set; }
        public int? Cid { get; set; }
        public string Name { get; set; }
        public string Jname { get; set; }
        public DateTime? Datej { get; set; }
        public string Planc { get; set; }
        public string Mainbranch { get; set; }
        public double? Amount { get; set; }
        public string Pickupbranch { get; set; }
        public int? Meals { get; set; }
        public double? Amountmatch { get; set; }
        public string Custpho { get; set; }
        public string Comm1 { get; set; }
        public string Comm2 { get; set; }
        public string Comm3 { get; set; }
        public string Comm4 { get; set; }
    }
}
