using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //  T - Category
        // Common Methods We Want To Implement
        // update may different from model to model

        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable GetAll();
        void Add(T entity); 
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);


    }
}
