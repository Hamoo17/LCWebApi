using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Dailyreo
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public int Phone { get; set; }
        public string Request { get; set; }
        public string Details { get; set; }
        public string Permissioncode { get; set; }
        public int? Cid { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string Driver { get; set; }
        public string Payment { get; set; }
        public string Amount { get; set; }
        public string Remarks { get; set; }
        public string Note { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Note4 { get; set; }
        public string Note5 { get; set; }
        public string Note6 { get; set; }
    }
}
