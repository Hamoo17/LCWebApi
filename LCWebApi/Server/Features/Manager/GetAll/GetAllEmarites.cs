using LCWebApi.Server.Features.Manager.Response;
using LCWebApi.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Manager.GetAll
{
    public class GetAllEmarites
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public GetAllEmarites(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }
        public async Task<List<AllEmaritsResponse>> GetAll() 
        {
            return await _db.Emirates.Select(x => new AllEmaritsResponse { Id = x.Id, EmariteName = x.EnName }).ToListAsync();
        }
    }
}
