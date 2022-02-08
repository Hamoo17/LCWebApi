using LCWebApi.Server.Features.Manager.Response;
using LCWebApi.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Manager.GetAll
{
    public class GetBranches
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public GetBranches(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }
        public async Task<List<AllBranchesResponse>> GetAllBranches() 
        {
            return await _db.AgentBranches.Select(x => new AllBranchesResponse {Id = x.Id , BranchName = x.Name }).ToListAsync();
        }
    }
}

