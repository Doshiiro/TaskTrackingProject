using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.PresentationLayer.Entities;

namespace TaskTracking.PresentationLayer.DAL
{

    public class TaskTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-ONGKPN7; Initial Catalog = TaskTrackingDB; Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=True;");
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<CalendarEntity> Calendars { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Calendars)
                .WithOne(c => c.Employees)
                .HasForeignKey(c => c.emp_ID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Projects)
                .WithOne(p => p.Employees)
                .HasForeignKey(p => p.projectEmp_ID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<ProjectEntity>()
                .HasOne(p => p.Department)
                .WithMany(d => d.Projects)
                .HasForeignKey(p => p.DepartmentID);

        }
    }
}
