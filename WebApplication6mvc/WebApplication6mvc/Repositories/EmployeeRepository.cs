using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Employee GetById(int? id)
        {
            var employee = db.Employees.Find(id);
            return employee;
        }

        public void Delete(Employee employee)
        {
            db.Entry(employee).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Create(Employee employee)
        {
            db.Entry(employee).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}