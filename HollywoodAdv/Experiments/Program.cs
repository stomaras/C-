using Entities;
using MyDatabase;
using RepositoryServices;
using RepositoryServices.Core;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //var ratings = db.Movies.ToList()
            //    .Select(x=> $"Rating : {x.Rating}");

            //foreach (var rating in ratings)
            //{
            //    Console.WriteLine(rating);
            //}

            //var objects = db.Movies.ToList()
            //    .Select(x => new 
            //    {
            //        Title = x.Title,
            //        Rating = x.Rating,
            //        director = new { FirstName = x.Director.FirstName, LastName = x.Director.LastName },
            //        ithopoioi = x.Actors
            //        .Select(y=> new
            //        {
            //            name = y.FirstName,
            //            last = y.LastName
            //        }),
            //        missingRating = 10 - x.Rating,// produced information
            //        yearsInKino = DateTime.Now.Year - x.ProductionYear.Year
            //    });

            //foreach (var obj in objects)
            //{
            //    Console.WriteLine(obj.Title, obj.missingRating);
            //    foreach (var actor in obj.ithopoioi)
            //    {
            //        Console.WriteLine(actor);
            //    }
            //}


            // Query Syntax
            var object3 = from movie in db.Movies.ToList()
                          select movie;

            // Groups

            var movies = db.Movies.ToList();
            var groups = from movie in movies
                         group movie by movie.DirectorId into list
                         select new
                         {
                             directorName = movies.FirstOrDefault(x => x.DirectorId == list.Key).Director.FirstName,
                             movies = list.Select(x => new { x.Title })
                         };

            foreach (var item in groups)
            {
                Console.WriteLine(item.directorName);
                foreach (var movie in item.movies)
                {
                    Console.WriteLine("\t\t" + movie.Title);
                }
            }
            



            

            //UnitOfWork hollywoodUnit = new UnitOfWork(db);

            //var groups = hollywoodUnit.Actors.GetActorsGroupedByCountry();

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key,15}: {group.Count()}");
            //}

            //Console.WriteLine("-------------");

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key,15}");

            //    foreach (var actor in group)
            //    {
            //        Console.WriteLine($"{"",15}:{actor.FirstName + " " + actor.LastName}");
            //    }

            //}
        }
    }
}
