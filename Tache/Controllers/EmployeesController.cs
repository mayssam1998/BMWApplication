using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tache.Models;

namespace Tache.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            
            using (EmployeeContext context = new EmployeeContext())
            {
                context.employees 

                
            }
        }
        public Employee Get(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return context.employees.FirstOrDefault(e => e.id == id);
            }
        }

    }
}
