using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's send the product to order manager 
            var product = string.Empty;
            var orderManager = new OrderManager();
            while (product != "exit")
            {
                Console.WriteLine("Enter a Product:",
                    "Keyboard = 0",
                    "Mouse = 1",
                    "Mic = 2",
                    "Speaker = 3",
                    "");
                product = Console.ReadLine();
                if (Enum.TryParse(product, out Product productEnum))
                {
                    Console.WriteLine("Please enter a valid payment method: xxxxxxxxxxxxxxxx;MMYY");
                    var paymentMethod = Console.ReadLine();
                    if (string.IsNullOrEmpty(paymentMethod) || !paymentMethod.Split(";").Length == 2)
                    {
                        throw new Exception("Invalid Payment Method");
                    }
                    orderManager.Submit(product)
                }
                else
                {
                    Console.WriteLine("Invalid Product");
                }
            }
        }
    }
}
