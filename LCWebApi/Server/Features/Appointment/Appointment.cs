using LCWebApi.Server.dtoModels;
using LCWebApi.Server.Models;
using LCWebApi.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LCWebApi.Server.Features.Appointment
{
    public class Appointment
    {
        private protected lowcalor_lowcaloriesdbContext _db;

        public Appointment(lowcalor_lowcaloriesdbContext db)
        {
            _db = db;
        }
        public async Task<IResult<List<EmirateAppointmentTime>>> GetAvilableTime(DateTime Date, int EmarateID) 
        {

            var AvalableEmarate = _db.EmirateAppointments.Where(x => x.Date.Date == Date && x.EmaraId == EmarateID).FirstOrDefault();
            if (AvalableEmarate == null)
            {
               return await Result<List<EmirateAppointmentTime>>.FailAsync("No Avilable Time On this Date");
            }
            var appointed = _db.Subscriptions.Where(x => x.PlanId == 60 && x.Mode == 2).ToList();
            var busyList = new List<EmirateAppointmentTime>();
            foreach (var item in appointed)
            {
                var note = item.SubscriptionsNote.Split();
                if (DateTime.Parse(note[6]).Date == Date.Date)
                {
                    var from = note[7];
                    var appointedid = _db.EmirateAppointmentTimes.Where(x => x.EmirateAppointmentId == EmarateID && x.TimeFrom == $"{note[8]} {note[9]}").FirstOrDefault();
                    busyList.Add(appointedid);
                }
            }
            var Avalible = _db.EmirateAppointmentTimes.Where(x=>x.EmirateAppointmentId == EmarateID).ToList();
            foreach (var item in busyList)
            {
                Avalible.RemoveAll(x => x.Id == item.Id);
            }
            return await Result<List<EmirateAppointmentTime>>.SuccessAsync(Avalible);
        }

        public async Task<IResult<List<AppointmentModel>>> GetAppointments() 
        {
            Expression<Func<Subscription, bool>> Criteria = (x => x.Id != 0);

            return await Result<List<AppointmentModel>>.SuccessAsync(new List<AppointmentModel>());
        }
    }
}
