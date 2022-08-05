﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bookingg.DataAccess.Repository.Core
{
    public interface IRepository<T> where T : class
    {
        // T- Category for now can be any entity

        IEnumerable<T> GetAll(string? includeProperties = null);
        void Add(T entity);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);// will remove a collection of entites
    }
}
