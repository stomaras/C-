using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    static class PrintService
    {

        public static void PrintProducts(List<IProductModel> cart, CustomerModel customer)
        {
            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProduct digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
                }
            }
        }
    }
}
