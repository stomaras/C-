using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCALLAHector.Repositories
{
    public class MovieRepository
    {
        private ApplicationContext db;

        public MovieRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Movie> GetAll()
        {
            var movies = db.Movies.ToList();
            return movies;
        }

        public List<Movie> GetAllWithGenre()
        {
            var moviesWithGenre = db.Movies.Include(m => m.Genre).ToList();
            
            return moviesWithGenre;
        }
    }
}