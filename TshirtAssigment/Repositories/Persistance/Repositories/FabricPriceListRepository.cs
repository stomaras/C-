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
    public class FabricPriceListRepository : GenericRepository<FabricPriceList>, IFabricPriceListRepository
    {
        public FabricPriceListRepository(MyApplicationContext context) : base(context)
        {

        }
    }
}
