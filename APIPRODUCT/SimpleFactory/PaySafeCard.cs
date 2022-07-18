using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PaySafeCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("Pay Safe Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("56000");
        }
    }
}
