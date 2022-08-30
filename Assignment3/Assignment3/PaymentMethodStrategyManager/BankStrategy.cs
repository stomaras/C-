using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategyManager
{
    public class BankStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0M || amount > 6000M)
            {
                Console.WriteLine($"Paying {amount} euros using Bank is DECLINED");
                return false;
            }

            else
            {
                Console.WriteLine($"Paying {amount} euros using Bank is ACCEPTED");
                return true;

            }
        }
    }
}
