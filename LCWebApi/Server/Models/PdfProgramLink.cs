using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class PdfProgramLink
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public string Link { get; set; }
    }
}
