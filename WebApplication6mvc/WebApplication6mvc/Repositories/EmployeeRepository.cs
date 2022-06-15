using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication6mvc.Data;
using WebApplication6mvc.Models;
using WebApplication6mvc.Models.Queries;

namespace WebApplication6mvc.Repositories
{
    public class EmployeeRepository
    {
        private ApplicationContext db;


        public EmployeeRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Employee> Filter(List<Employee> employees, EmployeeSearchQuery query)
        {
            //Filtering...
            if (!string.IsNullOrWhiteSpace(query.searchName)) // null or "" or "  "
            {
                //employees = employees.Where(x => x.FirstName.ToUpper() == searchName.ToUpper()).ToList();

                employees = employees.Where(x => x.FirstName.ToUpper().Contains(query.searchName.ToUpper())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(query.searchCountry))
            {
                employees = employees.Where(x => x.Country.ToString() == query.searchCountry).ToList();
            }

            if (!(query.searchMin == null))
            {
                employees = employees.Where(x => x.Age >= query.searchMin).ToList();
            }

            if (!(query.searchMax == null))
            {
                employees = employees.Where(x => x.Age <= query.searchMax).ToList();
            }

            return employees;
        }

        public List<Employee> GetAll()
        {
            var employees = db.Employees.ToList();
            return employees;
        }

        public List<Employee> GetAllWithProjects()
        {
            var employeesWithProjects = db.Employees.Include(x=>x.Project).ToList();
            return employeesWithProjects;
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