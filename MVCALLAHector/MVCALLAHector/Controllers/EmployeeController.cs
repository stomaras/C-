using MVCALLAHector.Models;
using MVCALLAHector.Models.Queries;
using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using MVCALLAHector.Models.Enums;

namespace MVCALLAHector.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        private EmployeeRepository employeeRepository;
        private ProjectRepository projectRepository;
        private ManagerRepository managerRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository(db);
            projectRepository = new ProjectRepository(db);
            managerRepository = new ManagerRepository(db);
        }
        // GET: Employee
        public ActionResult Index(EmployeeFilterSettings filterSettings, string sortOrder, int? page, int? pSize)// same name as in input name attribute
        {
            //ViewBag.movie = "Titanikos";
            //ViewBag["movie"] = "foufoutos";
           

            // Current State
            ViewBag.currentName = filterSettings.searchName;
            ViewBag.currentCountry = filterSettings.searchCountry; 
            ViewBag.currentMin = filterSettings.searchMin;
            ViewBag.currentMax = filterSettings.searchMax;

            // Filtering...
            (int? minAge, int? maxAge) employeeAgeRange;
            var filterEmployees = employeeRepository.Filter(filterSettings, out employeeAgeRange);

            ViewBag.MinAge = employeeAgeRange.minAge;
            ViewBag.MaxAge = employeeAgeRange.maxAge;

            // Sorting...

            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "NameDesc" : "";
            ViewBag.AgeSortParam = sortOrder == "AgeAsc" ? "AgeDesc" : "AgeAsc";
            ViewBag.HireDateSortParam = sortOrder == "HireDateAsc" ? "HireDateDesc" : "HireDateAsc";
            ViewBag.ProjectTitleSortParam = sortOrder == "ProjectTitleAsc" ? "ProjectTitleDesc" : "ProjectTitleAsc";

            switch (sortOrder)
            {
                case "NameAsc" : filterEmployees = filterEmployees.OrderBy(x => x.Name).ToList(); break;
                case "NameDesc" : filterEmployees = filterEmployees.OrderByDescending(x => x.Name).ToList(); break;

                case "AgeAsc": filterEmployees = filterEmployees.OrderBy(x => x.Age).ToList(); break;
                case "AgeDesc": filterEmployees = filterEmployees.OrderByDescending(x => x.Age).ToList(); break;

                case "HireDateAsc": filterEmployees = filterEmployees.OrderBy(x => x.HireDate).ToList(); break;
                case "HireDateDesc": filterEmployees = filterEmployees.OrderByDescending(x => x.HireDate).ToList(); break;

                case "ProjectTitleAsc": filterEmployees = filterEmployees.OrderBy(x => x.Project.Title).ToList(); break;
                case "ProjectTitleDesc": filterEmployees = filterEmployees.OrderByDescending(x => x.Project.Title).ToList(); break;

                default: filterEmployees = filterEmployees.OrderBy(x => x.Name).ToList(); break;
            }

            // Pagination 
            int pageSize = pSize ?? 3;// if pSize is null -> 3
            int pageNumber = page ?? 1;// if page is null -> 1

            return View(filterEmployees.ToPagedList(pageNumber,pageSize));
        }

        public ActionResult Details(int? id)
        {
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(employee);
        }

        [HttpGet]
        public ActionResult Create()
        {

            GetProjects();
            GetManagers();

            Employee testEmployee = new Employee()
            {
                Name = "Spy",
                Age = 34,
                Country = Country.France,
                HireDate = DateTime.Now,
                Salary = 4000
            };

            return View(testEmployee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp, List<int> managerIds) // new Employee(name="Remos" hiredate=null) with all payloads features we fill 
        {
            // Save in database a new Employee
            if (ModelState.IsValid)
            {
                if (managerIds == null)
                {
                    employeeRepository.Add(emp);
                }
                else
                {
                    employeeRepository.Add(emp, managerIds);
                }
               
                ShowAlert("You have successfully created employee" + emp.Name);
                return RedirectToAction("Index");
            }
            GetManagers();
            GetProjects();
            return View(emp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            employeeRepository.Delete(employee);
            ShowAlert($"You have successfully deleted employee with name : {employee.Name} and id {employee.Id}");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var emp = employeeRepository.GetById(id);

            if (emp == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            GetProjects();

            return View(emp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Edit(emp);
                ShowAlert($"Employee with id {emp.Id} edited!!!");
                return RedirectToAction("Index");
            }

            GetProjects();


            return View(emp);
            

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }



        [NonAction]
        public void GetProjects()
        {
            var projects = projectRepository.GetAll();
            ViewBag.Projects = projects;
        }

        [NonAction]
        public void GetManagers()
        {
            var managers = managerRepository.GetAll();
            ViewBag.Managers = managers;
        }

        [NonAction]
        public void ShowAlert(string message)
        {
            TempData["message"] = message;  
        }

    }
}