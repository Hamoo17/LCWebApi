using System.ComponentModel.DataAnnotations;

namespace LCWebApi.Server.Features.Supscriptions
{
    public class PlanRequest
    {
  
        public int PlanID { get; set; }
        public int?[] MealType { get; set; }
        public int?[] DeliveryDays { get; set; }
    }
}
