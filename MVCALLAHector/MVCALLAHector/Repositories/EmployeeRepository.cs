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

        public List<Employee> GetAllWithProjects()
        {
            return db.Employees.Include(x => x.Project).ToList();
        }

        public List<Employee> GetAllWithProjectsAndManagers()
        {
            return db.Employees.Include(x => x.Project).Include(x=>x.Managers).ToList();
        }

        public List<Employee> Filter(EmployeeFilterSettings filterSettings, out (int? minAge, int? maxAge) employeeAgeRange)
        {
            List<Employee> employees = GetAllWithProjectsAndManagers();

            int? minAge = employees?.Min(x => x?.Age);
            int? maxAge = employees?.Max(x => x?.Age);
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

        

        public Employee GetById(int? id)
        {
            var employee = db.Employees
                .Include(x => x.Project)
                .Include(x => x.Managers)
                .FirstOrDefault(x => x.Id == id);
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


        public void Edit(Employee emp) // new Employee(){name="NewName"
        {
            // single responsiblity and seperaton of concerns
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
            // ask sql server : do you have someone employee with id=55??
        }

        public void Edit(Employee emp, List<int> managerIds)
        {
            if (emp == null)
            {
                throw new ArgumentException("Emp Not Found");
            }
            //Step 1 , Question in db , do you have this employee??? with this id? and come with as many tables you want
            // Attached Mode This Object
            var employee = db.Employees 
                .Include(x=>x.Project)
                .Include(x=>x.Managers)
                .FirstOrDefault(x=>x.Id == emp.Id);


            //db.Entry(employee).State = EntityState.Detached; // stop to ignore this with Detached
            if (employee == null)
            {
                throw new ArgumentNullException("Employee Not Found");
            }

            
            //Step 2.a Mapping
            employee.Name = emp.Name;
            employee.Salary = emp.Salary;
            employee.Salary = emp.Salary;
            employee.HireDate = emp.HireDate;
            employee.ProjectId = emp.ProjectId;
            employee.Country = emp.Country;
            employee.PhotoUrl = emp.PhotoUrl;




            // Step 2.b Clear old managers from employee table
            employee.Managers.Clear();
            db.SaveChanges();

            // Step 3 Update with the news , make use of managerIds
            if (managerIds != null)
            {
                foreach (var id in managerIds)
                {
                    var manager = db.Managers.Find(id);
                    if (manager != null)
                    {
                        employee.Managers.Add(manager);
                    }
                }
            }
            
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}