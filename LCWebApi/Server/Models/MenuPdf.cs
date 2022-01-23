using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class MenuPdf
    {
        public long Id { get; set; }
        public string PdfLink { get; set; }
    }
}
