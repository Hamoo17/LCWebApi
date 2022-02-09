using LCWebApi.Server.Extentions;
using LCWebApi.Server.Features.Manager.Requests;
using LCWebApi.Server.Features.Manager.Response;
using LCWebApi.Server.MealsModels;
using LCWebApi.Server.Models;
using LCWebApi.Shared.Wrapper;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Transactions;

namespace LCWebApi.Server.Features.Manager.GetAll
{
    public class GetAllSubscriptions
    {
        private protected lowcalor_lowcaloriesdbContext _db;
        private protected lowcalories_mealsContext _db2;

        public GetAllSubscriptions(lowcalor_lowcaloriesdbContext db, lowcalories_mealsContext db2)
        {
            _db = db;
            _db2 = db2;
        }

        public async Task<PaginatedResult<AllSubscriptionsResponse>> GetAll(int pagezise , int pagenumber , dtoGetAllRequest request) 
        {
            List<MealsModels.GiftCode> codes = new List<MealsModels.GiftCode>();
          Expression<Func<Subscription, bool>> Criteria = (x => x.Id != 0);
            if (request.StartDate != null)
            {
                Criteria = Criteria.And(x => x.DeliveryStartingDay.Date == request.StartDate.Value.Date);
            }
            if (!string.IsNullOrEmpty(request.SubFrom))
            {
                Criteria = Criteria.And(x => x.SubFrom == request.SubFrom);
            }
            if (request.AgentID != null)
            {
                Criteria = Criteria.And(x => x.AgentId == request.AgentID);
            }
            if (request.BranchID != null)
            {
                var AgentID = _db.Agents.Where(x=>x.BranchId == request.BranchID).FirstOrDefault();
                if (AgentID != null)
                Criteria = Criteria.And(x => x.AgentId == AgentID.AgentId);
            }
            if (request.EmariteID != null)
            {
                var location = _db.Locations.Where(x => x.EmirateId == request.EmariteID).Select(x => x.Id).ToList();
                if (location != null)
                Criteria = Criteria.And(x => location.Contains(x.LocationId.Value));
            }
            if ( !string.IsNullOrEmpty(request.InvoiceId))
            {
                Criteria = Criteria.And(x => x.InvoiceNo == request.InvoiceId);
            }
            if (request.DiscountValue != null)
            {
                var v1 = _db.GiftCodes.Where(x => x.Percentage == request.DiscountValue).Select(x => x.Id).ToList();
                var v3 = _db2.GiftCodes.Where(x=>x.Percentage == request.DiscountValue.ToString()).Select(x => x.Id).ToList();
                Criteria = Criteria.And(x=> ((v1.Contains(x.CodeId.Value) && x.Version=="v1") || (v3.Contains(x.CodeId.Value) && x.Version == "v3")));

            }
            if (!string.IsNullOrEmpty(request.GiftCode))
            {
                var v1 = _db.GiftCodes.Where(x => x.Code == request.GiftCode).Select(x => x.Id).ToList();
                var v3 = _db2.GiftCodes.Where(x => x.Code == request.GiftCode).Select(x => x.Id).ToList();
                Criteria = Criteria.And(x => (v1.Contains(x.CodeId.Value) && x.Version == "v1") || (v3.Contains(x.CodeId.Value) && x.Version == "v3"));
            }
            if (!string.IsNullOrEmpty(request.MobileNumber))
            {
                var User = _db.Users.Where(x=>x.PhoneNumber == request.MobileNumber || x.SecondPhoneNumber == request.MobileNumber).FirstOrDefault();
                if (User != null) 
                {
                    Criteria = Criteria.And(x => x.UserId == User.Id);
                }
                
            }
            if (!string.IsNullOrEmpty(request.Plan ))
            {
                Criteria = Criteria.And(x => x.SubscriptionsNote.Contains(request.Plan) ||x.FullPlanName.Contains(request.Plan));
            }
            if (!string.IsNullOrEmpty(request.Version))
            {
                Criteria = Criteria.And(x => x.Version == request.Version);
            }
            codes = _db2.GiftCodes.ToList();
            var subsbscriptions = await _db.Subscriptions.Where(Criteria).ToListAsync();
            var query  = (from app in subsbscriptions
                          join users in _db.Users on app.UserId equals users.Id into usersTpl
                          join Code in _db.GiftCodes on app.CodeId==null?99:app.CodeId equals Code.Id into CodeTbl
                          join Code2 in _db2.GiftCodes on app.CodeId == null ? 99 : app.CodeId equals Code2.Id into Code2Tbl
                          join Locations in _db.Locations on app.LocationId equals Locations.Id into LocationsTbl
                          join Agent in _db.Agents on app.AgentId equals Agent.AgentId into AgentTpl
                          from Agent in AgentTpl.DefaultIfEmpty()
                          from Code in CodeTbl.DefaultIfEmpty()
                          from Code2 in Code2Tbl.DefaultIfEmpty()
                          from users in usersTpl.DefaultIfEmpty()
                          from Locations in LocationsTbl.DefaultIfEmpty()
                          join Emarite in _db.Emaras on Locations!=null? Locations.EmirateId:0 equals Emarite.Id into EmariteTbl
                          from Emarite in EmariteTbl.DefaultIfEmpty()
                          orderby app.Id descending
                          select new AllSubscriptionsResponse
                                 {
                                     AgentName = app.SubFrom == "mobile" || app.SubFrom == "web" ? "Online" : Agent.Name,
                                     Area = Locations == null?"": Locations.AreaId, 
                                     FullName = users==null?"": $"{users.FirstName} {users.LastName}",
                                     DeliveryStartingDay = app.DeliveryStartingDay,
                                     Mobile = users == null ? "" : users.PhoneNumber,
                                     SubFrom = app.SubFrom,
                                     Id = app.Id,
                                     InvoiceNum = app.InvoiceNo,
                                     Mode = app.Mode.ToString(),
                                     PlanName = app.SubscriptionsNote,
                                     TotalPrice = app.TotalPrice,
                                     Code =  app.Version=="v1"? (Code!=null? Code.Code:String.Empty):(Code2!=null? Code2.Code:String.Empty),
                                     Discount = app.Version == "v1" ? (Code!=null? Code?.Percentage:0) : (Code2!=null?int.Parse(Code2?.Percentage):0),
                                     Emarite= Emarite==null?"": Emarite.EnName
                          });
            //var data = _db.Subscriptions.Where(Criteria)
            //    .Join
            //    (
            //        _db.Users,sub=> sub.UserId,user=>user.Id,
            //        (sub , user)=> new 
            //        {
            //            Users = user,
            //            Subscription = sub
            //        }
            //    ).Join
            //    (
            //         _db.Agents ,sub=> sub.Subscription.AgentId.Value , ag => ag.AgentId ,
            //         (sub , ag)=> new 
            //         {
            //            Agent = ag,
            //            User = sub.Users,
            //            Subscription = sub.Subscription
            //         }
                        
            //    )
            //    .Select(x=> new AllSubscriptionsResponse 
            //    {
            //       AgentName = x.Subscription.SubFrom == "mobile" || x.Subscription.SubFrom == "web" ? "Online" : x.Agent.Name,
            //       Area = x.User.Area,
            //       FullName = $"{x.User.FirstName} {x.User.LastName}",
            //       DeliveryStartingDay = x.Subscription.DeliveryStartingDay,
            //       Mobile = x.User.PhoneNumber,
            //       SubFrom = x.Subscription.SubFrom,
            //       Id = x.Subscription.Id,
            //       Mode = x.Subscription.Mode.ToString(),
            //       PlanName = x.Subscription.SubscriptionsNote,
            //       TotalPrice = x.Subscription.TotalPrice

            //    }).OrderByDescending(x=>x.Id);

            return await query.ToPaginatedListAsync<AllSubscriptionsResponse>(pagenumber,pagezise);

        }
    }
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> ConditionalWhere<T>(this IEnumerable<T> list,
                                                   bool condition, Func<T, bool> predicate)
        {
            if (!condition)
                return list;
            return list.Where(predicate);
        }
    }
}
