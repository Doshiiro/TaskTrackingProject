using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Abstract;

namespace TaskTracking.PresentationLayer.Management.Concrete
{
    public class EmployeeRepository : IGenericRepository<Employee>
    {
        public Task Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            using (var context = new TaskTrackingContext())
            {
                List<Employee> data = context.Employees.ToList();
                return data;
            }

        }
        public Employee VerifyUser(Employee entity)
        {
            using (var context = new TaskTrackingContext())
            {
                Employee data = context.Employees.FirstOrDefault(u => u.UserName == entity.UserName && u.Password == entity.Password);
                return data;
            }
        }

        public Task Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
