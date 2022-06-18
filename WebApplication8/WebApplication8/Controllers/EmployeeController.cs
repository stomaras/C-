using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;
using WebApplication8.MyDatabase;
using WebApplication8.Repositories;

namespace WebApplication8.Controllers
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
            var employees = employeeRepository.GetAllWithProjects();
            return View(employees);
        }

        // GET : Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = employeeRepository.GetByIdProjects(id);
            
            return View(employee);
        }

        // GET : Create
        public ActionResult Create()
        {
            GetProjects();
            return View();
        }

        // POST : Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Add(employee);
                ShowAlert($"You have successfully created employee with first name {employee.FirstName}, with last name {employee.LastName}");
                return RedirectToAction("Index");
            }

            GetProjects();
            return View(employee);

        }

        // GET : Edit
        public ActionResult Edit(int? id)
        {
            var employee = employeeRepository.GetByIdProjects(id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetProjects();
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Edit(employee);
                ShowAlert($"Employee with first name {employee.FirstName}, with Last name {employee.LastName} edited successfully!!!");
                return RedirectToAction("Index");
            }
            GetProjects();
            return View(employee);

            
        }


        // GET DELETE
        public ActionResult Delete(int? id)
        {
            var employee = employeeRepository.GetByIdProjects(id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(employee);
        }

        // POST DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Employee employee = employeeRepository.GetById(id);
            employeeRepository.Delete(employee);
            ShowAlert($"Employee with first name {employee.FirstName}, with last name {employee.LastName} deleted successfully!!!");
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Non Action Methods

        [NonAction]
        public void ShowAlert(string message)
        {
            TempData["Message"] = message;
        }

        [NonAction]
        public void GetProjects()
        {
            var projects = projectRepository.GetAll();
            ViewBag.Projects = projects;
        }

        #endregion


    }
}