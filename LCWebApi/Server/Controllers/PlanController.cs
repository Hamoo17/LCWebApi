using LCWebApi.Server.Features.Supscriptions;
using LCWebApi.Server.KOTModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LCWebApi.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private protected KOTDbContext _context;
        private protected GetSetPlan _plan;

        public PlanController(KOTDbContext context)
        {
            _context = context;
            _plan = new GetSetPlan(_context);
        }
        [HttpGet]
        public IActionResult GetPLan([FromQuery] int PlanID, [FromQuery] int?[] MealsType, [FromQuery] int?[] DeliveryDays)
        {
            PlanRequest request = new PlanRequest();
            request.PlanID = PlanID;
            request.DeliveryDays = DeliveryDays;
            request.MealType = MealsType;
            return Ok(_plan.GetPlan(request));
        }

    }
}
