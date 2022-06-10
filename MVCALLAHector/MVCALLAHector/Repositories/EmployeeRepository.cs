using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCALLAHector.Repositories
{
    public class EmployeeRepository
    {

        ApplicationContext db;

        public EmployeeRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public Employee GetById(int? id)
        {
            var employee = db.Employees.Find(id);
            return employee;
        }

        public void Delete(Employee emp)
        {
            db.Entry(emp).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Add(Employee emp)
        {
            db.Entry(emp).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Employee emp) // new Employee(){name="NewName"
        {
            // single responsiblity and seperaton of concerns
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
            // ask sql server : do you have someone employee with id=55??
            
        }
    }
}