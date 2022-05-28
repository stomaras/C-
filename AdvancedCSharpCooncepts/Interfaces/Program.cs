using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*
     * How do i put digital product model into this cart and the answer is i can't 
     * Interface is a contract here is the things where whichever class must implement 
     * We depend on these contracts.
     * There is no source code in interfaces.
     * There are different ways in how we implement ShipItem
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Interface allow us to type more than one type inside th List
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            PrintService.PrintProducts(cart, customer);
            //foreach (IProductModel prod in cart)
            //{
            //    prod.ShipItem(customer);

            //    if (prod is IDigitalProduct digital)
            //    {
            //        Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
            //    }
            //}
            //Console.ReadLine();

        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new DigitalProductModel { Title = "Complete Guide To AP.NET" });
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish" });
            return output;
        }
    }
}
