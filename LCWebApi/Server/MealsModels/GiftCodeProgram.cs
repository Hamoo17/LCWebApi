using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class GiftCodeProgram
    {
        public int Id { get; set; }
        public int CodeId { get; set; }
        public int ProgramId { get; set; }

        public virtual GiftCode Code { get; set; }
        public virtual Program Program { get; set; }
    }
}
