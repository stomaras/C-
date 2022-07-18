using MyDatabase;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Controllers.APIControllers
{
    public class BaseClassController : Controller
    {
        protected ApplicationDbContext db = new ApplicationDbContext();
        protected UnitOfWork nba;

        public BaseClassController()
        {
            nba = new UnitOfWork(db);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                nba.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}