using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Management.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
    }
}
