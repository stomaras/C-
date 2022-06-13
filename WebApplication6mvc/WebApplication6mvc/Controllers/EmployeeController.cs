using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6mvc.Data;
using WebApplication6mvc.Repositories;

namespace WebApplication6mvc.Controllers
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
    }
}