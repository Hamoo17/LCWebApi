
using LCWebApi.Server.KOTModels;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LCWebApi.Server.Features.Supscriptions
{
    public class GetSetPlan
    {
        private protected KOTDbContext _context;

        public GetSetPlan(KOTDbContext context)
        {
            _context = context;
        }
        public List<GetPlanResponse> GetPlan(PlanRequest request)
        {
            Expression<Func<SubscriptionDetail, bool>> Criteria = (x => x.SubscriptionId == request.PlanID);
            if (request.MealType.Length > 0)
            {
                Criteria = Criteria.And(x => request.MealType.Contains(x.MealTypeId));
            }
            if (request.DeliveryDays.Length > 0)
            {
                var Dayids = new int[request.DeliveryDays.Length * 4];
                int n = 0;
                foreach (var day in request.DeliveryDays)
                {
                    var d = day.Value;
                    Dayids[n] = d;
                    for (int i = 1; i <= 3; i++)
                    {

                        Dayids[n + 1] = Dayids[n] + 7;
                        n++;
                    }
                    n++;
                }
                Criteria = Criteria.And(x => Dayids.Contains(x.DayId));
            }

            var result = (from SubscriptionDetail in _context.SubscriptionDetails.Where(Criteria)
                          join MealTypes in _context.MealTypes on SubscriptionDetail.MealTypeId equals MealTypes.TypeId
                          join Ketday in _context.Kitday2s.Take(28) on SubscriptionDetail.DayId equals Ketday.Did
                          join Meals in _context.Meals on SubscriptionDetail.MealId equals Meals.MealId
                          orderby SubscriptionDetail.DayId, SubscriptionDetail.MealTypeId
                          select new GetPlanResponse
                          {
                              DayName = Ketday.Dname,
                              MealName = Meals.MealName,
                              MealType = MealTypes.TypeName,
                              MealID = Meals.MealId,
                              PlanID = SubscriptionDetail.SubscriptionId
                          }).ToList();

            return result;

        }
    }
}
