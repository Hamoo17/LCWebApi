using System;

namespace LCWebApi.Server.KOTModels
{
    public partial class GetNutritions_Result
    {
        public int CustomerID { get; set; }
        public int DayID { get; set; }
        public string MealName { get; set; }
        public Nullable<decimal> Calories { get; set; }
        public Nullable<decimal> Protiens { get; set; }
        public Nullable<decimal> Fats { get; set; }
        public Nullable<decimal> Carb { get; set; }
    }
}
