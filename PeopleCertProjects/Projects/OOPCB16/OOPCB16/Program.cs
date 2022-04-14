using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCB16
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Product myProduct = warehouse.FindAndReturnProduct(1);
            Console.WriteLine(myProduct.ID);


            Hardware motherboard = new Hardware();
            motherboard.ID = 888;
            motherboard.Name = "ASUS";
            motherboard.Price = 123;
            motherboard.SerialNumber = 77847824;

            Software excel = new Software
            {
                ID = 98,
                Name = "excel",
                ISBN = 87487,
                Price = 4
            };

            var myComputer = new Computer();
            myComputer.ID = 565;
            myComputer.Name = "My First Computer";

            Product mySecondComputer = new Computer();
            mySecondComputer.ID = 99;
            mySecondComputer.Price = 111;

            Computer myThirdComputer = mySecondComputer as Computer;
            myThirdComputer.SerialNumber = 8787;
            myThirdComputer.Price = 222;

            Product product = new Product();
            product.Sale();

            motherboard.Sale();
            mySecondComputer.Sale();
            excel.Sale();

            var products = new List<Product>();
            products.Add(product);
            products.Add(excel);
            products.Add(mySecondComputer);

            foreach (var productt in products)
            {
                Console.WriteLine($"{productt.Name}");
                productt.Sale(); // polymorphism
            }

        }
    }
}
