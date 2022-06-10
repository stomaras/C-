using MVCDAY4.Data;
using MVCDAY4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDAY4.Repositories.EmployeeRepository
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

        public void Add(Employee employee)
        {
            db.Entry(employee).State = EntityState.Added;
            db.SaveChanges();
        }

        public Employee GetById(int? id)
        {
            var employee = db.Employees.Find(id);
            return employee;
        }

        public void Edit(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            db.Entry(employee).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}