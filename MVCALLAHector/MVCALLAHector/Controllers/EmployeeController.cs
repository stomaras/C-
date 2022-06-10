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

namespace MVCALLAHector.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        private EmployeeRepository employeeRepository;
        private ProjectRepository projectRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository(db);
            projectRepository = new ProjectRepository(db);
        }
        // GET: Employee
        public ActionResult Index(EmployeeSearchQuery query)// same name as in input name attribute
        {
            //ViewBag.movie = "Titanikos";
            //ViewBag["movie"] = "foufoutos";
            var employees = employeeRepository.GetAllWithProjects();

            // Current State
            ViewBag.currentName = query.searchName;
            ViewBag.currentCountry = query.searchCountry; 
            ViewBag.currentMin = query.searchMin;
            ViewBag.currentMax = query.searchMax;






            ViewBag.MinAge = employees.Min(x => x.Age);
            ViewBag.MaxAge = employees.Max(x => x.Age);

            employeeRepository.Filter(employees, query);
            
            return View(employees);
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
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp) // new Employee(name="Remos" hiredate=null) with all payloads features we fill 
        {
            // Save in database a new Employee
            if (ModelState.IsValid)
            {
                employeeRepository.Add(emp);
                ShowAlert("You have successfully created employee" + emp.Name);
                return RedirectToAction("Index");
            }
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
        public void ShowAlert(string message)
        {
            TempData["message"] = message;  
        }

    }
}