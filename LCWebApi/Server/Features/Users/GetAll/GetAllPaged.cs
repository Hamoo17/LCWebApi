using LCWebApi.Server.Extentions;
using LCWebApi.Server.Models;
using LCWebApi.Shared.Wrapper;
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
    }
}
