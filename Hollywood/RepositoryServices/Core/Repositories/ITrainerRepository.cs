using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core.Repositories
{
    public interface ITrainerRepository : IGenericRepository<Trainer>
    {
        void DeleteAll();

        void DeleteBy(Expression<Func<Trainer, bool>> expression); // x=.x.salary > 1500


    }
}
