using MVCDAY5Web.Data;
using MVCDAY5Web.Models;
using MVCDAY5Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCDAY5Web.Controllers
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



        // GET: Student
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
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET : DELETE
        [HttpGet]
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
            return View(employee);
        }

        // POST : DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
           
            var employee = employeeRepository.GetById(id);
            
            employeeRepository.Delete(employee);
            ShowAlert($"You have successfully deleted employee with name : {employee.FirstName} and last name {employee.LastName}");
            return RedirectToAction("Index");
        }

        // GET : CREATE
        [HttpGet]
        public ActionResult Create()
        {
            GetProjects();

            return View();
        }

        // POST : CREATE
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConfirmed(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Add(employee);
                ShowAlert($"You have successfully created new employee with first name {employee.FirstName}, with last name {employee.LastName}");
                return RedirectToAction("Index");
            }

            GetProjects();

            return View(employee);

        }

        // GET : Employee/Edit
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            GetProjects();

            return View(employee);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Edit(employee);
                ShowAlert($"You have successfully edited employee with first name {employee.FirstName} , with last name {employee.LastName}");
                return RedirectToAction("Index");
            }

            GetProjects();

            return View(employee);
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