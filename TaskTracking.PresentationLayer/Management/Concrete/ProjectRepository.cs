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
    public class ProjectRepository : IGenericRepository<ProjectRepository>
    {
        public Task Create(ProjectRepository entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectRepository> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectRepository> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProjectRepository entity)
        {
            throw new NotImplementedException();
        }
    }
}
