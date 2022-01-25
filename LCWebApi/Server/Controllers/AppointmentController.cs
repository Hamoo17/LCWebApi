using LCWebApi.Server.Features.Appointment;
using LCWebApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LCWebApi.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AppointmentController : ControllerBase
    {
        private protected lowcalor_lowcaloriesdbContext _db;
        Appointment cls;

        public AppointmentController(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
            cls = new Appointment(db);
        }
        [HttpGet]
        public async Task<IActionResult> GetAvilableTime(DateTime Date, int EmId)
        {
            return Ok(await cls.GetAvilableTime(Date, EmId));
        }
    }
}
