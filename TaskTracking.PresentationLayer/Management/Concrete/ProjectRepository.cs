using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Abstract;

namespace TaskTracking.PresentationLayer.Management.Concrete
{
    public class ProjectRepository : IGenericRepository<ProjectEntity>
    {
        public async Task Create(ProjectEntity entity)
        {
            using (var context = new TaskTrackingContext())
            {
                context.Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectEntity> GetAll()
        {
            using (var context = new TaskTrackingContext())
            {
                List<ProjectEntity> data = context.Projects.ToList();
                return data;
            }
        }

        public Task<ProjectEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProjectEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
