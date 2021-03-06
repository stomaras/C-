using Entities;
using MyDatabase;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repositories.Persistance.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Product> GetAllProductsWithShops()
        {
            var productsWithShops = db.Products.Include(x => x.Shop);
            return productsWithShops;
        }

        public Product GetProductWithShopDetails(int? id)
        {
            var products = GetAllProductsWithShops().ToList();

            var pro = products.Find(x=>x.Id == id);

            return pro;

        }
    }
}
