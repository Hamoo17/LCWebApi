using System;
using System.Collections.Generic;
using static LCWebApi.Shared.EnumsCls;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class GiftCode
    {
        //public GiftCode()
        //{
        //   // GiftCodePrograms = new HashSet<GiftCodeProgram>();
        //}

        public int Id { get; set; }
        public string Code { get; set; }
        public CodeState Status { get; set; }
        public string Percentage { get; set; }
        public string NoOfUse { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<GiftCodeProgram> GiftCodePrograms { get; set; }
    }
}
