using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class ActorRepository
    {
        ApplicationDbContext db;
        public ActorRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Actor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Update(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(Actor actor)
        {
            throw new NotImplementedException();

        }

        public void Save()
        {
           db.SaveChanges();
        }
    }
}
