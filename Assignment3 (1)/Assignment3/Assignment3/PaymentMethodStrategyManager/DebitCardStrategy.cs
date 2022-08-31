using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategyManager
{
    public class DebitCardStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if(amount < 0M || amount > 10000M)
            {
                Console.WriteLine($"Paying {amount} euros using Debit Card is DECLINED");

                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} euros using Debit Card is ACCEPTED");
                return true;
            }
        }
    }
}
