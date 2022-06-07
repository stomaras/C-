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

        private ApplicationContext db = new ApplicationContext();

        private StudentRepository studentRepo;



        public HomeController()
        {
            studentRepo = new StudentRepository(db);
        }
        //localhost:32231/home/index
        public ActionResult Index()
        {
            var students = studentRepo.GetAll();
            return View(students);
        }
        // if is true that HomeController is in distraction mode... please destroy 
        // the ApplicationContext
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