using Entities;
using MyDatabase;
using Repositories.Core;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class ShopRepository : GenericRepository<Shop>, IShopRepository
    {

        public ShopRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Shop GetShopByName(string name)
        {
            var shops = GetAll().ToList();
            foreach (var shop in shops)
            {
                if (shop.Title == name)
                {
                    return shop;
                }
            }
            return null;
        }
    }
}
