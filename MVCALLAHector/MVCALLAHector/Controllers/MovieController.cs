using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCALLAHector.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        private MovieRepository movieRepository;

        public MovieController()
        {
            movieRepository = new MovieRepository(db);
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = movieRepository.GetAllWithGenre();
            
            return View(movies);
        }
    }
}