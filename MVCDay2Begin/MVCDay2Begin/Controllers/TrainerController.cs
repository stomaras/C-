using MVCDay2Begin.Data;
using MVCDay2Begin.Repositories.TrainerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCDay2Begin.Controllers
{
    public class TrainerController : Controller
    {

        private ApplicationContext db = new ApplicationContext();

        TrainerRepository trainerRepository;

        public TrainerController()
        {
            trainerRepository = new TrainerRepository(db);
        }

        // GET: Trainer
        public ActionResult Index()
        {
            var trainers = trainerRepository.GetTrainers();
            return View(trainers);
        }

        public ActionResult Details(int? id)
        {
            var trainer = trainerRepository.GetById(id);
            return View(trainer);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            var trainer = trainerRepository.GetById(id);
            if (trainer == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            trainerRepository.DeleteTrainer(trainer);

            TempData["Delete Success Trainer"] = $"Trainer with first name {trainer.FirstName} and last name {trainer.LastName} deleted succesfully!!!";

            return RedirectToAction("Index");

        }

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