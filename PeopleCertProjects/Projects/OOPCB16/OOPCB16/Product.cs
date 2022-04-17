using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCB16
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Product() { }

        public Product(string name, int id)
        {
            Name = name;
            ID = id;
        }

        // I call this method ον Class, best Product among all products
        // so i use static 
        public static Product GetBestProduct()
        {
            Product bestProduct = new Product("Lg Screen", 2);
            return bestProduct;
        }

        // virtual means I intend for this method to be overriden from the derived class.
        public virtual void Sale() // Polymorphism
        {
            Console.WriteLine($"Selling {Name} with ID: {ID} for {Price}");
        }

        public static List<Product> GetProducts(int numbertToGet)
        {
            var newList = new List<Product>();
            var random = new Random();
            Product product = null;
            for(int i=0; i < numbertToGet; i++)
            {
                product = new Product()
                {
                    ID = random.Next(),
                    Name = "my Product" + i.ToString(),
                    Price = random.Next(1, 101)
                };
                newList.Add(product);
            }
            return newList;
        }
    }
}
