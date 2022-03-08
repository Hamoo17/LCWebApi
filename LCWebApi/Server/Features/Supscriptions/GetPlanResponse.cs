namespace LCWebApi.Server.Features.Supscriptions
{
    public class GetPlanResponse
    {
        public int PlanID { get; set; }
        public string DayName { get; set; }
        public string MealType { get; set; }
        public string MealName { get; set; }
        public int MealID { get; set; }
    }
}
