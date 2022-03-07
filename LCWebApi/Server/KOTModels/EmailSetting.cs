using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class EmailSetting
    {
        public int Id { get; set; }
        public string SenderPassword { get; set; }
        public bool IsHtml { get; set; }
        public string SenderEmail { get; set; }
        public int PortNumber { get; set; }
        public string Smtp { get; set; }
        public bool Ssl { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string DisplayName { get; set; }
    }
}
