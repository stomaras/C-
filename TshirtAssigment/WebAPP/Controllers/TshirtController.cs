using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPP.Controllers
{
    public class TshirtController : Controller
    {
        // GET: Tshirt
        public ActionResult Index()
        {
            return View();
        }
    }
}