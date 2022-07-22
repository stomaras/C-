using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPP.Controllers.APIControllers
{
    public class TshirtAPIController : BaseClassController
    {
        // GET: TshirtAPI
        public ActionResult GetAllProducts()
        {
            var products = unitOfWork.Tshirt.GetAll();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}