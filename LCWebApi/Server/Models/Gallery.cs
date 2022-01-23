using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Gallery
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public ulong? ProgramId { get; set; }
    }
}
