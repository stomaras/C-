using FnalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FnalApp.Controllers
{
    public class HomeController : Controller
    {

        private MyDatabase.ApplicationDbContext hollywoodDb = new MyDatabase.ApplicationDbContext();
        private FnalApp.Models.ApplicationDbContext userDB = new FnalApp.Models.ApplicationDbContext();

          
        public ActionResult Method()
        {
            var movies = hollywoodDb.Movies.ToList()
                .Select(x => new
                {
                    x.Title,
                    x.Duration,
                    x.Rating,
                    directorName = new {x.Director.FirstName, x.Director.LastName}
                });

            return Json(movies, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            var orders = hollywoodDb.MoviesUserOrders.ToList();

            var movieTitles = from order in orders
                       join movie in hollywoodDb.Movies
                       on order.MovieId equals movie.MovieId
                       select new {title = movie.Title};

            var usernames = from order in orders
                            join user in userDB.Users
                            on order.UserId equals user.Id
                            select new { username = user.UserName };

            var groups = from order in orders
                         group order by order.UserId into x
                         select x;

            var groups2 = from order in orders
                          group order by order.UserId into x
                          select new
                          {
                              paragelia = x.Key
                          };

            return Json(groups2, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}