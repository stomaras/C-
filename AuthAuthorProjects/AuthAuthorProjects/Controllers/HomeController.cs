using AuthAuthorProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthAuthorProjects.Controllers
{
    
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            

            return View();
        }

        [Authorize(Roles = "Admin,Customer")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            if (User.IsInRole("Admin"))
            {
                return Content("Admin Login");
            }
            else if (User.IsInRole("Customer"))
            {
                return Content("Customer Log In");
            }
            

            return View();
        }


        public ActionResult Foo()
        {
            if (User.Identity.IsAuthenticated)
            {
                string text = $"{User.Identity.Name} {User.Identity.AuthenticationType}";
                return Content(text);
            }
            else
            {
                return Content("Eisai ena tipota...");
            }
        }

        public ActionResult Goo()
        {
            return View();
        }
    }
}