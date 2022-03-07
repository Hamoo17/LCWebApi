using LCWebApi.Server.Extentions;
using LCWebApi.Server.KOTModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
using static LCWebApi.Shared.EnumsCls;

namespace LCWebApi.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private protected KOTDbContext _context;

        public SubscriptionController(KOTDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetCid(string phone) 
        {
            var result = await _context.CustomerPlans.Where(x=>x.Custphone.Contains(phone) || x.Custmobile.Contains(phone))
                .Select(x => new
                {
                    CID = x.CustomerId,
                    PlanTitle = x.Custplan,
                    RemainingDays = x.SubscriptionId,
                    Status = ((SubscriptionStatus)(x.SubscriptionId==0? 3: x.Isdeleted)).ToString(),
                }).Distinct()
                .ToListAsync();

        return Ok(result);
        }
        [HttpGet]
        public ActionResult GetSubscription(int CID)
        {
            var PlanDetails =  _context.CustomerPlans.Where(x => x.CustomerId == CID)
                .Select(x => new
                {
                    CID = x.CustomerId,
                    PlanTitle = x.Custplan,
                    RemainingDays = x.SubscriptionId,
                    Status = ((SubscriptionStatus)(x.SubscriptionId == 0 ? 3 : x.Isdeleted)).ToString(),
                }).Distinct()
                .FirstOrDefault();
            if (PlanDetails == null)
            {
                return BadRequest(new { Message = $"No Data Found For This CID: {CID}" });
            }
            using (var context = _context)
            {
                var dt = new DataTable();

                var conn = context.Database.GetDbConnection();
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        if (PlanDetails.Status == "ACTIVE")
                        {
                            cmd.CommandText = $"exec PLANWithDate @CCID= {CID}";
                        }
                        else
                        {
                            cmd.CommandText = $"exec PLANDays @CCID= {CID}";
                        }
                       
                        //  cmd.CommandType = CommandType.StoredProcedure;
                        //  cmd.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }
                 
                dt.DefaultView.Sort = "dayName ASC";
                dt = dt.DefaultView.ToTable();
                Func<dynamic, object> selector = PlanDetails.Status == "ACTIVE" ? x => x.DeliveryDate : x => x.dayid;
                return Ok(new
                {
                    PlanInfo = PlanDetails,
                    Columns = dt.GetCulomnsName(),
                     PlanDetails =dt.ToDynamic().OrderBy(selector)
                });     
            }

            
        }
        [HttpGet]
        public IActionResult GetMainPlan(int CID)
        {
            var PlanDetails = _context.CustomerPlans.Where(x => x.CustomerId == CID)
             .Select(x => new
             {
                 CID = x.CustomerId,
                 PlanTitle = x.Custplan,
                 RemainingDays = x.SubscriptionId,
                 Status = ((SubscriptionStatus)(x.SubscriptionId == 0 ? 3 : x.Isdeleted)).ToString(),
             }).Distinct()
             .FirstOrDefault();
            if (PlanDetails == null)
            {
                return BadRequest(new { Message = $"No Data Found For This CID: {CID}" });
            }
            using (var context = _context)
            {
                var dt = new DataTable();

                var conn = context.Database.GetDbConnection();
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                            cmd.CommandText = $"exec PLANDays @CCID= {CID}";
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }
                
                dt.DefaultView.Sort = "dayName ASC";
                dt = dt.DefaultView.ToTable();
               

                return Ok(new
                {
                    PlanInfo = PlanDetails,
                    Columns = dt.GetCulomnsName(),
                    PlanDetails = dt.ToDynamic().OrderBy(x => x.dayid),
                   
                });
            }

        }
    }
}
