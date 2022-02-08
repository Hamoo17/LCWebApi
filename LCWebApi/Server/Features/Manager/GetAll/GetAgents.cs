using LCWebApi.Server.Features.Manager.Response;
using LCWebApi.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Manager.GetAll
{
    public class GetAgents
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public GetAgents(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }
        public async Task<List<AllAgentsResponse>> GetAllAgents() 
        {
            return await _db.Agents.Select(x=> new AllAgentsResponse {AgentID = x.AgentId , AgentName = x.Name } ).ToListAsync();
        }
    }
}
