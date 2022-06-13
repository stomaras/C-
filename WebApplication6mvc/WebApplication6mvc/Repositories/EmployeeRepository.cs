using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6mvc.Data;
using WebApplication6mvc.Models;

namespace WebApplication6mvc.Repositories
{
    public class EmployeeRepository
    {
        private ApplicationContext db;


        public EmployeeRepository(ApplicationContext context)
        {
            db = context;
        }


        public List<Employee> GetAll()
        {
            var employees = db.Employees.ToList();
            return employees;
        }
    }
}