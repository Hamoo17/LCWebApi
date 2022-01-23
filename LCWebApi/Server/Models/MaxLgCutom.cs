using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class MaxLgCutom
    {
        public long Id { get; set; }
        public int LossMax { get; set; }
        public int GainMax { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
