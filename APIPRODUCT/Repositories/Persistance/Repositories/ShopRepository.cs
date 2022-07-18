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

        public List<int> GetAllIds()
        {
            var shops = GetAll();
            List<int> ids = new List<int>();
            foreach (var shop in shops)
            {
                ids.Add(shop.Id);
            }
            return ids;
        }

        public Shop GetShopById(int id)
        {
            var shop = db.Shops.Find(id);
            return (Shop)shop;
        }

        public Shop GetShopByName(string name)
        {
            var shop = db.Shops.Find(name);
            return shop;
        }
    }
}
