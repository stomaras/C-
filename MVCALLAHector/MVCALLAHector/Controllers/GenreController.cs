using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCALLAHector.Controllers
{
    public class GenreController : Controller
    {
        private ApplicationContext db = new ApplicationContext();
        private GenreRepository genreRepository;
        public GenreController()
        {
            genreRepository = new GenreRepository(db);
        }



        // GET: Genre

        public ActionResult Index()
        {
            var genres = genreRepository.GetAllWithMovies();
            return View(genres);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                genreRepository.Add(genre);
                ShowAlert($"You have successfully created new genre with kind {genre.Kind}");
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        [NonAction]
        public void ShowAlert(string message)
        {
            TempData["message"] = message;
        }
    }
}