using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class PhotoRepository
    {
        ApplicationDbContext db;
        public PhotoRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Photo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Photo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Photo photo)
        {
            throw new NotImplementedException();
        }

        public void Update(Photo photo)
        {
            throw new NotImplementedException();
        }

        public void Delete(Photo photo)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
           db.SaveChanges();
        }
    }
}
