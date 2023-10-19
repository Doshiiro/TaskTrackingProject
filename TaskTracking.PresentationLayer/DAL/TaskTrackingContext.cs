﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.PresentationLayer.Entities;

namespace TaskTracking.PresentationLayer.DAL
{
    public class TaskTrackingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-ONGKPN7; Initial Catalog = TaskTrackingDB; Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees{ get; set; }

    }
}