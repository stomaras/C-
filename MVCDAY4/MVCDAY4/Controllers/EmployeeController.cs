using MVCDAY4.Data;
using MVCDAY4.Models;
using MVCDAY4.Repositories.EmployeeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCDAY4.Controllers
{
    public class EmployeeController : Controller
    {

        private ApplicationContext db = new ApplicationContext();

        private EmployeeRepository employeeRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository(db);
        }


        // GET: Employee
        public ActionResult Index()
        {
            var employees = employeeRepository.GetAll();
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

        // GET : Delete
        public ActionResult Delete(int? id)
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
            return View(employee);

        }

        // POST : Employee/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = employeeRepository.GetById(id);
            employeeRepository.Delete(employee);
            TempData["DeleteEmployeeMessage"] = $"You have successfully deleted employee with name : {employee.FirstName} and last name {employee.LastName}"; 

            return RedirectToAction("Index");
        }

        // GET : Create Employee
        public ActionResult Create()
        {
            return View();
        }

        // POST : Create Employee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Add(employee);
                TempData["successCreateEmployee"] = $"You have successfuly created employee with first name {employee.FirstName} , with last name {employee.LastName}";
                return RedirectToAction("Index");
                
            }

            return View(employee);
        }

        // GET : Edit Employee
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            return View(employee);
        }

        // POST : Edit Employee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            
            if (ModelState.IsValid)
            {
                employeeRepository.Edit(employee);
                TempData["successEditMessage"] = $"Employee with id {employee.EmployeeId} edited !!!";
                return RedirectToAction("Index");
            }

            return View(employee);

        }


    }
}