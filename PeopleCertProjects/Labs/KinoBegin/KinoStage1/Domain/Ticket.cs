using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Services;

namespace KinoStage1.Domain
{
    class Ticket
    {
        private static int _tid;

        public static int Tid
        {
            get { return _tid; }
            set { _tid = value; }
        }

        private List<int> _Numbers;

        public List<int> Numbers
        {
            get { return _Numbers; }
            set { _Numbers = value; }
        }

        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }


        public Ticket()
        {
            Numbers = GenerateNumbers();
            GenerateID();
            KinoBonus = PlayWithKinoBonus();
        }

        public Ticket(bool KinoBonuss)
        {
            Numbers = GenerateNumbers();
            GenerateID();
            KinoBonus = KinoBonuss;
        }

        public static void GenerateID()
        {
            Tid++;
        }

        public bool PlayWithKinoBonus()
        {
            Console.WriteLine("Do you want play with Kino Bonus  Press : Y/N");
            string s = Console.ReadLine().ToUpper();
            while (s != "Y" && s != "N")
            {
                Console.WriteLine("Please Enter Y or N");
                Console.WriteLine("Do you want play with Kino Bonus  Press : Y/N");
                s = Console.ReadLine().ToUpper();
            }
            if(s == "Y")
            {
                return true;
            } else
            {
                return false;
            }
           
        }

        public List<int> GenerateNumbers()
        {
            List<int> Numbers = new List<int>();
            for(int i=0; i<=6; i++)
            {
                int number = RandomService.Number(1, 80);
                if(i == 0)
                {
                    Numbers.Add(number);
                }
                else
                {
                    bool isUnique = CheckIfNumIsUnique(Numbers,number);
                    while (!isUnique)
                    {
                        number = RandomService.Number(1, 80);
                        isUnique = CheckIfNumIsUnique(Numbers, number);
                    }
                    Numbers.Add(number);
                }
            }
            return Numbers;
        }

        public bool CheckIfNumIsUnique(List<int> Numbers, int number)
        {
            int count = 0;
            for (int i = 0; i <= Numbers.Count-1; i++)
            {
                if (Numbers[i] == number)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            string s = $"Ticket {{ {Tid}\n";
            for (int i = 0; i <= Numbers.Count - 1; i++)
            {
                s = s + $"Number {i + 1} -> {Numbers[i]}\n";
            }
            
            if (KinoBonus)
            {
                s = s + $" play with KinoBonus";
            }
            else
            {
                s = s + $" don't play with Kino Bonus";
            }
            return s;
        }
    }
}
