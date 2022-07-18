using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimpleFactory
    {
        public static ICard Create(Card choice)
        {
            switch (choice)
            {
                case Card.MasterCard: return new MasterCard();
                case Card.VisaCard: return new VisaCard();
                case Card.PaySafeCard: return new PaySafeCard();
                default: return null;
            }
        }
    }
}
