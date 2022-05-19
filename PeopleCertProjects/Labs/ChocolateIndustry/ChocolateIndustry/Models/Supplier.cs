using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Services;
using ChocolateIndustry.Interfaces;
namespace ChocolateIndustry.Models
{
    class Supplier : IPeople
    {
        public static int id { get; private set; }
        public string firstName { get; private set; }

        public string lastName { get; private set; }

        public List<Product> Products { get; private set; }

        public Supplier(int numOfProducts)
        {
            GenerateSupplierID();
            firstName = RandomService.RandFirstName();
            lastName = RandomService.RandLastName();
            List<Product> products = new List<Product>();
            Products = GetProducts(products, numOfProducts);
        }

        public List<Product> GetProducts(List<Product> products, int numOfProducts)
        {
            
            for (int i = 0; i <= numOfProducts-1; i++)
            {
                Product product = new Product();
                products.Add(product);
            }
            return products;
        }

        public static void GenerateSupplierID()
        {
            id++;
        }

        public override string ToString()
        {
            string s = $"Supplier {{ with id : {id}, with first name : {firstName} , with last name: {lastName}\n";

            for(int i=0; i<= Products.Count-1; i++)
            {
                s = s + $"\t\t\t\t\t\t\t\t\t\t{Products[i]}\n";
            }
            s = s + $"}}";
            return s;
        }


    }
}
