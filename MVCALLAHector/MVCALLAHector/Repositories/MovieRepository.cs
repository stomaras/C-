using MVCALLAHector.Models;
using MVCALLAHector.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCALLAHector.Models.Queries;

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

        public void Delete(Movie movie)
        {
            db.Entry(movie).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Add(Movie movie)
        {
            db.Entry(movie).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Movie GetById(int? id)
        {
            var movie = db.Movies.Find(id);
            return movie;
        }

        public List<Movie> FilterMovies(MovieSearchQuery movieSearchQuery, List<Movie> movies)
        {
            if (!string.IsNullOrWhiteSpace(movieSearchQuery.searchTitle))
            {
                movies = movies.Where(m => m.Title.ToUpper().Contains(movieSearchQuery.searchTitle.ToUpper())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(movieSearchQuery.searchGenre))
            {
                movies = movies.Where(m => m.Genre.Kind.ToLower() == movieSearchQuery.searchGenre.ToLower()).ToList();
            }

            return movies;
        }
    }
}