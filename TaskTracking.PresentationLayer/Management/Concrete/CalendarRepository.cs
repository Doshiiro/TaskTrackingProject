using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Abstract;

namespace TaskTracking.PresentationLayer.Management.Concrete
{
    public class CalendarRepository : IGenericRepository<CalendarEntity>
    {

        public async Task Create(CalendarEntity entity)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                context.Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var calendar = await context.Calendars.FindAsync(id);
                if (calendar != null)
                {
                    context.Remove(calendar);
                    await context.SaveChangesAsync();
                }
            }
        }

        public List<CalendarEntity> GetAll()
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                List<CalendarEntity> datacal = context.Calendars.ToList();
                return datacal;
            }

        }

        public Task<CalendarEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update( CalendarEntity entity)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                context.Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
