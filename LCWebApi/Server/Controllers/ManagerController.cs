using LCWebApi.Server.Features.Manager.GetAll;
using LCWebApi.Server.Models;
using LCWebApi.Server.MealsModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using LCWebApi.Server.Features.Manager.Requests;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using LCWebApi.Server.Features.Manager.Response;
using LCWebApi.Server.Reports;
using System.IO;
using System;

namespace LCWebApi.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private protected lowcalor_lowcaloriesdbContext _db;
        private protected lowcalories_mealsContext _db2;
        private protected GetAgents agents;
        private protected GetAllPrograms programs;
        private protected GetAllSubscriptions subscriptions;
        private protected GetBranches branches;
        private protected GetPaymentMethods paymentMethods;
        private protected GetAllEmarites Emarits;

        public ManagerController(lowcalor_lowcaloriesdbContext db, lowcalories_mealsContext db2)
        {
            _db = db;
            _db2 = db2;
            agents = new GetAgents(db);
            programs = new GetAllPrograms(db2);
           subscriptions = new GetAllSubscriptions(db , db2);
            branches = new GetBranches(db);
            paymentMethods = new GetPaymentMethods(db);
            Emarits = new GetAllEmarites(db);
        }

        [HttpGet]
      
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _db.Subscriptions.Take(20).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBranches()
        {
            return Ok(await branches.GetAllBranches());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAgents()
        {
            return Ok(await agents.GetAllAgents());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPrograms()
        {
            return Ok(await programs.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMethods()
        {
            return Ok(await paymentMethods.GetALL());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmarits()
        {
            return Ok(await Emarits.GetAll());
        }

        [HttpPost("{type}")]
        public IActionResult Export(List<AllSubscriptionsResponse>allSubscriptions ,int type) 
        {
            var rpt = new SubscriptionReport();
            rpt.DataSource = allSubscriptions;
            MemoryStream ms = new MemoryStream();
            if (type == 1)
            {
                rpt.ExportToPdf(ms);
            }
            if (type == 2)
            {
                rpt.ExportToXlsx(ms);
            }
            var data = ms.ToArray();
            return Ok(Convert.ToBase64String(data));
        }
        [HttpPost]
        public async Task<IActionResult> GetAllSubscriptions(dtoGetAllRequest request , int pageSize = 100 , int pageNumber = 1)
        {
            return Ok(await subscriptions.GetAll(pageSize , pageNumber , request));
        }
    }
}
