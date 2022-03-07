using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Template
    {
        public Template()
        {
            EmailTemplates = new HashSet<EmailTemplate>();
        }

        public int TemplateId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmailTemplate> EmailTemplates { get; set; }
    }
}
