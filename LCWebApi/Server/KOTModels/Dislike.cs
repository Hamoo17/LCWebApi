using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class Dislike
    {
        public int Id { get; set; }
        public int? Oldmid { get; set; }
        public int? Newmid { get; set; }
        public int? Nobeans { get; set; }
        public int? Nofish { get; set; }
        public int? Nosteak { get; set; }
        public int? Noshrimp { get; set; }
        public int? Noegg { get; set; }
        public string Mealna { get; set; }
        public decimal? Calories { get; set; }
        public decimal? Protiens { get; set; }
        public decimal? Fats { get; set; }
        public decimal? Carb { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? MealTypeId { get; set; }
        public int? DayId { get; set; }
        public string Mealtypename { get; set; }
        public string Comment2 { get; set; }
    }
}
