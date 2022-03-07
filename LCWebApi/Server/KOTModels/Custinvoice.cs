using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Custinvoice
    {
        public string Custid { get; set; }
        public string Custname { get; set; }
        public string Custbranch { get; set; }
        public string Custplanename { get; set; }
        public string Custphone { get; set; }
        public string Custmobile { get; set; }
        public string Custemail { get; set; }
        public string Datecreate { get; set; }
        public string Custaddress { get; set; }
        public string Startday { get; set; }
        public string Planetype { get; set; }
        public string Noofdays { get; set; }
        public string Remainingmeals { get; set; }
        public string Priceend { get; set; }
        public string Discountpercnt { get; set; }
        public string Planemprice { get; set; }
        public string Addedsnacks { get; set; }
        public string Discvalue { get; set; }
        public string Pricewithoutdisc { get; set; }
        public string Payby { get; set; }
        public string Transno { get; set; }
    }
}
