using Entities;
using MyDatabase;
using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class PeopleRepository : GenericRepository<People>, IPeopleRepository
    {
        public PeopleRepository(ApplicationDbContext context) : base(context)
        {

        }

        public void AddPersons(IEnumerable<People> peoples)
        {
            table.AddRange(peoples); 
        }

       
    }
}
