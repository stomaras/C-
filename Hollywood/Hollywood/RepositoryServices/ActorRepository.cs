using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class DirectorRepository
    {
        ApplicationDbContext db;
        public DirectorRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Director> GetAll()
        {
            throw new NotImplementedException();
        }

        public Director GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Director director)
        {
            throw new NotImplementedException();
        }

        public void Update(Director director)
        {
            throw new NotImplementedException();
        }

        public void Delete(Director director)
        {
            throw new NotImplementedException();

        }

        public void Save()
        {
           db.SaveChanges();
        }
    }
}
