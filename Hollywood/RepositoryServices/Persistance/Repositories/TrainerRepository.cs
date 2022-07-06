using Entities;
using MyDatabase;
using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class TrainerRepository : GenericRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(ApplicationDbContext context) : base(context)
        {

        }

        public void DeleteAll()
        {
            var trainers = table; // attach trainers table, Entity know trainers

            table.RemoveRange(trainers);
             

        }

        public void DeleteBy(Expression<Func<Trainer,bool>> expression)
        {
            var trainers = table.Where(expression).ToList();

            table.RemoveRange(trainers);
        }
    }
}
