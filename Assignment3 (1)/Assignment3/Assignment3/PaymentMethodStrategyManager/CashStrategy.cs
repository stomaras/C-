using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategyManager
{
    public class CashStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if(amount < 0M  || amount >2000M)
            {
                Console.WriteLine($"Paying {amount} euros using Cash is DECLINED");
                return false;
            }
                
            else
            {
                Console.WriteLine($"Paying {amount} euros using Cash is ACCEPTED");
                return true;

            }
        }
    }
}
