using LCWebApi.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Manager.GetAll
{
    public class GetPaymentMethods
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public GetPaymentMethods(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }


        public async Task<List<string>> GetALL() 
        {
            return await _db.Subscriptions.Select(x => x.SubFrom).Distinct().ToListAsync();

        }
    }
}
