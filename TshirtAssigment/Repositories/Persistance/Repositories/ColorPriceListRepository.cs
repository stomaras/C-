using Entities;
using Entities.Enums;
using MyDatabase;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class ColorPriceListRepository : GenericRepository<ColorPriceList>, IColorPriceListRepository
    {

        
        public ColorPriceListRepository(MyApplicationContext context) : base(context)
        {

        }
    }
}
