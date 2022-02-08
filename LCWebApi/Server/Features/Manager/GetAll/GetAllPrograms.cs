using LCWebApi.Server.Features.Manager.Response;
using LCWebApi.Server.MealsModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Manager.GetAll
{
    public class GetAllPrograms
    {
        private protected lowcalories_mealsContext _db;

        public GetAllPrograms(lowcalories_mealsContext db)
        {
            _db = db;
        }
        public async Task<List<AllProgramsResponse>> GetAll() 
        {
            return await _db.Programs.Select(x => new AllProgramsResponse {Id = x.Id , Company = x.Company , Name = x.Name , ProgramType = x.Type , ShortcutName = x.ShortcutName }).ToListAsync();
        }
    }
}
