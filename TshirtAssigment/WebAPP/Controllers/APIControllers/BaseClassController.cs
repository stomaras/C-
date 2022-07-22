using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPP.Controllers.APIControllers
{
    public class BaseClassController : Controller
    {
        protected MyApplicationContext db = new MyApplicationContext();
        protected UnitOfWork unitOfWork;
        

        public BaseClassController()
        {
            unitOfWork = new UnitOfWork(db);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}