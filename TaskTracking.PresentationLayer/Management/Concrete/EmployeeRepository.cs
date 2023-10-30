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
        public async Task Create(Employee entity)
        {
            using (var context = new TaskTrackingContext())
            {
                context.Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (var context = new TaskTrackingContext())
            {
                var employee = await context.Employees.FindAsync(id);

                if (employee != null)
                {
                    context.Remove(employee);
                    await context.SaveChangesAsync();
                }
            }
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

            try
            {
                using (var context = new TaskTrackingContext())
                {
                    Employee data = context.Employees.FirstOrDefault(u => u.UserName == entity.UserName && u.Password == entity.Password);
                    return data;
                }
            }
            catch (Exception)
            {
                //veri tabanı kapalı
                throw;
            }

        }

        public Task Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
