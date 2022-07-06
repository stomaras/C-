using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Areas.Admin.Controllers.APIControllers
{
    public class PeopleAPIController : BaseClassController
    {
        
        [HttpGet]
        public ActionResult GetAllPeoples()
        {
            var peoples = unit.Peoples.GetAll();
            return Json(peoples, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreatePeoples(IEnumerable<People> peoples)
        {
            unit.Peoples.AddPersons(peoples);
            unit.Complete();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
        }




    }
}