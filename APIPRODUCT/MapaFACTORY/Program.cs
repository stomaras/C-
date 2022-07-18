using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaFACTORY
{
    internal class Program
    {
        static void Main(string[] args)// High Level
        {
            // Depends on details of the card in the controller i want an abstraction.
            VisaCard card = new VisaCard();
            card.GetCardType();
            card.GetCreditLimit();
        }
    }

    public class MasterCard
    {
        public void GetCardType()
        {
            Console.WriteLine("Master Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("35000");
        }

    }

    public class VisaCard
    {
        public void GetCardType()
        {
            Console.WriteLine("Visa Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("55000");
        }

    }

    public class PaySafeCard
    {
        public void GetCardType()
        {
            Console.WriteLine("Pay Safe Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("95000");
        }

    }




}
