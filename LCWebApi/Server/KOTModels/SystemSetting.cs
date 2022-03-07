using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class SystemSetting
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopContact { get; set; }
        public string BillTermsAndConditions { get; set; }
        public string RefundTermsAndConditions { get; set; }
        public string ThanksNote { get; set; }
        public string FromEmailAddress { get; set; }
        public string ToEmailAddress { get; set; }
        public string Password { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpPort { get; set; }
        public bool IsSmptSsl { get; set; }
        public bool IsSmptAuthRequired { get; set; }
        public string CustomData { get; set; }
    }
}
