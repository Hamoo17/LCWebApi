using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class SysProgram
    {
        public long Id { get; set; }
        public int Active { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
        public string EnDescription { get; set; }
        public string ArDescription { get; set; }
        public string Img { get; set; }
        public long? OrderBy { get; set; }
        public string NumberSnacks { get; set; }
        public string MaxMeals { get; set; }
        public string MinMeals { get; set; }
    }
}
