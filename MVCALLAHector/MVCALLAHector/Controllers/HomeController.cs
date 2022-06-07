using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCALLAHector.Controllers
{
    public class HomeController : Controller
    {

        

       
        //localhost:32231/home/index
        public ActionResult Index()
        {
            return View();
        }
        // if is true that HomeController is in distraction mode... please destroy 
        // the ApplicationContext
        

    }
}