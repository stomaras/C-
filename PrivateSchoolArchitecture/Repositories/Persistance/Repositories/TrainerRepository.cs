using Entities;
using MyDatabase;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class TrainerRepository : GenericRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Trainer> GetTrainersByAscending()
        {
            return table.OrderBy(x => x.FirstName).ToList();
        }

        
    }
}
