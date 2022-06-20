using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class MovieRepository
    {
        ApplicationDbContext db;
        public MovieRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Movie> GetAll()
        {
           return db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
           db.SaveChanges();
        }
    }
}
