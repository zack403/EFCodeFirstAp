using EFCodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp.DataAccess
{
    public class Context : DbContext
    {
        static Context()
        {
            //Disable initializer
            Database.SetInitializer<Context>(null);
        }
        public Context() : base("EFCodeFirstConnection")
        {
            //Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());

        }

      
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here..
           // modelBuilder.Configurations.Add(new Employee());

        }
    }
}
