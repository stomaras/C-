using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFinal.Controllers.APIControllers
{
    public class ShopAPIController : BaseClassController
    {
        // GET: ShopAPI
        public ActionResult Index()
        {
            return View();
        }
    }
}