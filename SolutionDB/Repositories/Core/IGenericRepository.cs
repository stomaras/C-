﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public interface IGenericRepository<T> where T : CompanyEntity
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetById(object id);

        void Insert(T obj);

        void Add(T obj);

        void Update(T obj);

        void Delete(object id);

        void Save();
    }
}
