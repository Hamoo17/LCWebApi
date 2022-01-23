﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCWebApi.Server.Models;
using LCWebApi.Shared.Wrapper;
using LCWebApi.Server.Extentions;

namespace LCWebApi.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : Controller
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public TestController(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> test(int pageNumber, int pageSize)
        {

            return Ok(await _db.Users.ToPaginatedListAsync(pageNumber, pageSize));
        }
    }
}
