using Entities;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Areas.Admin.Controllers.APIControllers
{
    public class TrainerAPIController : BaseClassController
    {
       
        [HttpGet]
        public ActionResult GetNames()
        {
            var names = unit.Trainers.GetAll().Select(x => new { x.Name });

            return Json(names, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetTrainers()
        {
            var trainers = unit.Trainers.GetAll();

            return Json(trainers, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateTrainer(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                unit.Trainers.Insert(trainer);
                unit.Complete();
                return Json(trainer, JsonRequestBehavior.AllowGet);
                // or
                // return new HttpStatusCodeResult(HttpStatusCode.Created);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

        }

        [HttpPost]
        public ActionResult CreateStudentWithRandomService(string name)
        {
            Random random = new Random();
            var salary = random.Next(1000,5001);

            Trainer trainer = new Trainer() { Name = name, Salary = salary };
            if (ModelState.IsValid)
            {
                unit.Trainers.Insert(trainer);
                unit.Complete();
                return Json(trainer, JsonRequestBehavior.AllowGet);
                // or
                // return new HttpStatusCodeResult(HttpStatusCode.Created);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpDelete]
        public ActionResult DeleteTrainerById(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var trainer = unit.Trainers.GetById(id);
            if (trainer is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            unit.Trainers.Delete(id);
            unit.Complete();
            return Json(trainer, JsonRequestBehavior.AllowGet);
        }


        [HttpDelete]
        public ActionResult DeleteAllTrainers()
        {
            unit.Trainers.DeleteAll();
            unit.Complete();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }


        [HttpDelete]
        public ActionResult DeleteBySalary(int? salary)
        {
            if (salary is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            unit.Trainers.DeleteBy(x => x.Salary > salary);
            unit.Complete();
            return new HttpStatusCodeResult(HttpStatusCode.OK);

        }


        [HttpPut]
        public ActionResult EditTrainer(int? id, Trainer trainer)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tr = unit.Trainers.GetById(id);

            if (trainer is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            // Mapping
            tr.Name = trainer.Name;
            tr.Salary = trainer.Salary;

            unit.Trainers.Update(tr);
            unit.Complete();

            return Json(tr, JsonRequestBehavior.AllowGet);


        }










        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unit.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: Admin/TrainerAPI
        public ActionResult GetAllTrainers()
        {
            return View();
        }
    }
}