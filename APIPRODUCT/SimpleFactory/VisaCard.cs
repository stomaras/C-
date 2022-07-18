using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class VisaCard : ICard
    {

        public void GetCardType()
        {
            Console.WriteLine("Visa Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("36000");
        }
    }
}
