using Assignment3.Models;
using Assignment3.PaymentMethodStrategyManager;
using Assignment3.VariationStrategyManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.EshopContext
{
    public class EShop
    {
        private IEnumerable<IVariationStrategy> variationsPriceListStrategies;
        private IPaymentMethodStrategy paymentMethodStrategy;

        public void SetPriceListVariation(IEnumerable<IVariationStrategy> strategies)
        {
            variationsPriceListStrategies = strategies;
        }

        public void SetPaymentMethod(IPaymentMethodStrategy method)
        {
            paymentMethodStrategy = method;
        }

        public void PayTshirt(decimal price)
        {
            if (paymentMethodStrategy.Pay(price))
            {
                Console.WriteLine("Transaction Successfull");
            }
            else
            {
                Console.WriteLine("Transaction Declined");

            }
        }
        public decimal CalculateCost(TShirt tshirt)
        {
            foreach (var strategy in variationsPriceListStrategies)
            {
                strategy.Cost(tshirt);
            }
            Console.WriteLine($"T-shirt final price is {tshirt.Price} euros");
            return tshirt.Price;
        }
    }
}
