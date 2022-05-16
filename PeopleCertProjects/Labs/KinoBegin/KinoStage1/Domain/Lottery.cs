using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Domain;
using KinoStage1.Services;

namespace KinoStage1.Domain
{
    class Lottery
    {

        private static int _lid;

        public static int Lid
        {
            get { return _lid; }
            set { _lid = value; }
        }

        private List<int> _LotteryNumbers;

        public List<int> LotteryNumbers
        {
            get { return _LotteryNumbers; }
            set { _LotteryNumbers = value; }
        }

        public Lottery()
        {
            GenerateLotteryID();
            LotteryNumbers = GenerateNumbers();
        }

        private void GenerateLotteryID()
        {
            Lid++;
        }

        public List<int> GenerateNumbers()
        {
            List<int> Numbers = new List<int>();
            for (int i = 0; i <= 11; i++)
            {
                int number = RandomService.Number(1, 80);
                if (i == 0)
                {
                    Numbers.Add(number);
                }
                else
                {
                    bool isUnique = CheckIfNumIsUnique(Numbers, number);
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
            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                if (Numbers[i] == number)
                {
                    count++;

                }
            }
            if (count == 0)
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
            string s = $"Lottery {Lid}\n";
            for(int i=0; i<= LotteryNumbers.Count-1; i++)
            {
                s = s + $"\t Number {i+1} -> {LotteryNumbers[i]}\n";
            }
            return s;
        }



    }
}
