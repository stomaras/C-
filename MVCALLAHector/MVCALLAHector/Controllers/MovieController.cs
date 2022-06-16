using MVCALLAHector.Models;
using MVCALLAHector.Models.Queries;
using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCALLAHector.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        private MovieRepository movieRepository;
        private GenreRepository genreRepository;

        public MovieController()
        {
            movieRepository = new MovieRepository(db);
            genreRepository = new GenreRepository(db);
        }
        // GET: Movie
        public ActionResult Index(MovieSearchQuery movieSearchQuery)
        {


            //Filtering ...
            var movies = GetAllWithGenres();

            ViewBag.MinPrice = movies.Min(x => x.Price);
            ViewBag.MaxPrice = movies.Max(x => x.Price);
           

            var filterMovies = movieRepository.FilterMovies(movieSearchQuery, movies);
            

            
            GetGenres();
            return View(filterMovies);
        }

        // GET: Details
        public ActionResult Details(int? id)
        {
            var movies = GetAllWithGenres();
            var movie = movieRepository.GetById(id);
            if (movie == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(movie);
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            var movie = movieRepository.GetById(id);
            if (movie == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(movie);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.Add(movie);
                ShowAlert($"You have successfully created movie with title {movie.Title}, with rating {movie.Rating}, with price {movie.Price}");
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET : EDIT
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movie = movieRepository.GetById(id);

            if (movie == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            GetGenres();
            return View(movie);
        }

        // POST : EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.Edit(movie);
                ShowAlert($"Movie with name {movie.Title} and kind {movie.Genre.Kind} edited successfully");
                return RedirectToAction("Index");   
            }
            GetGenres();
            return View(movie);
        }

        [NonAction]
        public void GetGenres()
        {
            var genres = genreRepository.GetAll();
            ViewBag.Genres = genres;
        }


        [NonAction]
        public List<Movie> GetAllWithGenres()
        {
            var movies = movieRepository.GetAllWithGenre();
            return movies;
        }

        [NonAction]
        public void ShowAlert(string message)
        {
            TempData["message"] = message;
        }
    }
}