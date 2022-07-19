using Entities;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class TshirtRepository : GenericRepository<Tshirt>, ITshirtRepository
    {
        public TshirtRepository(MyDatabase.MyApplicationContext context) : base(context)
        {

        }
    }
}
