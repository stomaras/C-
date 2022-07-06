﻿using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Areas.Admin.Controllers.APIControllers
{
    public class BaseClassController : Controller
    {
        //protected only child can have me
        protected MyDatabase.ApplicationDbContext db = new MyDatabase.ApplicationDbContext();
        protected UnitOfWork unit;

        public BaseClassController()
        {
            unit = new UnitOfWork(db);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unit.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}