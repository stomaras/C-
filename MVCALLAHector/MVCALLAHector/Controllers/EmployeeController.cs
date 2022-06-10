using MVCALLAHector.Models;
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
        public ActionResult Index()
        {
            //ViewBag.movie = "Titanikos";
            //ViewBag["movie"] = "foufoutos";
            var employees = employeeRepository.GetAll();
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

            var projects = projectRepository.GetAll();
            ViewBag.Projects = projects;
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
                TempData["message"] = "You have successfully created employee" + emp.Name;
                return RedirectToAction("Index");
            }
            
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

            TempData["message"] = $"You have successfully deleted employee with name : {employee.Name} and id {employee.Id}";

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

            return View(emp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Edit(emp);
                TempData["message"] = $"Employee with id {emp.Id} edited!!!";
                return RedirectToAction("Index");
            }

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
    }
}