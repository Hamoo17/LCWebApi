using LCWebApi.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsersController : Controller
    {
        private protected lowcalor_lowcaloriesdbContext _db;
        LCWebApi.Server.Features.Users.GetAll.GetAllPaged cls;

        public UsersController(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
            cls = new Features.Users.GetAll.GetAllPaged(_db);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserCids(int userID)
        {
            return Ok(await cls.GetUserCids(userID));
        }
    }
}
