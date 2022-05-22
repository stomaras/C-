using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ProductStockRepository
    {
        public static Dictionary<Product, int> _productStockDatabase = Setup();

        private static Dictionary<Product, int> Setup()
        {
            var productStockDatabase = new Dictionary<Product, int>();
            productStockDatabase.Add(Product.Keyboard, 1);
            productStockDatabase.Add(Product.Mic, 1);
            productStockDatabase.Add(Product.Mouse, 1);
            productStockDatabase.Add(Product.Speaker, 1);
            return productStockDatabase;
        }

        // We want to check if a product is in stock 
        public bool IsInStock(Product product)
        {
            Console.WriteLine("Call Get On Database");
            return _productStockDatabase[product] > 0;
        }
    }
}
