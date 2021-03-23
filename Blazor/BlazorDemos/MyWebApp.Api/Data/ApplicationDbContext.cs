using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MyWebApp.Api.Models;

namespace MyWebApp.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //customize data model

            //define employee name as varchar, unicode is false so not nvarchar
            modelBuilder.Entity<Employee>().Property("EmployeeName").IsUnicode(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
