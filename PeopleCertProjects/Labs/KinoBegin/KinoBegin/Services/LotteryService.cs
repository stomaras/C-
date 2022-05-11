using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBegin.Services
{
    class LotteryService
    {
        public List<int> RandomNumbersGeneration { get; private set; }

        public LotteryService()
        {

        }


        public List<int> AddKinoNumbers(List<int> RandomNumbersGeneration)
        {
            for (int i = 0; i <= 10; i++)
            {
                int num;
                bool isUnique = false;
                if (i == 0)
                {
                    num = RandomService.Number(1, 80);
                    RandomNumbersGeneration.Add(num);
                }
                if (i > 0)
                {

                    while (!isUnique)
                    {

                        num = RandomService.Number(1, 80);
                        isUnique = CheckUniqueNumber(num, RandomNumbersGeneration);
                        if (isUnique)
                        {
                            RandomNumbersGeneration.Add(num);
                        }

                    }

                }
            }
            return RandomNumbersGeneration;
        }

        public bool CheckUniqueNumber(int number, List<int> RandomNumbersGeneration)
        {

            for (int i = 0; i <= RandomNumbersGeneration.Count - 1; i++)
            {
                if (RandomNumbersGeneration[i] == number)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
