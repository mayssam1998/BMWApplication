using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tache.Models
{
    public class EmployeeContext : DbContext  // DbContext mtl abstraction la database
    {
        static EmployeeContext()
        {
            Database.SetInitializer(new MySqlInitializer());
        }

        public DbSet<Employee> employees { get; set; } //to create a table of employees
        public EmployeeContext() : base("name=DefaultConnection") { }
    }
}