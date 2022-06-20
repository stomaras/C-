using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class GenreRepository
    {
        ApplicationDbContext db;
        public GenreRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void Update(Genre genre)
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
