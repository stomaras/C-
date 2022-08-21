using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class EmployeesController : Controller
    {

        private EmployeesPortalEntities db = new EmployeesPortalEntities();

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
    }
}