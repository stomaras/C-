using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6mvc.Data;
using WebApplication6mvc.Models;
using WebApplication6mvc.Repositories;

namespace WebApplication6mvc.Controllers
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


        // GET : Employee // Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            GetProjects();
            return View(employee);
        }

        // GET : Employee // Delete

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            GetProjects();
            return View(employee);
        }

        // POST : Employee // Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            var employee = employeeRepository.GetById(id);

            employeeRepository.Delete(employee);
            ShowAlert($"You have succeessfully deleted employee with name : {employee.FirstName} and last name : {employee.LastName}");
            return RedirectToAction("Index");
        }

        // GET : Employee // Create
        public ActionResult Create()
        {
            GetProjects();
            return View();
        }


        // POST : Employee // Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Create(employee);
                ShowAlert($"You have successfully created employee with name : {employee.FirstName} and last name: {employee.LastName}");
                return RedirectToAction("Index");
            }

            GetProjects();

            return View(employee);
        }

        // GET : Employee // Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            GetProjects();
            return View(employee);
        }

        // POST : Employee // Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Edit(employee);
                ShowAlert($"You have successfully updated employee with name: {employee.FirstName} and last name: {employee.LastName}");
                return RedirectToAction("Index");
            }
            GetProjects();
            return View(employee);
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

        #endregion

    }
}