﻿using Entities;
using MyDatabase;
using Repositories.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance
{
    public class GenericRepository<T> : IGenericRepository<T> where T : SchoolEntity
    {
        public ApplicationDbContext db;
        public DbSet<T> table;

        public GenericRepository(ApplicationDbContext conext)
        {
            db = conext;
            table = db.Set<T>();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
