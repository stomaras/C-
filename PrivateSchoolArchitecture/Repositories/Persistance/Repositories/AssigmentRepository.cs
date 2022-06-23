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
    public class AssigmentRepository : GenericRepository<Assigment>, IAssigmentRepository
    {

        public AssigmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
