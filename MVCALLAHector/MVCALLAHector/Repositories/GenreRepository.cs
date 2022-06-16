using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCALLAHector.Repositories
{
    public class GenreRepository
    {
        private ApplicationContext db;
        public GenreRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Genre> GetAll()
        {
            var genres = db.Genres.ToList();
            return genres;
        }

        public List<Genre> GetAllWithMovies()
        {
            var genresWithMovies = db.Genres.Include(g => g.Movies).ToList();
            return genresWithMovies;
        }

        public void Add(Genre genre)
        {
            db.Entry(genre).State = EntityState.Added;
            db.SaveChanges();
        }
    }
}