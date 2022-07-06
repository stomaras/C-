using Entities;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Areas.Admin.Controllers.APIControllers
{
    public class PersonAPIController : BaseClassController
    {
        [HttpGet]
        public ActionResult GetAllPersons()
        {
            var persons = unit.Persons.GetAll();
            return Json(persons, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreatePersons(IEnumerable<Person> persons)
        {
            unit.Persons.AddPersons(persons);
            unit.Complete();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
        }

    }
}