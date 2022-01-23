using LCWebApi.Server.Extentions;
using LCWebApi.Server.Models;
using LCWebApi.Shared.Wrapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Users.GetAll
{

    public class GetAllPaged
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public GetAllPaged(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }

        public async Task<PaginatedResult<User>> GetUsersAllPaged(int pagezise, int pagenumber)
        {
            return await _db.Users.ToPaginatedListAsync(pagenumber, pagezise);
        }

        public async Task<IResult<List<string>>> GetUserCids(int userID)
        {
            var data = await _db.UserCids.Where(x => x.UserId == userID).Select(x => x.Cid).ToListAsync();
            if (data == null || data.Count == 0)
            {
                return Result<List<string>>.Fail("There Is No CIDs For This User ID");
            }
            return await Result<List<string>>.SuccessAsync(data) ;
        }
    }
}
