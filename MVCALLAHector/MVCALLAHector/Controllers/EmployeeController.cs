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

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository(db);
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

        [HttpPost]
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