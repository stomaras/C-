using MVCALLAHector.Models;
using MVCALLAHector.Models.Enums;
using MVCALLAHector.Models.ViewModels;
using MVCALLAHector.MyContext;
using MVCALLAHector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCALLAHector.Controllers
{
    public class HomeController : Controller
    {

        

       
        //localhost:32231/home/index
        public ActionResult Index()
        {
            Genre g1 = new Genre() { Kind = "romance" };
            Genre g2 = new Genre() { Kind = "thriller" };
            Genre g3 = new Genre() { Kind = "action" };

            Movie m1 = new Movie() { Title = "Spiderman 1", Price = 20.23, Rating = 7.3, Genre = g1 };
            Movie m2 = new Movie() { Title = "Spiderman 2", Price = 40.23, Rating = 8.8, Genre = g1 };
            Movie m3 = new Movie() { Title = "Spiderman 3", Price = 60.23, Rating = 9.1, Genre = g2 };

            

            List<Movie> movies = new List<Movie>() { m1, m2, m3 };
            List<Genre> genres = new List<Genre>() { g1, g2, g3 };

            // ViewModel
            MovieGenres movieGenres = new MovieGenres()
            {
                Title = "Baroufa Object",
                Movies = movies,
                Genres = genres
            };

            return View(movieGenres);
        }
        // if is true that HomeController is in distraction mode... please destroy 
        // the ApplicationContext
        

    }
}