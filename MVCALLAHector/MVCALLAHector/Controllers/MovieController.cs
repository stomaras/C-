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
using PagedList.Mvc;
using PagedList;

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
        public ActionResult Index(MovieSearchQuery movieSearchQuery, string sortOrder, int? page, int? pSize)
        {


            //Filtering ...
            ViewBag.currentTitle = movieSearchQuery.searchTitle;
            ViewBag.currentGenre = movieSearchQuery.searchGenre;
            ViewBag.currentMinPrice = movieSearchQuery.searchMinPrice;
            ViewBag.currentMaxPrice = movieSearchQuery.searchMaxPrice;


            (int minPrice, int maxPrice) movieMinMaxPrice;
            var filterMovies = movieRepository.FilterMovies(movieSearchQuery, out movieMinMaxPrice);

            ViewBag.MinPrice = movieMinMaxPrice.minPrice;
            ViewBag.MaxPrice = movieMinMaxPrice.maxPrice;

            // Sorting

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.PriceSortParam = sortOrder == "PriceAsc" ? "PriceDesc" : "PriceAsc";
            ViewBag.RatingSortParam = sortOrder == "RatingAsc" ? "RatingDesc" : "RatingAsc";
            ViewBag.GenreKindParam = sortOrder == "GenreKindAsc" ? "GenreKindDesc" : "GenreKindAsc";


            switch (sortOrder)
            {
                case "TitleAsc": filterMovies = filterMovies.OrderBy(x => x.Title).ToList();break;
                case "TitleDesc": filterMovies = filterMovies.OrderByDescending(x => x.Title).ToList();break;

                case "PriceAsc": filterMovies = filterMovies.OrderBy(x => x.Price).ToList(); break;
                case "PriceDesc": filterMovies = filterMovies.OrderByDescending(x => x.Price).ToList(); break;

                case "RatingAsc": filterMovies = filterMovies.OrderBy(x => x.Rating).ToList();break;
                case "RatingDesc": filterMovies = filterMovies.OrderByDescending(x => x.Rating).ToList();break;

                case "GenreKindAsc": filterMovies = filterMovies.OrderBy(x => x.Genre.Kind).ToList(); break;
                case "GenreKindDesc": filterMovies = filterMovies.OrderByDescending(x => x.Genre.Kind).ToList(); break;


                default: filterMovies = filterMovies.OrderBy(x => x.Title).ToList(); break;
            }

            // Pagination ...

            int pageSize = pSize ?? 3; // if movies per page = null -> make pageSze = 3 else make pageSize = pSize
           
            int pageNumber = page ?? 1;
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }

            GetGenres();
            return View(filterMovies.ToPagedList(pageNumber,pageSize));
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