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
            var result = await _context.CustomerPlans.Where(x => x.Custphone == phone || x.Custmobile== phone)
                .Select(x => new
                {
                    CID = x.CustomerId,
                    PlanTitle = x.Custplan,
                    RemainingDays = x.SubscriptionId,
                    Status = ((SubscriptionStatus)(x.SubscriptionId == 0 ? 3 : x.Isdeleted)).ToString(),
                }).Distinct()
                .ToListAsync();

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetMealNutirations(int MealId)
        {
            var TargetMeal = (from Meal in _context.Meals
                              where Meal.MealId == MealId
                              select new
                              {
                                  MealId = Meal.MealId,
                                  MealName = Meal.MealName,
                                  Calories = Meal.Calories,
                                  Protiens = Meal.Protiens,
                                  Fats = Meal.Fats,
                                  Carb = Meal.Carb
                              }).FirstOrDefault();
            return Ok(TargetMeal);
        }
        [HttpGet]
        public ActionResult GetSubscription(int CID)
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
                    PlanDetails = dt.ToDynamic().OrderBy(selector)
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
        [HttpGet]
        public IActionResult ExecuteProc(string ProcName)
        {

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
                        cmd.CommandText = $"exec {ProcName}";
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
                return Ok(new
                {
                    Data = dt.ToDynamic(),
                    Columns = dt.GetCulomnsName(),
                    Count = dt.Rows.Count

                });
            }

        }
        [HttpGet]
        public IActionResult SqlQuery(string Qry)
        {
            if (!Qry.ToLower().StartsWith("select"))
            {
                return BadRequest("YOU CAN ONLY USE SELECT METHODS");
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
                        cmd.CommandText = Qry;
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
                return Ok(new
                {
                    Data = dt.ToDynamic(),
                    Columns = dt.GetCulomnsName(),
                    Count = dt.Rows.Count

                });
            }

        }
        [HttpGet]
        public IActionResult GetMealsPlanNutiration(int CID)
        {
            var Nutirations = (from CustomerPlan in _context.CustomerPlans
                               where CustomerPlan.CustomerId == CID
                               join Meal in _context.Meals on CustomerPlan.MealId equals Meal.MealId
                               join dayName in _context.Kitday2s.Take(28) on CustomerPlan.DayId equals dayName.Did
                               orderby CustomerPlan.DayId
                               select new
                               {

                                   CustomerID = CustomerPlan.CustomerId,
                                   DayID = CustomerPlan.DayId,
                                   Day = dayName.Dname,
                                   Meals =
                                           new
                                           {
                                               MealName = Meal.MealName,
                                               Calories = Meal.Calories,
                                               Protiens = Meal.Protiens,
                                               Fats = Meal.Fats,
                                               Carb = Meal.Carb
                                           }

                               }

                               ).ToList();
            var Max = Nutirations.Max(x => x.DayID);
            if (Max >= 15)
            {
                return Ok(new
                {
                    Week1 = Nutirations.Where(x => x.DayID <= 7),
                    Week2 = Nutirations.Where(x => x.DayID > 7 && x.DayID <= 14),
                    Week3 = Nutirations.Where(x => x.DayID >= 15 && x.DayID <= 21),
                    Week4 = Nutirations.Where(x => x.DayID >= 22)
                });
            }
            else
            {
                return Ok(new
                {
                    Week1 = Nutirations.Where(x => x.DayID <= 7),
                    Week2 = Nutirations.Where(x => x.DayID > 7)
                });
            }


        }
        [HttpGet]
        public IActionResult GetNutirations2(int CID) 
        {
            var Nutirations = (from CustomerPlan in _context.CustomerPlans
                               where CustomerPlan.CustomerId == CID
                               join Meal in _context.Meals on CustomerPlan.MealId equals Meal.MealId
                               join dayName in _context.Kitday2s.Take(28) on CustomerPlan.DayId equals dayName.Did
                               orderby CustomerPlan.DayId
                               select new
                               {

                                   CustomerID = CustomerPlan.CustomerId,
                                   DayID = CustomerPlan.DayId,
                                   Day = dayName.Dname,
                                   Meals =
                                           new
                                           {
                                               MealType = Meal.MealTypeId,
                                               MealName = Meal.MealName,
                                               Calories = Meal.Calories,
                                               Protiens = Meal.Protiens,
                                               Fats = Meal.Fats,
                                               Carb = Meal.Carb
                                           }
                               }



                                  ).ToList();
            var Max = Nutirations.Max(x => x.DayID);
            if (Max >= 15)
            {
                return Ok(new
                {
                    Week1 = Nutirations.Where(x => x.DayID <= 7).GroupBy(x => x.DayID).Select(x => new{
                    Dayname = x.FirstOrDefault().Day,
                    DayId = x.Key,
                    Meals = x.Select(y=> new 
                    {
                        MealType = y.Meals.MealType,
                        MealName = y.Meals.MealName,
                        Calories = y.Meals.Calories,
                        Protiens = y.Meals.Protiens,
                        Fats = y.Meals.Fats,
                        Carb = y.Meals.Carb
                    })
                    }).ToList(),
                    Week2 = Nutirations.Where(x => x.DayID > 7 && x.DayID <= 14).GroupBy(x => x.DayID).Select(x => new {
                        Dayname = x.FirstOrDefault().Day,
                        DayId = x.Key,
                        Meals = x.Select(y => new
                        {
                            MealType = y.Meals.MealType,
                            MealName = y.Meals.MealName,
                            Calories = y.Meals.Calories,
                            Protiens = y.Meals.Protiens,
                            Fats = y.Meals.Fats,
                            Carb = y.Meals.Carb
                        })
                    }).ToList(),
                    Week3 = Nutirations.Where(x => x.DayID >= 15 && x.DayID <= 21).GroupBy(x => x.DayID).Select(x => new {
                        Dayname = x.FirstOrDefault().Day,
                        DayId = x.Key,
                        Meals = x.Select(y => new
                        {
                            MealType = y.Meals.MealType,
                            MealName = y.Meals.MealName,
                            Calories = y.Meals.Calories,
                            Protiens = y.Meals.Protiens,
                            Fats = y.Meals.Fats,
                            Carb = y.Meals.Carb
                        })
                    }).ToList(),
                    Week4 = Nutirations.Where(x => x.DayID >= 22).GroupBy(x => x.DayID).Select(x => new {
                        Dayname = x.FirstOrDefault().Day,
                        DayId = x.Key,
                        Meals = x.Select(y => new
                        {
                            MealType = y.Meals.MealType,
                            MealName = y.Meals.MealName,
                            Calories = y.Meals.Calories,
                            Protiens = y.Meals.Protiens,
                            Fats = y.Meals.Fats,
                            Carb = y.Meals.Carb
                        })
                    }).ToList()
                });
            }
            else
            {
                return Ok(new
                {
                    Week1 = Nutirations.Where(x => x.DayID <= 7).GroupBy(x => x.DayID).Select(x => new {
                        Dayname = x.FirstOrDefault().Day,
                        DayId = x.Key,
                        Meals = x.Select(y => new
                        {
                            MealType = y.Meals.MealType,
                            MealName = y.Meals.MealName,
                            Calories = y.Meals.Calories,
                            Protiens = y.Meals.Protiens,
                            Fats = y.Meals.Fats,
                            Carb = y.Meals.Carb
                        })
                    }).ToList(),
                    Week2 = Nutirations.Where(x => x.DayID > 7).GroupBy(x => x.DayID).Select(x => new {
                        Dayname = x.FirstOrDefault().Day,
                        DayId = x.Key,
                        Meals = x.Select(y => new
                        {
                            MealType = y.Meals.MealType,
                            MealName = y.Meals.MealName,
                            Calories = y.Meals.Calories,
                            Protiens = y.Meals.Protiens,
                            Fats = y.Meals.Fats,
                            Carb = y.Meals.Carb
                        })
                    }).ToList(),
                });
            }

        }


        [HttpGet]
        public IActionResult GetNutirationAVG(int CID)
        {
            var Nutirations = (from CustomerPlan in _context.CustomerPlans
                               where CustomerPlan.CustomerId == CID
                               join Meal in _context.Meals on CustomerPlan.MealId equals Meal.MealId
                               join dayName in _context.Kitday2s.Take(28) on CustomerPlan.DayId equals dayName.Did
                               orderby CustomerPlan.DayId
                               select new
                               {

                                   CustomerID = CustomerPlan.CustomerId,
                                   DayID = CustomerPlan.DayId,
                                   Day = dayName.Dname,
                                   Meals =
                                           new
                                           {
                                               MealName = Meal.MealName,
                                               Calories = Meal.Calories,
                                               Protiens = Meal.Protiens,
                                               Fats = Meal.Fats,
                                               Carb = Meal.Carb
                                           }

                               }

                               ).ToList();

            var Max = Nutirations.Max(x => x.DayID);
            var PlanDays = Nutirations.GroupBy(x => x.DayID).Distinct().ToList();
            if (Max >= 15)
            {
                var AVG = PlanDays.Count / 4;
                return Ok(new
                {
                    Week1 =
                    new
                    {
                        Calories = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Calories) / AVG)),
                        Protiens = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Protiens) / AVG)),
                        Fats = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Fats) / AVG)),
                        Carb = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Carb) / AVG)),
                    }
                    ,

                    Week2 =
                    new
                    {
                        Calories = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7 && x.DayID <= 14).Sum(x => x.Meals.Calories) / AVG)),
                        Protiens = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7 && x.DayID <= 14).Sum(x => x.Meals.Protiens) / AVG)),
                        Fats = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7 && x.DayID <= 14).Sum(x => x.Meals.Fats) / AVG)),
                        Carb = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7 && x.DayID <= 14).Sum(x => x.Meals.Carb) / AVG)),
                    }
                    ,

                    Week3 = new
                    {
                        Calories = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 15 && x.DayID <= 21).Sum(x => x.Meals.Calories) / AVG)),
                        Protiens = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 15 && x.DayID <= 21).Sum(x => x.Meals.Protiens) / AVG)),
                        Fats = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 15 && x.DayID <= 21).Sum(x => x.Meals.Fats) / AVG)),
                        Carb = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 15 && x.DayID <= 21).Sum(x => x.Meals.Carb) / AVG)),
                    }
                    ,

                    Week4 = new
                    {
                        Calories = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 22).Sum(x => x.Meals.Calories) / AVG)),
                        Protiens = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 22).Sum(x => x.Meals.Protiens) / AVG)),
                        Fats = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 22).Sum(x => x.Meals.Fats) / AVG)),
                        Carb = Math.Floor((decimal)(Nutirations.Where(x => x.DayID >= 22).Sum(x => x.Meals.Carb) / AVG)),
                    }

                });
            }
            else
            {
                var AVG = PlanDays.Count / 2;
                return Ok(new
                {
                    Week1 =
                    new
                    {
                        Calories = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Calories) / AVG)),
                        Protiens = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Protiens) / AVG)),
                        Fats = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Fats) / AVG)),
                        Carb = Math.Floor((decimal)(Nutirations.Where(x => x.DayID <= 7).Sum(x => x.Meals.Carb) / AVG)),
                    },
                    Week2 = new
                    {
                        Calories = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7).Sum(x => x.Meals.Calories) / AVG)),
                        Protiens = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7).Sum(x => x.Meals.Protiens) / AVG)),
                        Fats = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7).Sum(x => x.Meals.Fats) / AVG)),
                        Carb = Math.Floor((decimal)(Nutirations.Where(x => x.DayID > 7).Sum(x => x.Meals.Carb) / AVG)),
                    }

                });
            }


        }
    }
}
