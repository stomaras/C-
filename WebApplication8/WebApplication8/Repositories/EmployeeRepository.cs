using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication8.Models;
using WebApplication8.MyDatabase;

namespace WebApplication8.Repositories
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

        public List<Employee> GetAllWithProjects()
        {
            var employeesWithProjects = db.Employees.Include(x => x.Project).ToList();
            return employeesWithProjects;
        }

        public List<Employee> GetAllWithProjectsWithManagers()
        {
            var employeesWithProjectWithManagers = db.Employees
                .Include(x => x.Project)
                .Include(x => x.Managers)
                .ToList();
            return employeesWithProjectWithManagers;
        }

        

        public Employee GetById(int? id)
        {
            var employee = db.Employees.Find(id);
            return employee;
        }

        public Employee GetByIdWithProjectWithEmployees(int? id)
        {
            var employee = db.Employees
                .Include(x => x.Project)
                .Include(x => x.Managers)
                .FirstOrDefault(x => x.Id == id);
            return employee;
        }

        public Employee GetByIdProjects(int? id)
        {
            var employeeWithProjects = db.Employees.Include(x => x.Project).ToList();
            var employee = employeeWithProjects.Find(x => x.Id == id);
            return employee;
        }

        public void Add(Employee emp)
        {
            db.Entry(emp).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Add(Employee emp, List<int> managerIds)
        {
            foreach (var id in managerIds)
            {
                var manager = db.Managers.Find(id);
                if (manager != null)
                {
                    emp.Managers.Add(manager);
                }
            }

            db.Entry(emp).State = EntityState.Added;
            db.SaveChanges();
        }



        public void Edit(Employee emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Employee emp)
        {
            db.Entry(emp).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}