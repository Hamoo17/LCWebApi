using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class NewMenu
    {
        public long Id { get; set; }
        public string MealName { get; set; }
        public string MealNameAr { get; set; }
        public string MealDescription { get; set; }
        public string MealDiscriptionAr { get; set; }
        public string MealPrice { get; set; }
        public string MealType { get; set; }
        public int? MealNumber { get; set; }
        public int? MealCalories { get; set; }
        public int MealCarb { get; set; }
        public string MealUnit { get; set; }
        public string Img { get; set; }
        public sbyte Popular { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
