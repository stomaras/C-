using MVCALLAHector.Models;
using MVCALLAHector.Models.Queries;
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

        public List<Employee> Filter(EmployeeFilterSettings filterSettings, out (int minAge, int maxAge) employeeAgeRange)
        {
            List<Employee> employees = GetAllWithProjects();

            int minAge = employees.Min(x => x.Age);
            int maxAge = employees.Max(x => x.Age);
            employeeAgeRange = (minAge, maxAge);
            
            
            //Filtering ....
            if (!string.IsNullOrWhiteSpace(filterSettings.searchName))// null or "" or "  "
            {
                //employees = employees.Where(x => x.Name.ToUpper() == searchName.ToUpper()).ToList();
                employees = employees.Where(x => x.Name.ToUpper().Contains(filterSettings.searchName.ToUpper())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(filterSettings.searchCountry))
            {
                employees = employees.Where(x => x.Country.ToString() == filterSettings.searchCountry).ToList();
            }

            if (!(filterSettings.searchMin == null))
            {
                employees = employees.Where(x => x.Age >= filterSettings.searchMin).ToList();
            }

            if (!(filterSettings.searchMax == null))
            {
                employees = employees.Where(x => x.Age <= filterSettings.searchMax).ToList();
            }

            return employees;

        }

        public List<Employee> GetAllWithProjects()
        {
            return db.Employees.Include(x=>x.Project).ToList();
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