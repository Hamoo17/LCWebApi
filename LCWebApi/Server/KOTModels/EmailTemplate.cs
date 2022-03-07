using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public string AutomatedTime { get; set; }
        public byte[] ImageAttachment { get; set; }
        public string HtmlBody { get; set; }
        public string Subject { get; set; }

        public virtual Template Template { get; set; }
    }
}
